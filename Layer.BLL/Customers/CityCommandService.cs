using Layer.DATA.GRepository;
using Layer.DATA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.BLL.Customers
{
    public class CityCommandService : ICityCommandService<City>
    {
        public readonly IRepository<City> _repository;
        public IEnumerable<City> country => throw new NotImplementedException();

        public CityCommandService(IRepository<City> repository)
        {
            _repository = repository ?? throw new ArgumentException(nameof(repository));
        }

        public void Add(City entity)
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

        public void Add(params City[] items)
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

        public void Delete(City entity)
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

        public void Delete(params City[] items)
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

        public IList<City> GetAll()
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

        public IQueryable<City> GetAllList(bool intactive)
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

        public IList<City> GetEntity()
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

        public City GetEntityById(int id)
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

        public City GetEntityByName(string name)
        {
            try
            {
                return _repository.GetSingle(x => x.Description.Equals(name));
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(City entity)
        {
            try
            {

                var city = _repository.GetAll().FirstOrDefault(x => x.Id.Equals(entity.Id));

                city.Id = entity.Id;
                city.CountryId = entity.CountryId;
                city.Description = entity.Description;
                city.Code = entity.Code;
                city.State = entity.State;
                city.Longitude = entity.Longitude;
                city.Latitude = entity.Latitude;
                city.TimeZone = entity.TimeZone;
                city.ExternalId = entity.ExternalId;
                city.Enabled = entity.Enabled;
              
                _repository.Update(city);
                _repository.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(params City[] items)
        {
            try
            {
                var newcastle = new List<City>();

                var city = _repository.GetAll().FirstOrDefault(x => x.Id.Equals(items[0].Id));

                foreach (var item in items)
                {
                    if (city == null) continue;
                    city.Id = item.Id;
                    city.CountryId = item.CountryId;
                    city.Description = item.Description;
                    city.Code = item.Code;
                    city.State = item.State;
                    city.Longitude = item.Longitude;
                    city.Latitude = item.Latitude;
                    city.TimeZone = item.TimeZone;
                    city.ExternalId = item.ExternalId;
                    city.Enabled = item.Enabled;

                }

                newcastle.Add(city);

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
