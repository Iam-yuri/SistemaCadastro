using Microsoft.AspNetCore.Mvc;

namespace SistemaCadastro.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult verificarCPF(string cpf)
        {
            if (cpf == "12345678900")
            {
                return RedirectToAction("BoasVindas", new { nome = "Yuri" });
            }
            else
            {
                return RedirectToAction("PerguntarCadastro", new { cpf });
            }
        }

        public IActionResult BoasVindas(string nome)
        {
            ViewBag.Nome = nome;
            return View();
        }

        public IActionResult PerguntarCadastro(string cpf)
        {
            ViewBag.CPF = cpf;
            return View();
        }

        public IActionResult Formulario(string cpf)
        {
            ViewBag.CPF = cpf;
            return View();
        }

        [HttpPost]
        public IActionResult SalvarCadastro(string cpf, string nome, string email, string empresa, string cargo, string estado, string uf, bool expositor, string cnpj)
        {
            return RedirectToAction("Confirmacao");
        }

        public IActionResult confirmacao()
        {
            return View();
        }
    }
}
