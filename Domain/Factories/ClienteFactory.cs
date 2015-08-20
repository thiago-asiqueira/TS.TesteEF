using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.TesteEF.Domain.Entities;

namespace TS.TesteEF.Domain.Factories
{
    public static class ClienteFactory
    {
        public static ClienteEntity Create(string nome, DateTime dataNascimento)
        {
            return new ClienteEntity(nome, dataNascimento);
        }
    }
}
