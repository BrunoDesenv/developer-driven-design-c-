using Exemplo.Domain.Entities;
using Exemplo.Domain.Interfaces.Services;
using System;
using System.Web.Mvc;

namespace Exemplo.MVC.Controllers
{
    public class ProductController : BaseController
    {
        private IProductService _produtoService;
        private ILogService _logService;


        public ProductController(IProductService productService, ILogService logService) : base(logService)
        {
            _produtoService = productService;
            _logService = logService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        public JsonResult Register(Product product)
        {
            try
            {
                _produtoService.Add(product);

                return Json(new { StatusCode = 200 }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception erro)
            {
                SaveLog(erro);
                return Json(new { StatusCode = 500, Erro = erro }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}