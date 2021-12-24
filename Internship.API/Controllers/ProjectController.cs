using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Internship.Business.BusinessRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Internship.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectBusiness _business;
        public ProjectController(IProjectBusiness business)
        {
            _business = business;
        }
        [HttpGet]
        
        public async Task<IEnumerable<Intenship.Domain.Models.Project>> Get()
        {
            return await _business.GetProjects();
        }
        [HttpDelete("{id}")]
        public async Task<IEnumerable<Intenship.Domain.Models.Project>> Delete(int id)
        {
            return await _business.DeleteProject(id);
        }
        [HttpPut]
        public async Task<IEnumerable<Intenship.Domain.Models.Project>> UpdateProject(Intenship.Domain.Models.Project request)
        {
            return await _business.UpdateProject(request); ;
        }
        [HttpPost]
        public async Task<IEnumerable<Intenship.Domain.Models.Project>> CreateProject([FromBody] Intenship.Domain.Models.Project project)
        {
            var projects= await _business.CreateProject(project);
            return projects;

        }
    }
}