using Layer.DATA.GRepository;
using Layer.DATA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.BLL.Customers
{
     public class CustomerCommandService: ICustomerInformationCommandService<InfoCustomer>
     {
        public readonly IRepository<InfoCustomer> _repository;

        public CustomerCommandService(IRepository<InfoCustomer> repository)
        {
            _repository = repository ?? throw new ArgumentException(nameof(repository));
        }

        public IEnumerable<InfoCustomer> country => throw new NotImplementedException();

        public void Add(InfoCustomer entity)
        {
            try
            {
                _repository.Add(entity);
                _repository.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Add(params InfoCustomer[] items)
        {
            try
            {
                _repository.Add(items);
                _repository.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(InfoCustomer entity)
        {
            try
            {
                    _repository.Remove(entity);
                    _repository.SaveChanges();
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(params InfoCustomer[] items)
        {
            try
            {
                _repository.Remove(items);
                _repository.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IList<InfoCustomer> GetAll()
        {
            try
            {
                return _repository.GetAll();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IQueryable<InfoCustomer> GetAllList(bool intactive)
        {
            try
            {
                return _repository.GetEntity(intactive);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IList<InfoCustomer> GetEntity()
        {
            try
            {

                return _repository.GetAll();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public InfoCustomer GetEntityById(int id)
        {
            try
            {
                return _repository.GetSingle(x => x.Id.Equals(id));
            }
            catch (Exception)
            {

                throw;
            }
        }

        public InfoCustomer GetEntityByName(string name)
        {
            try
            {
                return _repository.GetSingle(x => x.CustomerName.Equals(name));
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(InfoCustomer entity)
        {
            try
            {

                var customer = _repository.GetAll().FirstOrDefault(x => x.Id.Equals(entity.Id));

                customer.Id= entity.Id;
                customer.CustomerName = entity.CustomerName;
                customer.UserId = entity.UserId;
                customer.CustomerType = entity.CustomerType;
                customer.CustomerSegment = entity.CustomerSegment;
                customer.Email = entity.Email;
                customer.CustomerBranch = entity.CustomerBranch;
                customer.ParentCustomerId = entity.ParentCustomerId;
                customer.ChildDocumentType = entity.ChildDocumentType;
                customer.DocumentType = entity.DocumentType;
                customer.DocumentNumber = entity.DocumentNumber;
               

                _repository.Update(customer);
                _repository.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(params InfoCustomer[] items)
        {
            try
            {
                var newcastle = new List<InfoCustomer>();

                var customer = _repository.GetAll().FirstOrDefault(x => x.Id.Equals(items[0].Id));

                foreach (var item in items)
                {
                    customer.Id = item.Id;
                    customer.CustomerName = item.CustomerName;
                    customer.UserId = item.UserId;
                    customer.CustomerType = item.CustomerType;
                    customer.CustomerSegment = item.CustomerSegment;
                    customer.Email = item.Email;
                    customer.CustomerBranch = item.CustomerBranch;
                    customer.ParentCustomerId = item.ParentCustomerId;
                    customer.ChildDocumentType = item.ChildDocumentType;
                    customer.DocumentType = item.DocumentType;
                    customer.DocumentNumber = item.DocumentNumber;

                }

                newcastle.Add(customer);

                _repository.Update(newcastle.ToArray());
                _repository.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
