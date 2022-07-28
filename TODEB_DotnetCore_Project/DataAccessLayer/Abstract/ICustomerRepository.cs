using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODEB_DotnetCore_Project.EntityLayer.Entities.Concrete;

namespace TODEB_DotnetCore_Project.DataAccessLayer.Abstract
{
    public interface ICustomerRepository
    {
        public IEnumerable<Customer> GetAll();
        public void Insert(Customer customer);
        public void Update(Customer customer);
        public void Delete(Customer customer);
        public Customer Get(int id);
    }
}
