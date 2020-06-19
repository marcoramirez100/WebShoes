using BusinessEntities;
using BusinessEntities.Models;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class BLLArticle
    {
        static DALArticle dal = new DALArticle();

        public static string getArticles()
        {
            GenerateResponse gen = new GenerateResponse();

            List<BEArticle> lista = dal.getArticles();

            string res = gen.ResponseSuccess(lista);

            return res;
        }

        public static string getArticleByStoreId(string idStoreCad)
        {
            string res = string.Empty;
            short storeId = 0;
            List<BEArticle> lista = null;
            GenerateResponse gen = new GenerateResponse();

            if (short.TryParse(idStoreCad, out storeId))
            {
                lista = dal.getArticleByStoreId(storeId);
                if (lista == null)
                {
                    res = gen.ResponseError(404, "Record not Found");
                }
                else
                {
                    res = gen.ResponseSuccess<BEArticle>(lista);
                }
            }
            else
            {
                res = gen.ResponseError(400, "Bad Request");
            }

            return res;
        }

        public static string addArticle(BEArticle art)
        {
            string res = string.Empty;
            GenerateResponse gen = new GenerateResponse();

            try
            {
                bool exito = dal.addArticle(art);
                res = gen.ResponseSuccess();
            }
            catch (Exception ex)
            {
                res = gen.ResponseError(404, ex.Message);

            }

            return res;
        }
    }
}
