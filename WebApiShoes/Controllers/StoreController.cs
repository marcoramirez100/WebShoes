using BusinessEntities;
using BusinessEntities.ViewModel;
using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiShoes.Controllers   
{
    public class StoreController : ApiController
    {
        [HttpGet]
        [Route("services/stores")]
        public string GetStores()
        {
            string res = string.Empty;

            res = BLLStore.getStores();

            return res;
        }
    }
}
