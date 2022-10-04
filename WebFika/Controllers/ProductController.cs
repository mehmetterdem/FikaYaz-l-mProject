using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFika.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }
       
        [HttpGet]
        public IActionResult GetList()
        {
            var result =_productService.GetAll();
            return View(result);
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            _productService.Add(product);
            return View();

        }
        
        [HttpGet]
        public IActionResult Form(int id)
        {
            var Jsonresult =_productService.GetAll(x => x.Id == id);
            return PartialView(Jsonresult);
        }

        public JsonResult Kaydet(Product urun)
        {
            //kaydetmeyi yukardakı add methodu  ile yaptım.
            return Json("");
        }
    }
}

