using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BAL
{
    public class HWBL
    {
        public List<ProductDTO> GetAllProducts()
        {
            try
            {
                HWDAL dalObj = new HWDAL();
                List<ProductDTO> results = dalObj.FetchAllProducts();
                return results;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
