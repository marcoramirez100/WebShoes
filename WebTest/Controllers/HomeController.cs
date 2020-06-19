using BusinessEntities;
using BusinessEntities.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebNegocioMXMVC.Controllers
{
    public class HomeController : Controller
    {
        private static string WebApiUrl = "http://localhost:52530/";

        [HttpGet]
        public async Task<ActionResult> GetArticles()
        {
            string returnMessage = string.Empty;
            BERespuesta res = new BERespuesta();

            string prueba = @"{'stores': [{'id': 1,'address': 'Somewhere over the rainbow','name': 'Super Store'}], 'success': true, 'total_elements': 2}";

            string cadena = string.Empty;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.BaseAddress = new Uri(WebApiUrl);

                HttpResponseMessage response = client.GetAsync("/services/Articles").Result;
                string jsonResult = response.Content.ReadAsStringAsync().Result;
                try
                {
                    var objeto = JsonConvert.DeserializeObject(jsonResult);
                    if (objeto != null && string.IsNullOrEmpty(objeto.ToString()))
                    {
                        res = JsonConvert.DeserializeObject<BERespuesta>(objeto.ToString());
                        if (res.articles != null)
                        {

                        }
                        else if (res.article != null)
                        {

                        }
                        else if (res.stores != null)
                        {

                        }
                        else if (res.store != null)
                        {

                        }
                    }
                }
                catch (Exception ex)
                {
                    cadena = ex.Message;
                }
            }
            return Content(returnMessage);
        }

        [HttpGet]
        public async Task<ActionResult> GetStores()
        {
            string returnMessage = string.Empty;
            BERespuesta res = new BERespuesta();

            string cadena = string.Empty;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.BaseAddress = new Uri(WebApiUrl);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync("/services/stores").Result;
                string jsonResult = response.Content.ReadAsStringAsync().Result;
                try
                {
                    res = JsonConvert.DeserializeObject<BERespuesta>(jsonResult);
                }
                catch (Exception ex)
                {
                    cadena = ex.Message;
                }
            }
            return Content(returnMessage);
        }

        [HttpGet]
        public async Task<ActionResult> GetArticleByStore()
        {
            string returnMessage = string.Empty;
            BERespuesta res = new BERespuesta();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.BaseAddress = new Uri(WebApiUrl);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync("/services/articles/stores/id1").Result;
                string jsonResult = response.Content.ReadAsStringAsync().Result;
                try
                {
                    res = JsonConvert.DeserializeObject<BERespuesta>(jsonResult);
                }
                catch
                {
                }
            }
            return Content(returnMessage);
        }
    }
}