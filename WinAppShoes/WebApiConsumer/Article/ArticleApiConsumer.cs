using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using BusinessEntities;
using BusinessEntities.Models;
using Newtonsoft.Json;

namespace WinAppShoes.WebApiConsumer.Article
{
    public class ArticleApiConsumer : IArticleApiConsumer
    {
        public string baseApi;
        public string ApiControllerUrl;

        public ArticleApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/services/articles";
        }

        public BERespuesta AddArticle(string name, string description, decimal price, int totalInShelf, int totalInVault,
            short storeId)
        {
            BEArticle nuevo = new BEArticle
            {
                id = 0,
                name = name,
                description = description,
                price = price,
                store_id = storeId,
                total_in_shelf = totalInShelf,
                total_in_vault = totalInVault,
            };

            string returnMessage = string.Empty;
            BERespuesta res = new BERespuesta();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.BaseAddress = new Uri(baseApi);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string inputJson = JsonConvert.SerializeObject(nuevo);
                HttpResponseMessage response = client.PostAsync("/services/articles/add", new StringContent(inputJson,
                    Encoding.UTF8, "application/json")).Result;

                string jsonResult = response.Content.ReadAsStringAsync().Result;
                object objeto = JsonConvert.DeserializeObject(jsonResult);
                res = JsonConvert.DeserializeObject<BERespuesta>(objeto.ToString());
            }

            return res;
        }

        public BERespuesta GetArticles(short? idStore)
        {
            string returnMessage = string.Empty;
            BERespuesta res = new BERespuesta();

            string cadena = string.Empty;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.BaseAddress = new Uri(baseApi);

                string idParameter = string.Empty;
                if (idStore.HasValue)
                    idParameter = "/stores/" + idStore.Value.ToString();

                HttpResponseMessage response = client.GetAsync(ApiControllerUrl + idParameter).Result;
                string jsonResult = response.Content.ReadAsStringAsync().Result;
                var objeto = JsonConvert.DeserializeObject(jsonResult);
                if (objeto != null && !string.IsNullOrEmpty(objeto.ToString()))
                    res = JsonConvert.DeserializeObject<BERespuesta>(objeto.ToString());
            }

            return res;
        }
    }
}
