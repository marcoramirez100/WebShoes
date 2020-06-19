using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;
using Newtonsoft.Json;

namespace WinAppShoes.WebApiConsumer.Store
{
    public class StoreApiConsumer : IStoreApiConsumer
    {
        public string baseApi;
        public string ApiControllerUrl;

        public StoreApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/services/stores";
        }

        public BERespuesta GetStores()
        {
            string returnMessage = string.Empty;
            BERespuesta res = new BERespuesta();

            string cadena = string.Empty;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.BaseAddress = new Uri(baseApi);

                HttpResponseMessage response = client.GetAsync(ApiControllerUrl).Result;
                string jsonResult = response.Content.ReadAsStringAsync().Result;
                try
                {
                    var objeto = JsonConvert.DeserializeObject(jsonResult);
                    if (objeto != null && !string.IsNullOrEmpty(objeto.ToString()))
                        res = JsonConvert.DeserializeObject<BERespuesta>(objeto.ToString());
                }
                catch (Exception ex)
                {
                    cadena = ex.Message;
                }
            }

            return res;
        }
    }
}
