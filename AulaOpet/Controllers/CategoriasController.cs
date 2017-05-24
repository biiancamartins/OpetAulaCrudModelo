using Bianca162a.Models;
using Bianca162a.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bianca162a.Controllers
{
    public class CategoriesController : Controller
    {

        private static IList<Categorie> categorieList = new List<Categorie>()
        {
            new Categorie() { Id = 1, Nome = "Teste 1" },
            new Categorie() { Id = 2, Nome = "Teste 2" },
            new Categorie() { Id = 3, Nome = "Teste 3" },
            new Categorie() { Id = 4, Nome = "Teste 4" },
            new Categorie() { Id = 5, Nome = "Teste 5" }
        };
        // GET: Categories
        public ActionResult Index()
        {
            return View(categorieList);
        }

        public ActionResult Edit(int id)
        {
            Categorie categorie = categorieList.Where(c => c.Id == id).First();
            return View(categorie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Categorie cat)
        {
            Categorie categorie = categorieList.Where(c => c.Id == cat.Id).First();
            categorie.Nome = cat.Nome;
            return RedirectToAction("Index");
        }

        public ActionResult Delete(Categorie cat, int id)
        {
            Categorie categorie = categorieList.Where(c => c.Id == cat.Id).First();
            //categorieList.Remove(cat.Id);
            categorieList.RemoveAt(id);
            return RedirectToAction("Index");
        }


    }
}