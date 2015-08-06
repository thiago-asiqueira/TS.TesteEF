using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using TS.TesteEF.Data.Context;
using TS.TesteEF.Domain.Contracts.Repositories;
using TS.TesteEF.Domain.Entities;

namespace TS.TesteEF.Data.Repositories
{
    public sealed class ClienteRepository
        : IRepositoryCliente
    {
        private readonly TesteEFContext _context;

        public ClienteRepository(TesteEFContext context)
        {
            _context = context;
        }

        public void Add(ClienteEntity entity)
        {
            _context.ClienteEntities.Add(entity);
        }

        public void DeleteById(int id)
        {
            var item = GetById(id);
            _context.ClienteEntities.Remove(item);
        }

        public IEnumerable<ClienteEntity> GetAll()
        {
            return _context.ClienteEntities.ToList();
        }

        public ClienteEntity GetById(int id)
        {
            return _context.ClienteEntities.SingleOrDefault(x => x.Id == id);
        }

        public void Update(ClienteEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
