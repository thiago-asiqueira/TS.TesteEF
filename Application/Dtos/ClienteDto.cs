using Application.Dtos.Core;
using System;

namespace Application.Dtos
{
    public class ClienteDto : CoreDto
    {
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
    }
}
