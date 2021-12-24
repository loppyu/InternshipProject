using Intenship.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Internship.Business.Repositories
{
    public class TaskBusiness : ITaskBusiness
    {
        private readonly ITaskRepository _repository;

        public TaskBusiness(ITaskRepository repository)
        {
            _repository = repository;
        }



        public async Task<IEnumerable<Intenship.Domain.Models.Task>> CreateTask(Intenship.Domain.Models.Task task)
        {
            return await _repository.CreateTask(task);
        }

        public async Task<IEnumerable<Intenship.Domain.Models.Task>> DeleteTask(int id)
        {
            return await _repository.DeleteTask(id);
        }

        public async Task<IEnumerable<Intenship.Domain.Models.Task>> GetTasks()
        {
            //prepakovati tasks sa DTO
            var tasks = await _repository.GetTasks();
            return tasks ;
        }

        public async Task<IEnumerable<Intenship.Domain.Models.Task>> UpdateTask(Intenship.Domain.Models.Task request)
        {
            return await _repository.UpdateTask(request); ;
        }


    }
}
