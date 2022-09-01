using System.Linq;
using Microsoft.AspNetCore.Mvc;
using USANDOVIEWS.Models;

namespace USANDOVIEWS.Controllers{

    public class HomeController : Controller{

        public IActionResult Index(){
            return View();
        }
        
        [HttpGet]
         public IActionResult Cadastrar(int? id)
         {
            if(id.HasValue && Usuario.Listagem.Any(u => u.Id == id ))
            {
                var usuario = Usuario.Listagem.Single(u => u.Id == id);
                return View(usuario);
            }
            return View();
         }

         [HttpPost]
         public IActionResult Cadastrar(Usuario usuario)
         {
            Usuario.Salvar(usuario);
            return RedirectToAction("Usuarios");
         }


          public IActionResult Usuarios(){
            return View(Usuario.Listagem);
        }


        [HttpGet]
         public IActionResult Excluir(int? id)
         {
            if(id.HasValue && Usuario.Listagem.Any(u => u.Id == id ))
            {
                var usuario = Usuario.Listagem.Single(u => u.Id == id);
                return View(usuario);
            }
            return RedirectToAction("usuarios");
         }


         [HttpPost]
         public IActionResult Excluir(Usuario usuario){
            Usuario.Excluir(usuario.Id);
            return RedirectToAction("usuarios");
         }

    }
}