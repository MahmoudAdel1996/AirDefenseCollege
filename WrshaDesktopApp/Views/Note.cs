using Nozom.Data.Entities;
using Nozom.Domain;
using Nozom.Domain.Repositories;
using Nozom.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WrshaDesktopApp.Views
{
    public partial class Note : Form
    {
        TransactionDTO currentTransaction;
        private readonly DomainContext _context;
        private readonly bool _isNote; // Note Or ProblemDescription clicked on context menue
        public Note(DomainContext context, TransactionDTO transaction, bool iSNote)
        {
            _context = context;
            _isNote = iSNote;
            currentTransaction = transaction;
            InitializeComponent();
            if (iSNote)
            {
                this.Text = "تعديل الملاحظات";
                lblNoteTitle.Text = $"({transaction.Id}) ملاحظات جهاز رقم";
                txtNote.Text = transaction.Notes;
            }
            else
            {
                this.Text = "وصف المشكلة";
                lblNoteTitle.Text = $"({transaction.Id}) تعديل وصف مشكلة جهاز رقم";
                txtNote.Text = transaction.ProblemDeescription;
            }
            this.ShowDialog();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (_isNote)
                currentTransaction.Notes = txtNote.Text.Trim();
            else
                currentTransaction.ProblemDeescription = txtNote.Text.Trim();
            _context.Transactions.Update(currentTransaction);
            _context.Complete();
            MessageBox.Show("تم التعديل");
            this.Close();
        }
    }
}
