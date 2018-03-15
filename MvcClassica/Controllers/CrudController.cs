using MvcClassica.Models;
using MvcClassica.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcClassica.Controllers
{
    public class CrudController : Controller
    {
        private const int DEFAULT_PAGE_COUNT = 3;

        private readonly CrudService _servicce;

        public CrudController()
        {
            _servicce = new CrudService();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(PesquisaFormModel model)
        {
            model.PageCount = model.PageCount > 0
                ? model.PageCount
                : DEFAULT_PAGE_COUNT;

            model.Interno.Resultado = _servicce.Pesquisa(model);

            return View(model);
        }
    }
}