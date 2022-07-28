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
        private IMapper _mapper;

        public CustomerService(ICustomerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public CommandResponse Delete(DeleteCustomerRequest request)
        {
            _repository.Delete(customer);
            return new CommandResponse
            {
                Status = true,
                Message = $"Musteri silindi. Id = {request.Id}"
            };
        }

        public IEnumerable<Customer> GetAll()
        {
            return _repository.GetAll();
        }

        public CommandResponse Insert(CreateCustomerRequest request)
        {
            var entity = _mapper.Map<Customer>(request);

            var validator = new CreateCustomerRequestValidator();
            var valid = validator.Validate(request);

            //var entity = new Customer();
            //entity.Email = request.Email;
            //entity.Phone = request.Phone;
            //entity.Name = request.Name;
            //entity.Surname = request.Surname;

            if(valid.IsValid == false)
                throw new Exception("Hata olustu!");

            _repository.Insert(customer);
            return new CommandResponse
            {
                Status = true,
                Message = $"Musteri kayit edildi. Id = {request.Id}"
            };
        }

        public CommandResponse Update(UpdateCustomerRequest request)
        {
            
            var validator = new UpdateCustomerRequestValidator();
            var valid = validator.Validate(request);

            var entity = _repository.Get(request.Id);
            if(entity == null)
                throw new Exception("veri tabanında kayıt bulunamadı");

            if(valid.IsValid == false)
                throw new Exception("Hata olustu!");
            _repository.Update(request);
            return new CommandResponse
            {
                Status = true,
                Message = $"Musteri guncellendi. Id = {request.Id}"
            };
        }
    }
}
