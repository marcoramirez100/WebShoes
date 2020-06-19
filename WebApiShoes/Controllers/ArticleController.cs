using BusinessEntities;
using BusinessEntities.Models;
using BusinessLogicLayer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiShoes.Controllers
{
    public class ArticleController : ApiController
    {
        [HttpGet]
        [Route("services/articles")]
        public string Index()
        {
            string res = string.Empty;

            res = BLLArticle.getArticles();

            return res;
        }

        [HttpGet]
        public string GetArticles()
        {
            string res = string.Empty;

            res = BLLArticle.getArticles();

            return res;
        }

        [HttpGet]
        [Route("services/articles/stores/{storeId}")]
        public string GetArticle(string storeId)
        {
            string res = string.Empty;

            res = BLLArticle.getArticleByStoreId(storeId);

            return res;
        }

        [HttpPost]
        [Route("services/articles/add")]
        public string AddArticle(BEArticle art)
        {
            string res = string.Empty;

            res = BLLArticle.addArticle(art);
            return res;
        }
    }
}
