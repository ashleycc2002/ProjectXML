using Layer.DATA.GRepository;
using Layer.DATA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.BLL.Customers
{
    public class CountriesCommandService : ICountryCommandService<Country>
    {
        private IRepository<Country> _repository;

        public IEnumerable<Country> country => throw new NotImplementedException();

        public CountriesCommandService(IRepository<Country> repository)
        {
                _repository = repository ?? throw new ArgumentException(nameof(repository));    
        }

        public void Add(Country entity)
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

        public void Add(params Country[] items)
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

        public void Delete(Country entity)
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

        public void Delete(params Country[] items)
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

        public IList<Country> GetAll()
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

        public IQueryable<Country> GetAllList(bool intactive)
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

        public IList<Country> GetEntity()
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

        public Country GetEntityById(int id)
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

        public Country GetEntityByName(string name)
        {
            try
            {
                return _repository.GetSingle(x => x.Descripcion.Equals(name));
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Country entity)
        {
            try
            {

                var country = _repository.GetAll().FirstOrDefault(x => x.Id.Equals(entity.Id));

                country.Id = entity.Id;
                country.Descripcion = entity.Descripcion;
                country.IsoCode = entity.IsoCode;
                country.IsoCodi = entity.IsoCodi;
               
                _repository.Update(country);
                _repository.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(params Country[] items)
        {
            try
            {
                var newcastle = new List<Country>();

                var country = _repository.GetAll().FirstOrDefault(x => x.Id.Equals(items[0].Id));

                foreach (var item in items)
                {
                    country.Id = item.Id;
                    country.Descripcion = item.Descripcion;
                    country.IsoCode = item.IsoCode;
                    country.IsoCodi = item.IsoCodi;

                }

                newcastle.Add(country);

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
