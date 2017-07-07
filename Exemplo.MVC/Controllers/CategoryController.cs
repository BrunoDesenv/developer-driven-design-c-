using Exemplo.Domain.Entities;
using Exemplo.Domain.Interfaces.Services;
using System;
using System.Web.Mvc;

namespace Exemplo.MVC.Controllers
{
    public class CategoryController : BaseController
    {

        private ICategoryService _categoryService;
        private ILogService _logService;

        public CategoryController(ICategoryService categoryService, ILogService logService) : base(logService)
        {
            _categoryService = categoryService;
            _logService = logService;
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Register(Category category)
        {
            try
            {
                _categoryService.Add(category);

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