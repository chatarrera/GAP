using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ShoesStoreWebApi.Models;

namespace ShoesStoreWebApi.Controllers
{
    public class ArticleController : ApiController
    {
        private ShoesStoreEntities db = new ShoesStoreEntities();

        //Constructor para desabilitar el Proxy
        public ArticleController()
        {
            db.Configuration.ProxyCreationEnabled = false;
        }
        
        // GET api/Article
        public IQueryable<Article> GetArticle()
        {
            return db.Article;
        }

        // GET api/Article/5
        [ResponseType(typeof(Article))]
        public IHttpActionResult GetArticle(int id)
        {
            Article article = db.Article.Find(id);
            if (article == null)
            {
                return NotFound();
            }

            return Ok(article);
        }

        // PUT api/Article/5
        public IHttpActionResult PutArticle(int id, Article article)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != article.ArticleID)
            {
                return BadRequest();
            }

            db.Entry(article).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArticleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST api/Article
        [ResponseType(typeof(Article))]
        public IHttpActionResult PostArticle(Article article)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Article.Add(article);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = article.ArticleID }, article);
        }

        // DELETE api/Article/5
        [ResponseType(typeof(Article))]
        public IHttpActionResult DeleteArticle(int id)
        {
            Article article = db.Article.Find(id);
            if (article == null)
            {
                return NotFound();
            }

            db.Article.Remove(article);
            db.SaveChanges();

            return Ok(article);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ArticleExists(int id)
        {
            return db.Article.Count(e => e.ArticleID == id) > 0;
        }
    }
}