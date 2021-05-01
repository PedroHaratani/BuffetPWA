using BuffetLista1.Models.Buffet.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuffetLista1.Models.Buffet.Evento
{
    public class EventoEntity
    {
        public EventoEntity()
        {
        }

        public EventoEntity(Guid id, Guid tipoEvento, string descricao, DateTime dataInicioEvento, DateTime dataFimEvento, ClienteEntity clienteEvento, SituacaoEvento situacaoEvento, Local local, string observacoes, ClienteEntity cliente, DateTime dataInsercao, DateTime dataModificacao)
        {
            Id = id;
            TipoEvento = tipoEvento;
            Descricao = descricao;
            this.dataInicioEvento = dataInicioEvento;
            this.dataFimEvento = dataFimEvento;
            this.clienteEvento = clienteEvento;
            this.situacaoEvento = situacaoEvento;
            this.local = local;
            this.observacoes = observacoes;
            Cliente = cliente;
            this.dataInsercao = dataInsercao;
            this.dataModificacao = dataModificacao;
        }

        public Guid Id { get; set; }
        public Guid TipoEvento { get; set; }
        public string Descricao { get; set; }
        public DateTime dataInicioEvento {get;set;}
        public DateTime dataFimEvento { get; set; }

        public ClienteEntity clienteEvento { get; set; }
        public SituacaoEvento situacaoEvento { get; set; }
        public Local local { get; set; }
        public string observacoes { get; set; }
        public ClienteEntity Cliente { get; set; }
        public  DateTime dataInsercao { get; set; }
        public DateTime dataModificacao { get; set; }

        

    }
}
