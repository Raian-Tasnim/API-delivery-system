using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DonationManageProject.Controllers
{
    public class DonationController : ApiController
    {
        [HttpGet]
        [Route("api/donations")]
        public HttpResponseMessage Donations()
        {
            try
            {
                var data = DonerService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/campaigns")]
        public HttpResponseMessage Campaigns()
        {
            try
            {
                var data = CampaignService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/donationlist")]
        public HttpResponseMessage DonationList()
        {
            try
            {
                var data = DonationService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}
