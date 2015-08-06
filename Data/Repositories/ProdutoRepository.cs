using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using TS.TesteEF.Data.Context;
using TS.TesteEF.Domain.Contracts.Repositories;
using TS.TesteEF.Domain.Entities;

namespace TS.TesteEF.Data.Repositories
{
    public sealed class ProdutoRepository : IRepositoryProduto
    {
        private readonly TesteEFContext _context;

        public ProdutoRepository(TesteEFContext context)
        {
            _context = context;
        }

        public void Add(ProdutoEntity entity)
        {
            _context.ProdutoEntities.Add(entity);
        }

        public void DeleteById(int id)
        {
            var item = GetById(id);
            _context.ProdutoEntities.Remove(item);
        }

        public IEnumerable<ProdutoEntity> GetAll()
        {
            return _context.ProdutoEntities.ToList();
        }

        public ProdutoEntity GetById(int id)
        {
            return _context.ProdutoEntities.SingleOrDefault(x => x.Id == id);
        }

        public void Update(ProdutoEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
