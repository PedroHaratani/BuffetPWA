using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuffetLista1.Models.Acesso;
using BuffetLista1.RequestModels;
using BuffetLista1.Views.Acesso;
using Microsoft.AspNetCore.Mvc;

namespace BuffetLista1.Controllers
{
    public class AcessoController : Controller
    {
        private readonly AcessoService _acessoService;
        [HttpGet]
        public IActionResult Login()
        {
            var viewModel = new CadastrarViewModel();

            viewModel.Mensagem = (string)TempData["msg-login"];

            return View(viewModel);
        }
        [HttpPost]
        public async Task<RedirectToActionResult> Login(LoginRequestModel login)
        {
            var email = login.Email;
            var senha = login.Senha;

            if(email==null || senha == null) 
            {
                TempData["msg-login"] = "Insira email ou senha";

                return RedirectToAction("Login");
            }
            try
            {
                await _acessoService.Logar(email, senha);
                return RedirectToAction("Painel");
            }
            catch(Exception exception) 
            {
                exception.ToString();
                return RedirectToAction("Cadastrar");
            }
            
        }
        [HttpGet]
        public IActionResult Cadastro() 
        {
            var viewModel = new CadastrarViewModel();

            viewModel.Mensagem = (string) TempData["msg-cadastro"];
            viewModel.ErrosCadastro = (string[])TempData["erros-cadastro"];

            return View(viewModel);
        }
        [HttpPost]
        public async Task<RedirectToActionResult> CadastrarAsync(AcessoCadastrarRequestModel request)
        {
            var email = request.Email;
            var senha = request.Senha;

            if (email == null)
            {
                TempData["msg-cadastro"] = "Por favor informe o email";
                return RedirectToAction("Cadastrar");
            }
            try
            {
                await _acessoService.RegistrarUsuario(email, senha);
                TempData["msg-cadastro"] = "Cadastro Realizado com sucesso";
                return RedirectToAction("Login");
            }
            catch (CadastrarUsuarioException exception)
            {
                var listaErros = new List<string>();
                foreach(var identityError in exception.Erros) 
                {
                    listaErros.Add(identityError.Description);
                }
                TempData["erros-cadastro"] = listaErros;
                return RedirectToAction("Cadastrar");
            }

            
        }
        public IActionResult RecuperarConta()
        {
            return View();
        }
    }
}
