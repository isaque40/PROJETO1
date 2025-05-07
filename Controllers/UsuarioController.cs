using Microsoft.AspNetCore.Mvc;
using PROJETO1.Repositorio;
namespace PROJETO1.Controllers
{
    public class UsuarioController : Controller
    {
        /*DECLARANDO UMA VARIÁVEL PRIVADA SOMENTE PARA LEITURA DO TIPO UsuarioRepositorio
        chamada _usuarioRepositorio*/
        private readonly UsuarioRepositorio _usuarioRepositorio;

        /*DEFININDO O CONSTRUTOR DA CLASSE USUARIOCONTROOLLER QUE VAI RECEBER UMA
         INSTANCIA DE UsuarioRepositorio*/ 

        public UsuarioController(UsuarioRepositorio usuarioRepositorio)//injeção de dependencia 
        {
            _usuarioRepositorio = usuarioRepositorio;

        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            return View();
        }

        public IActionResult Contato() 
        {
            return View();
        }
    }
    

}
