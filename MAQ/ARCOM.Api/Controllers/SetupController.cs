using BL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ARCOM.Api.Controllers
{
    public class SetupController : ApiController
    {
        public SetupApi setup = new SetupApi();
        public List<BLL> GetAllSetupDetails()
        {
            return setup.GetAllSetupDetails();
        }
    }
}
