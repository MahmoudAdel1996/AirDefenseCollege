using Nozom.Domain;
using Nozom.Infrastructure.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace WrshaDesktopApp.Views
{
    public partial class Form2 : Form
    {

        private readonly DomainContext _context;
        private readonly int _selectedTransactionId;
        public Form2(DomainContext context, TransactionDTO selectedTransaction)
        {
            InitializeComponent();
            _context = context;
            _selectedTransactionId = selectedTransaction.Id;
            lblReciveTitle.Text = $"({selectedTransaction.Id}) تسليم جهاز رقم";
            FillComboBox();
            ShowDialog();
        }
        private void FillComboBox()
        {
            var daragat = _context.Daragat.GetAll();
            DataTable Daragadt = new DataTable();
            Daragadt.Columns.Add("Id");
            Daragadt.Columns.Add("Name");
            foreach (var daraga in daragat)
            {
                Daragadt.Rows.Add(daraga.Id, daraga.Name);
            }
            CmbHandOverToDraga.ValueMember = Daragadt.Columns[0].ColumnName;
            CmbHandOverToDraga.DisplayMember = Daragadt.Columns[1].ColumnName;
            CmbHandOverToDraga.DataSource = Daragadt;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnHandOver_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtHandOverToName.Text))
            {
                MessageBox.Show("برجاء ملئ البيانات", "خطأ");
            }
            else 
            {
                var transaction = _context.Transactions.GetById(_selectedTransactionId);
                transaction.HandOverToDaragaId = Convert.ToInt32(CmbHandOverToDraga.SelectedValue);
                transaction.HandOverToName = TxtHandOverToName.Text.Trim();
                transaction.ExitDate = DateTime.Now;
                try
                {
                    _context.Transactions.Update(transaction);
                    _context.Complete();
                    MessageBox.Show("تم التسليم بناح");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error");
                }
            }
        }
    }
}
