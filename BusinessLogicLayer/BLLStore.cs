using BusinessEntities.ViewModel;
using DataAccessLayer;
using System;
using System.Collections.Generic;

namespace BusinessLogicLayer
{
    public class BLLStore
    {
        static DALStore dal = new DALStore();

        public static string getStores()
        {
            DALStore dal = new DALStore();
            string res = string.Empty;
            GenerateResponse gen = new GenerateResponse();

            List<BEStore> lista = dal.getStores();
            res = gen.ResponseSuccess<BEStore>(lista);

            return res;
        }
    }
}
