using BusinessEntities;
using BusinessEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppShoes.WebApiConsumer.Article
{
    public interface IArticleApiConsumer
    {
        BERespuesta GetArticles(short? idStore);
        BERespuesta AddArticle(string name, string description, decimal price, int totalInShelf, int totalInVault,
            short storeId);
    }
}
