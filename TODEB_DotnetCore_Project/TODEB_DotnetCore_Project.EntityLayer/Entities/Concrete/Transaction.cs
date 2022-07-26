using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TODEB_DotnetCore_Project.EntityLayer.Entities.Interface;

namespace TODEB_DotnetCore_Project.EntityLayer.Entities.Concrete
{
    public class Transaction : IBaseEntity
    {
        [Key] // We set id as the primary key.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // We set it as identity key and auto id value will be increased by 1.
        public int Id { get; set; }
        public DateTime Transaction_Date { get; set; }
        public float Credit_Amount { get; set; }
        public float Debit_Amount { get; set; }
        public float Running_Balance { get; set; }

        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get => _createDate; set => _createDate = value; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        [ForeignKey("Account")]
        public int AccountId { get; set; }
        public virtual Account Account { get; set; }
    }
}
