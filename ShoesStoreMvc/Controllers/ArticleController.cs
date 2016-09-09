using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoesStoreMvc.Models;


namespace ShoesStoreMvc.Controllers
{
    public class ArticleController : Controller
    {

        public ActionResult Index()
        {
            ArticleApi artiApi = new ArticleApi();
            ViewBag.listArticles = artiApi.ListAll();
            return View();
        }

        
        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }

        
        [HttpPost]
        public ActionResult Create(ArticleDTO arti)
        {
            ArticleApi art = new ArticleApi();
            art.Create(arti);
            return RedirectToAction("Index");
        }


        public ActionResult Delete(int id)
        {
            ArticleApi art = new ArticleApi();
            art.Delete(id);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            
            ArticleApi art = new ArticleApi();
            //ArticleModel objArti = new ArticleModel();

            return View("Edit", art.ListArticle(id));
        }


        [HttpPost]
        public ActionResult Edit(ArticleDTO arti)
        {
            ArticleApi art = new ArticleApi();
            art.Edit(arti);
            return RedirectToAction("Index");
        }
	}
}