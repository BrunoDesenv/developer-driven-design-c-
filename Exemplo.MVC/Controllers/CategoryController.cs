using Exemplo.Domain.Entities;
using System;
using System.Web.Mvc;

namespace Exemplo.MVC.Controllers
{
    public class CategoryController : Controller
    {  

        [HttpPost]
        public JsonResult Register(Category category)
        {
            try
            {
                _produtoService.Add(product);

                return RedirectToAction("Detalhes", "Produto", new { produtoId = comentario.ProdutoId });
            }
            catch (Exception erro)
            {
                SaveLog(erro);
                return Json(new { StatusCode = 500, Erro = erro }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}