using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuffetLista1.Models.Buffet.Evento
{
    public class SituacaoConvidado
    {
        public SituacaoConvidado()
        {
        }

        public SituacaoConvidado(int id, string descricao)
        {
            this.id = id;
            this.descricao = descricao;
        }

        public int id { get; set; }
        public string descricao { get; set; }

    }
}
