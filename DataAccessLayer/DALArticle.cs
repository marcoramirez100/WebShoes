using BusinessEntities;
using BusinessEntities.Models;
using BusinessEntities.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALArticle
    {
        private List<BEArticle> getArticlesByStoreId(short? storeId)
        {
            List<BEArticle> lista = new List<BEArticle>();
            bdshoesEntities dc;

            using (dc = new bdshoesEntities())
            {
                lista = dc.articles.Where(b => (storeId == null || b.store_id == storeId)).Select(a => new BEArticle
                {
                    id = a.id,
                    name = a.name,
                    description = a.description,
                    store_id = a.store_id,
                    price = a.price,
                    total_in_shelf = a.total_in_shelf,
                    total_in_vault = a.total_in_vault,
                    store_name = a.stores.name,
                }).OrderBy(a => a.name).ToList();
            }

            return lista;
        }

        public List<BEArticle> getArticles()
        {
            return getArticlesByStoreId(null);
        }

        public List<BEArticle> getArticleByStoreId(short idStore)
        {
            List<BEArticle> lista = getArticlesByStoreId(idStore);

            return lista;
        }

        public bool addArticle(BEArticle art)
        {
            bool res = false;
            bdshoesEntities dc;

            articles nuevo = new articles
            {
                id = art.id,
                name = art.name,
                description = art.description,
                price = art.price,
                store_id = art.store_id,
                total_in_shelf = art.total_in_shelf,
                total_in_vault = art.total_in_vault,
            };

            using (dc = new bdshoesEntities())
            {
                dc.articles.Add(nuevo);
                dc.SaveChanges();

                art.id = nuevo.id;

                res = art.id > 0;
            }

            return res;
        }
    }
}
