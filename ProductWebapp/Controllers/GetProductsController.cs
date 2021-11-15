using BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebPRODUCTAPP.Controllers
{
    public class GetProductsController : ApiController
    {
        public HttpResponseMessage GetAllProducts()
        {
            try
            {
                HWBL blobj = new HWBL();
                var pro = blobj.GetAllProducts();

                if (pro != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, pro);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NoContent, "no data found");
                }

            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}