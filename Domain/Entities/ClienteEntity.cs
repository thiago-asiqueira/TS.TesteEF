
using System;
using TS.TesteEF.Domain.Entities.Core;

namespace TS.TesteEF.Domain.Entities
{
    public sealed class ClienteEntity : Entity<int>
    {
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
    }
}
