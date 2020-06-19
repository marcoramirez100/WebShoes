using BusinessEntities;
using BusinessEntities.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALStore
    {
        public List<BEStore> getStores()
        {
            List<BEStore> lista = null;
            bdshoesEntities dc;

            using (dc = new bdshoesEntities())
            {
                lista = dc.stores.Select(a => new BEStore
                {
                    id = a.id,
                    name = a.name,
                    address = a.address,
                }).OrderBy(b => b.name).ToList();
            }

            return lista;
        }
    }
}
