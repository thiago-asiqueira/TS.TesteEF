using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using TS.TesteEF.Data.Context;
using TS.TesteEF.Domain.Contracts.Repositories;
using TS.TesteEF.Domain.Entities;

namespace TS.TesteEF.Data.Repositories
{
    public sealed class IngredienteRepository : IRepositoryIngrediente
    {
        private readonly TesteEFContext _context;

        public IngredienteRepository(TesteEFContext context)
        {
            _context = context;
        }

        public void Add(IngredienteEntity entity)
        {
            _context.IngredienteEntities.Add(entity);
        }

        public void DeleteById(int id)
        {
            var item = GetById(id);
            _context.IngredienteEntities.Remove(item);
        }

        public IEnumerable<IngredienteEntity> GetAll()
        {
            return _context.IngredienteEntities.ToList();
        }

        public IngredienteEntity GetById(int id)
        {
            return _context.IngredienteEntities.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<IngredienteEntity> GetByNome(string nome)
        {
            return _context.IngredienteEntities.Where(x => x.Nome.Contains(nome)).ToList();
        }

        public IEnumerable<IngredienteEntity> GetByProduto(ProdutoEntity produto)
        {
            return _context.IngredienteEntities.Where(x => x.Produtos.Contains(produto)).ToList();
        }

        public void Update(IngredienteEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
