using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODEB_DotnetCore_Project.BusinessLayer.Configuration.Response;
using TODEB_DotnetCore_Project.EntityLayer.Entities.Concrete;

namespace TODEB_DotnetCore_Project.BusinessLayer.Abstract
{
    public interface ICustomerService
    {
        public IEnumerable<Customer> GetAll();
        public CommandResponse Insert(CreateCustomerRequest customer);
        public CommandResponse Update(UpdateCustomerRequest customer);
        public CommandResponse Delete(DeleteCustomerRequest customer);
    }
}
