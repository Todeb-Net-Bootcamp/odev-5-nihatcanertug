using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODEB_DotnetCore_Project.Domain.Entities.Interface;

namespace TODEB_DotnetCore_Project.Domain.Entities.Concrete
{
    public class Loan : IBaseEntity
    {
        [Key] // We set id as the primary key.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // We set it as identity key and auto id value will be increased by 1.
        public int Id { get; set; }
        public float Monthly_Rate { get; set; }
        public int Duration_Month { get; set; }
        public DateTime First_Payment { get; set; }
        public DateTime Monthly_Due_Date { get; set; }

        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get => _createDate; set => _createDate = value; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        //[ForeignKey("Account")]
        public int AccountId { get; set; }
        public virtual Account Account { get; set; }
    }
}
