using System.Web.Mvc;
using AutoMapper;
using PatternViewModel.Models;
using PatternViewModel.ViewModels;

namespace PatternViewModel.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /autenticacao.html

        public ActionResult Autenticacao()
        {
            return View();
        }

        //
        // POST: /autenticacao.html

        [HttpPost]
        public ActionResult Autenticacao(AutenticacaoViewModel autenticacaoVM)
        {
            if (ModelState.IsValid)
            {
                var usuario = Mapper.Map<Usuario>(autenticacaoVM);
            }

            return View();
        }

        //
        // GET: /alterar-senha.html

        [ActionName("alterar-senha")]
        public ActionResult AlterarSenha()
        {
            return View();
        }

        //
        // POST: /alterar-senha.html

        [HttpPost]
        [ActionName("alterar-senha")]
        public ActionResult AlterarSenha(AlteracaoSenhaViewModel alterecaoSenhaVM)
        {
            if (ModelState.IsValid)
            {
                var usuario = Mapper.Map<Usuario>(alterecaoSenhaVM);
            }

            return View();
        }
	}
}