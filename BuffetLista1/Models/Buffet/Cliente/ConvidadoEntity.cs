using BuffetLista1.Models.Buffet.Evento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuffetLista1.Models.Buffet.Cliente
{
    public class ConvidadoEntity
    {
        public ConvidadoEntity()
        {
        }

        public ConvidadoEntity(string nome, string email, string cpf, DateTime dataNascimento, EventoEntity evento, SituacaoConvidado situacao, string observacoes, DateTime dataCadastro, DateTime dataModificacao)
        {
            Nome = nome;
            Email = email;
            Cpf = cpf;
            this.dataNascimento = dataNascimento;
            this.evento = evento;
            this.situacao = situacao;
            this.observacoes = observacoes;
            this.dataCadastro = dataCadastro;
            this.dataModificacao = dataModificacao;
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime dataNascimento { get; set; }
        public EventoEntity evento { get; set; }
        public SituacaoConvidado situacao {get;set;}
        public string observacoes { get; set; }

        public DateTime dataCadastro { get; set; }
        public DateTime dataModificacao { get; set; }


    }
}
