using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuffetLista1.Models.Buffet.Evento
{
    public class Local
    {
        public Local()
        {
        }

        public Local(string descricao, string endereco)
        {
            Descricao = descricao;
            Endereco = endereco;
        }

        public string Descricao { get; set; }
        public string Endereco { get; set; }
    }
}
