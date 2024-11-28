using AppLogin.Libraries.Login;
using AppLogin.Models;
using AppLogin.Repository.Contract;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AppLogin.Controllers
{
    public class HomeController : Controller
    {
        private IClienteRepository _clienteRepository;
        private LoginCliente _loginCLiente;

        public HomeController(IClienteRepository clienteRepository, LoginCliente loginCLiente)
        {
            _clienteRepository = clienteRepository;
            _loginCLiente = loginCLiente;
        }


        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Login([FromForm] Cliente cliente)
        {
            Cliente clienteDB = _clienteRepository.Login(cliente.Email, cliente.Senha);
            if (clienteDB.Email != null && clienteDB.Senha != null)
            {
                _loginCLiente.Login(clienteDB);
                return new RedirectResult(Url.Action(nameof(PainelCliente)));
            }

            else
            {
                ViewData["MSG_E"] = "Usuário não localizado, por favor verifique e-mail e senha digitado";
                return View();
            }
        }

        public IActionResult PainelCliente()
        {
            ViewBag.Nome = _loginCLiente.GetCliente().Nome;
            ViewBag.CPF = _loginCLiente.GetCliente().CPF;
            ViewBag.Email = _loginCLiente.GetCliente().Email;
            //return new ContentResult() { Content = "Este é o painel do CLiente !" };

            return View();

        }

        public IActionResult LogoutCLiente()
        {
            _loginCLiente.Logout();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
