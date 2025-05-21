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
            /* Chama o método ObterUsuario do _usuarioRepositorio, passando o email fornecido pelo usuário.
            Isso buscará um usuário no banco de dados com o email correspondente.*/
            var usuario = _usuarioRepositorio.ObterUsuario(email);
            // Verifica se um usuário foi encontrado for diferente de vazio e se a senha fornecida corresponde à senha do usuário encontrado.
            if (usuario != null && usuario.Senha == senha)
            {
                // Autenticação bem-sucedida
                // Redireciona o usuário para a action "Index" do Controller "Cliente".
                return RedirectToAction("Index", "Cliente");
            }
            /* Se a autenticação falhar (usuário não encontrado ou senha incorreta):
             Adiciona um erro ao ModelState. ModelState armazena o estado do modelo e erros de validação.
             O primeiro argumento ("") indica um erro
             O segundo argumento é a mensagem de erro que será exibida ao usuário.*/

            ModelState.AddModelError("", "Email ou senha inválidos.");
            //retorna view Login 
            return View();
        }

        public IActionResult Contato() 
        {
            return View();
        }
    }
    

}
