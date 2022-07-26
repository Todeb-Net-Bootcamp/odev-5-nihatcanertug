using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODEB_DotnetCore_Project.BusinessLayer.Abstract;
using TODEB_DotnetCore_Project.BusinessLayer.Configuration.Response;
using TODEB_DotnetCore_Project.DataAccessLayer.Abstract;
using TODEB_DotnetCore_Project.EntityLayer.Entities.Concrete;

namespace TODEB_DotnetCore_Project.BusinessLayer.Concrete
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }
        public CommandResponse Delete(Customer customer)
        {
            _repository.Delete(customer);
            return new CommandResponse
            {
                Status = true,
                Message = $"Musteri silindi. Id = {customer.Id}"
            };
        }

        public IEnumerable<Customer> GetAll()
        {
            return _repository.GetAll();
        }

        public CommandResponse Insert(Customer customer)
        {
            _repository.Insert(customer);
            return new CommandResponse
            {
                Status = true,
                Message = $"Musteri kayit edildi. Id = {customer.Id}"
            };
        }

        public CommandResponse Update(Customer customer)
        {
            _repository.Update(customer);
            return new CommandResponse
            {
                Status = true,
                Message = $"Musteri guncellendi. Id = {customer.Id}"
            };
        }
    }
}
