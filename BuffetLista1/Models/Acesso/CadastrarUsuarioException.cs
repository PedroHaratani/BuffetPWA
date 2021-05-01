using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuffetLista1.Models.Acesso
{
    public class CadastrarUsuarioException :Exception
    {
        public IEnumerable<IdentityError> Erros { get; set; }

        public CadastrarUsuarioException(IEnumerable<IdentityError> erros)
        {
            Erros = erros;
        }
    }
}
