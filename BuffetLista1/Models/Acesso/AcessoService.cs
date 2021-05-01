using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuffetLista1.Models.Acesso
{
    public class AcessoService
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _signInManager;

        public AcessoService(UserManager<Usuario> userManager, SignInManager<Usuario> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task Logar(string email,string senha) 
        {
            var resultado = await _signInManager.PasswordSignInAsync(email,senha,false,false);
            if (!resultado.Succeeded)
            {

                throw new Exception("Usuario ou senha inválidos");
            }
        }
        public async Task RegistrarUsuario(string email, string senha)
        {
            var novoUsuario = new Usuario()
            {
                UserName = email,
                Email=email
            };

            var resultado = await _userManager.CreateAsync(novoUsuario, senha);
            
            
            if (!resultado.Succeeded) 
            {
                
                throw new CadastrarUsuarioException(resultado.Errors);
            }
            
        }
    }
}
