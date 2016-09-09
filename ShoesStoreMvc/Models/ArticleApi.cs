using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;

namespace ShoesStoreMvc.Models
{
    public class ArticleApi
    {
        private string API_URL = "http://localhost:52651/api/";

        public IEnumerable<ArticleDTO> ListAll()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(API_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("article").Result;

                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsAsync<IEnumerable<ArticleDTO>>().Result;
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ArticleDTO ListArticle(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(API_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("article/"+ id).Result;

                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsAsync<ArticleDTO>().Result;
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Create(ArticleDTO article)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(API_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PostAsJsonAsync("article", article).Result;

                return response.IsSuccessStatusCode;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(API_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.DeleteAsync("article/" + id).Result;

                return response.IsSuccessStatusCode;

            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public bool Edit(ArticleDTO article)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(API_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PutAsJsonAsync("article/" + article.ArticleID, article).Result;

                return response.IsSuccessStatusCode;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}