using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductApi.Controllers
{
    public class ProductsController : ApiController
    {
        BLL[] projects = new BLL[]
            {
            new BLL { Id = 1,ProjectName = "WebAPI"},
            new BLL { Id = 2,ProjectName = "ARCOM"},
            new BLL { Id = 3, ProjectName = "Web" }
        };
        public IEnumerable<BLL> GetAllProject()
        {
            return projects;
        }
        public IHttpActionResult GetProject(int id)
        {
            var project = projects.FirstOrDefault((p) => p.Id == id);
            if (project == null)
            {
                return NotFound();
            }
            return Ok(project);
        }
    }
}
