using Layer.DATA.GRepository;
using Layer.DATA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.BLL.Customers
{
    public class ServerInformationCommandService : IServerCommandService<ServerInfo>
    {
        public readonly IRepository<ServerInfo> _repository;

        public IEnumerable<ServerInfo> country => throw new NotImplementedException();

        public ServerInformationCommandService(IRepository<ServerInfo> repository)
        {
            _repository = repository ?? throw new ArgumentException(nameof(repository));
        }

        public void Add(ServerInfo entity)
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

        public void Add(params ServerInfo[] items)
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

        public void Delete(ServerInfo entity)
        {
            try
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
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(params ServerInfo[] items)
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

        public IList<ServerInfo> GetAll()
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

        public IQueryable<ServerInfo> GetAllList(bool intactive)
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

        public IList<ServerInfo> GetEntity()
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

        public ServerInfo GetEntityById(int id)
        {
            try
            {
                return _repository.GetSingle(x => x.SesionId.Equals(id));
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ServerInfo GetEntityByName(string name)
        {
            try
            {
                return _repository.GetSingle(x => x.Country.Equals(name));
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(ServerInfo entity)
        {
            try
            {

                var server = _repository.GetAll().FirstOrDefault(x => x.Id.Equals(entity.Id));

                server.Id = entity.Id;
                server.ServerSource = entity.ServerSource;
                server.ServiceSource = entity.ServiceSource;
                server.Chanel = entity.Chanel;
                server.Funcion = entity.Funcion;
                server.Languge = entity.Languge;
                server.Country= entity.Country;
                server.SesionId = entity.SesionId;
                server.Serverip = entity.Serverip;
               
                _repository.Update(server);
                _repository.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(params ServerInfo[] items)
        {
            try
            {
                var newcastle = new List<ServerInfo>();

                var server = _repository.GetAll().FirstOrDefault(x => x.Id.Equals(items[0].Id));

                foreach (var item in items)
                {
                    if (server == null) continue;
                    server.Id = item.Id;
                    server.ServerSource = item.ServerSource;
                    server.ServiceSource = item.ServiceSource;
                    server.Chanel = item.Chanel;
                    server.Funcion = item.Funcion;
                    server.Languge = item.Languge;
                    server.Country = item.Country;
                    server.SesionId = item.SesionId;
                    server.Serverip = item.Serverip;

                }

                newcastle.Add(server);

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
