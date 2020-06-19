using BusinessEntities.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class GenerateResponse
    {
        public string ResponseError(int errorCode, string errorMessage)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{'error_msg':'{0}','error_code':{1},'success':false}", errorMessage, errorCode);

            return sb.ToString();
        }

        public string ResponseSuccess()
        {
            StringBuilder sb = new StringBuilder("{'error_msg':'','error_code':0,'success':true}");

            return sb.ToString();
        }

        public string ResponseSuccess<T>(T item)
        {
            return ResponseSuccess<T>(new List<T> { item }, true);
        }

        public string ResponseSuccess<T>(List<T> items)
        {
            return ResponseSuccess<T>(items, false);
        }

        private string ResponseSuccess<T>(List<T> items, bool one)
        {
            StringBuilder sb;

            Type tipo = items.GetType();
            string nameItem = one == true ? "'store':" : "'stores':";
            if (tipo.FullName.ToLower().Contains("article"))
                nameItem = one == true ? "'article':" : "'articles':";

            StringBuilder itemsCad = new StringBuilder(JsonConvert.SerializeObject(items));

            sb = new StringBuilder("{" + nameItem + itemsCad.ToString() + "," +
                $"'success':true,'total_elements':{(items != null ? items.Count : 0)}" + "}");

            string respuesta = sb.ToString();

            return sb.ToString();
        }
    }
}
