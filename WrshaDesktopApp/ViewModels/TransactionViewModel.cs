using Nozom.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WrshaDesktopApp.ViewModels
{
    public class TransactionViewModel
    {
        [DisplayName("م")]
        public int Id { get; set; }
        [DisplayName("سريال")]
        public string DeviceSrialNumber { get; set; }
        [DisplayName("وقت الاستلام")]
        public DateTime EnterDate { get; set; }
        [DisplayName("الدرجة")]
        public string OwnerDaraga { get; set; }
        [DisplayName("اسم المسلم")]
        public string OwnerName { get; set; }
        [DisplayName("النوع")]
        public string DeviceType { get; set; }
        [DisplayName("الموديل")]
        public string DeviceName { get; set; }
        [DisplayName("الدرجة")]
        public string ReciverDaraga { get; set; }
        [DisplayName("اسم المستلم")]
        public string ReciverName { get; set; }
        [DisplayName("الفرع")]
        public string DeviceBranch { get; set; }
        [DisplayName("الدرجة")]
        public string HandOverToDaraga { get; set; }
        [DisplayName("تم تسليم إلي")]
        public string HandOverToName { get; set; }
        [DisplayName("وقت التسليم")]
        public DateTime? ExitDate { get; set; }
        [DisplayName("وصف المشكلة")]
        public string ProblemDeescription { get; set; }
        [DisplayName("ملاحظات")]
        public string Notes { get; set; }
        [DisplayName("الحالة")]
        public string DeviceState { get; set; }

        public TransactionViewModel(){}
        public TransactionViewModel(TransactionDTO transaction){
            this.Id = transaction.Id;
            this.EnterDate = transaction.EnterDate;
            this.ExitDate = transaction.ExitDate;
            this.OwnerDaraga = transaction.OwnerDaraga.Name;
            this.OwnerName = transaction.OwnerName;
            this.ReciverDaraga = transaction.ReciverDaraga.Name;
            this.ReciverName = transaction.ReciverName;
            this.DeviceBranch = transaction.DeviceBranch.Name;
            this.DeviceState = transaction.DeviceState.State;
            this.DeviceType = transaction.DeviceType.Type;
            this.DeviceName = transaction.DeviceName;
            this.HandOverToDaraga = transaction.HandOverToDaraga?.Name;
            this.HandOverToName = transaction.HandOverToName;
            this.ProblemDeescription = transaction.ProblemDeescription;
            this.DeviceSrialNumber = transaction.DeviceSrialNumber;
            this.Notes = transaction.Notes;
        }
    }
}
