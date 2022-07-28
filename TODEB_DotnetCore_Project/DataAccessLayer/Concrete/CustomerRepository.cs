using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODEB_DotnetCore_Project.DataAccessLayer.Abstract;
using TODEB_DotnetCore_Project.EntityLayer.Entities.Concrete;

namespace TODEB_DotnetCore_Project.DataAccessLayer.Concrete
{
    public class CustomerRepository : ICustomerRepository
    {
        private ApplicationDbContext context;
        public CustomerRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void Delete(Customer customer)
        {
            context.Customers.Remove(customer);
            context.SaveChanges();
        }

        public IEnumerable<Customer> GetAll()
        {
            return context.Customers.ToList();
        }

        public void Insert(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
        }

        public void Update(Customer customer)
        {
            context.Customers.Update(customer);
            context.SaveChanges();
        }
        public Customer Get(int id)
        {
            return context.Customers.FirstOrDefault(x => x.Id == id);
        }
    }
}
