using BuffetLista1.Models.Buffet.Evento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuffetLista1.Models.Buffet.Cliente
{
    public class ClienteEntity
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Endereco{ get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataModificacao { get; set; }
        public  Guid TipoCliente { get; set; }
        public string Cpf { get; set; }
        public  DateTime DataNascimento { get; set; }
        public string CNPJ { get; set; }

        public ICollection<EventoEntity> Eventos { get; set; }

        public ClienteEntity()
        {
            Id = new Guid();
            Eventos = new List<EventoEntity>();
        }

        public ClienteEntity(Guid id, string nome, string email, string endereco, DateTime dataCadastro, DateTime dataModificacao, Guid tipoCliente, string cpf, DateTime dataNascimento, string cNPJ, ICollection<EventoEntity> eventos)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Endereco = endereco;
            this.dataCadastro = dataCadastro;
            this.dataModificacao = dataModificacao;
            TipoCliente = tipoCliente;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            CNPJ = cNPJ;
            Eventos = eventos;
        }
    }
}
