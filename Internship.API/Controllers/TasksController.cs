using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Internship.Business.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Internship.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskBusiness _business;
        public TasksController(ITaskBusiness business)
        {
            _business = business;
        }
        //comment
        [HttpGet]
        public async Task<IEnumerable<Intenship.Domain.Models.Task>> Get()
        {

            return await _business.GetTasks();

        }

        [HttpPost]
        public async Task<IEnumerable<Intenship.Domain.Models.Task>> CreateTask([FromBody] Intenship.Domain.Models.Task task)
        {
            var tasks = await _business.CreateTask(task);
            return tasks;

        }

        [HttpDelete("{id}")]
        public async Task<IEnumerable<Intenship.Domain.Models.Task>> DeleteTask(int id)
        {
            return await _business.DeleteTask(id);
        }
        [HttpPut]
        public async Task<IEnumerable<Intenship.Domain.Models.Task>> UpdateTask(Intenship.Domain.Models.Task request)
        {
            return await _business.UpdateTask(request); ;
        }
    }
}