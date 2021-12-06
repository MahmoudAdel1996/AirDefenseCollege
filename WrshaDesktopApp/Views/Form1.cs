using Nozom.Data.Entities;
using Nozom.Domain;
using Nozom.Domain.Repositories;
using Nozom.Infrastructure;
using Nozom.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WrshaDesktopApp.ViewModels;
using WrshaDesktopApp.Views;

namespace WrshaDesktopApp
{
    public partial class Form1 : Form
    {
        private readonly DomainContext _context;
        private List<TransactionViewModel> _allTransaction;
        public Form1(WrshaDbContext context)
        {
            _context = new DomainContext(context, 
                typeof(BranchRepository),
                typeof(DaragaRepository),
                typeof(DeviceTypeRepository),
                typeof(DeviceStateRepository),
                typeof(TransactionRepository));
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillComboboxs();
            FillFilterCombobox();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }


        private void BtnRecive_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtOwnerName.Text) ||
                string.IsNullOrWhiteSpace(TxtDeviceName.Text) || 
                string.IsNullOrWhiteSpace(TxtReciverName.Text) ||
                string.IsNullOrWhiteSpace(CmbDeviceType.Text))
            {
                MessageBox.Show("برجاء ملئ جميع البيانات", "خطأ");
            } 
            else
            {
                var transaction = new TransactionDTO();
                int deviceTypeId;

                if (CmbDeviceType.SelectedValue == null)
                {
                    var deviceType = new DeviceTypeDTO
                    {
                        Type = CmbDeviceType.Text.Trim()
                    };
                    _context.DeviceTypes.Add(deviceType);
                    _context.Complete();
                    deviceTypeId = _context.DeviceTypes.GetByType(CmbDeviceType.Text).Id;
                }
                else
                { 
                    deviceTypeId = Convert.ToInt32(CmbDeviceType.SelectedValue);
                }

                transaction.DeviceTypeId = deviceTypeId;
                transaction.OwnerDaragaId = Convert.ToInt32(CmbDaragaOwner.SelectedValue);
                transaction.ReciverDaragaId = Convert.ToInt32(CmbDaragaReciver.SelectedValue);
                transaction.DeviceBranchId = Convert.ToInt32(CmbOwnerBranch.SelectedValue);
                transaction.OwnerName = TxtOwnerName.Text.Trim();
                transaction.ReciverName = TxtReciverName.Text.Trim();
                transaction.DeviceName = TxtDeviceName.Text.Trim();
                transaction.DeviceSrialNumber = TxtSerialNumber.Text.Trim().ToUpper();
                transaction.EnterDate = DateTime.Now;
                transaction.ProblemDeescription = TxtDescription.Text.Trim();
                try
                {
                    _context.Transactions.Add(transaction);
                    _context.Complete();
                    MessageBox.Show("تم استلام الجهاز بنجاح", "نجاح");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error");
                }
            }
        }


        // Reset All Fields To Default Values
        private void Reset()
        {
            CmbDaragaOwner.SelectedIndex = 0;
            CmbDaragaReciver.SelectedIndex = 0;
            CmbDeviceType.ResetText();
            CmbOwnerBranch.SelectedIndex = 0;
            TxtDeviceName.ResetText();
            TxtOwnerName.ResetText();
            TxtReciverName.ResetText();
            TxtSerialNumber.ResetText();
            TxtDescription.ResetText();
        }
        List<TransactionViewModel> currentSelected;
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var transactions = _context.Transactions.GetAllWithDetails();
            var model = new List<TransactionViewModel>();
            foreach(var transaction in transactions) {
                model.Add(new TransactionViewModel(transaction));
            }
            _allTransaction = model;
            currentSelected = _allTransaction;
            dataGridView1.DataSource = model;
            CmbFilter.SelectedValue = 0;
        }
        DataGridViewRow[] selectedRows;
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var menuStrip = new ContextMenuStrip();
                int mousePosition = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if (mousePosition >= 0)
                {
                    menuStrip.Items.Add("تم الاصلاح").Name = "Done";
                    menuStrip.Items.Add("تسليم الجهاز").Name = "HandOver";
                    menuStrip.Items.Add("تعديل وصف المشكلة").Name = "ProblemDescription";
                    menuStrip.Items.Add("ملاحظات").Name = "Notes";
                    menuStrip.Show(dataGridView1, new Point(e.X, e.Y));
                    selectedRows = new DataGridViewRow[dataGridView1.SelectedRows.Count];
                    dataGridView1.SelectedRows.CopyTo(selectedRows, 0);
                    foreach (var row in selectedRows)
                    {
                        if (row == null) break;
                        var currentTransaction = _context.Transactions.GetById(Convert.ToInt32(row.Cells["Id"].Value));

                        if (currentTransaction.DeviceStateId == (int)DeviceStatus.Done)
                        {
                            menuStrip.Items["Done"].Enabled = false;
                        }
                        if (currentTransaction.ExitDate != null)
                        {
                            menuStrip.Items["HandOver"].Enabled = false;
                        }
                    }
                    menuStrip.ItemClicked += new ToolStripItemClickedEventHandler(MenuStripItem_Click);
                }
            }
        }

        private void MenuStripItem_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                foreach (var row in selectedRows)
                {
                    var transaction = _context.Transactions.GetById(Convert.ToInt32(row.Cells["Id"].Value));
                    switch (e.ClickedItem.Name)
                    {
                        case "Done":
                            _context.Transactions.UpdateTransactionState(transaction.Id);
                            _context.Complete();
                            MessageBox.Show("تم الاصلاح بنجاح");
                            break;

                        case "HandOver":
                            _ = new Form2(_context, transaction);
                            break;
                        case "Notes":
                            _ = new Note(_context, transaction, true);
                            break;
                        case "ProblemDescription":
                            _ = new Note(_context, transaction, false);
                            break;
                    }
                }
                this.tabControl1_SelectedIndexChanged(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        // Fill All ComboBoxes In First Page
        private void FillComboboxs()
        {
            // Fill Daraga ComboBox
            var daragat = _context.Daragat.GetAll();
            DataTable Daragadt = new DataTable();
            Daragadt.Columns.Add("Id");
            Daragadt.Columns.Add("Name");
            foreach (var daraga in daragat)
            {
                Daragadt.Rows.Add(daraga.Id, daraga.Name);
            }
            CmbDaragaOwner.ValueMember = Daragadt.Columns[0].ColumnName;
            CmbDaragaOwner.DisplayMember = Daragadt.Columns[1].ColumnName;
            CmbDaragaOwner.DataSource = Daragadt.Copy();

            CmbDaragaReciver.ValueMember = Daragadt.Columns[0].ColumnName;
            CmbDaragaReciver.DisplayMember = Daragadt.Columns[1].ColumnName;
            CmbDaragaReciver.DataSource = Daragadt.Copy();

            // Fill Device Type ComboBox
            var deviceTypes = _context.DeviceTypes.GetAll();
            DataTable DeviceTypedt = new DataTable();
            DeviceTypedt.Columns.Add("Id");
            DeviceTypedt.Columns.Add("Type");
            foreach (var deviceType in deviceTypes)
            {
                DeviceTypedt.Rows.Add(deviceType.Id, deviceType.Type);
            }
            CmbDeviceType.ValueMember = DeviceTypedt.Columns[0].ColumnName;
            CmbDeviceType.DisplayMember = DeviceTypedt.Columns[1].ColumnName;
            CmbDeviceType.DataSource = DeviceTypedt;
            CmbDeviceType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbDeviceType.AutoCompleteSource = AutoCompleteSource.ListItems;

            // Fill Branches ComboBox
            var Branches = _context.Branchs.GetAll();
            DataTable Branchdt = new DataTable();
            Branchdt.Columns.Add("Id");
            Branchdt.Columns.Add("Type");
            foreach (var branch in Branches)
            {
                Branchdt.Rows.Add(branch.Id, branch.Name);
            }
            CmbOwnerBranch.ValueMember = Branchdt.Columns[0].ColumnName;
            CmbOwnerBranch.DisplayMember = Branchdt.Columns[1].ColumnName;
            CmbOwnerBranch.DataSource = Branchdt;
        }
        // Fill All ComboBoxes In Second Page
        private void FillFilterCombobox()
        {
            // Fill Filter ComboBox
            DataTable Filters = new DataTable();
            Filters.Columns.Add("Id");
            Filters.Columns.Add("Name");

            Filters.Rows.Add(0, "جميع الاجهزة");
            Filters.Rows.Add(1, "اجهزة تم استلامها اليوم");
            Filters.Rows.Add(2, "الاجهزة تم تسليمها اليوم");
            Filters.Rows.Add(3, "اجهزة تم اصلاحها");
            Filters.Rows.Add(4, "اجهزة لم يتم اصلاحها");

            CmbFilter.ValueMember = Filters.Columns[0].ColumnName;
            CmbFilter.DisplayMember = Filters.Columns[1].ColumnName;
            CmbFilter.DataSource = Filters;
            CmbFilter.SelectedIndexChanged += new EventHandler(CmbFilter_SelectedIndexChanged);
        }

        private void CmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(CmbFilter.SelectedValue))
            {
                case 0:
                    dataGridView1.DataSource = _allTransaction;
                    break;
                case 1:
                    dataGridView1.DataSource = _allTransaction.Where(x => x.EnterDate.Date == DateTime.Now.Date).ToList();
                    break;
                case 2:
                    dataGridView1.DataSource = _allTransaction.Where(x => x.ExitDate?.Date == DateTime.Now.Date).ToList();
                    break;
                case 3:
                    dataGridView1.DataSource = _allTransaction.Where(x => x.DeviceState == "تم الاصلاح").ToList();
                    break;
                case 4:
                    dataGridView1.DataSource = _allTransaction.Where(x => x.DeviceState == "قيد الاصلاح").ToList();
                    break;
            }
            TxtSearch.ResetText();
            currentSelected = (List<TransactionViewModel>)dataGridView1.DataSource;
        }

        private void TxtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridView1.DataSource = currentSelected.Where(x => x.DeviceName.ToLower().Contains(TxtSearch.Text.ToLower())).ToList();
        }

        private void TxtSerialNumberSearch_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridView1.DataSource = currentSelected.Where(x => x.DeviceSrialNumber != null ? (x.DeviceSrialNumber.Contains(TxtSerialNumberSearch.Text.ToUpper())) : string.IsNullOrEmpty(TxtSerialNumberSearch.Text.Trim())).ToList();
        }
    }
}
