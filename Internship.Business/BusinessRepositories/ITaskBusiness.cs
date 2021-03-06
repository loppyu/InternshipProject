using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Internship.Business.Repositories
{
    public interface ITaskBusiness
    {

        Task<IEnumerable<Intenship.Domain.Models.Task>> GetTasks();
        Task<IEnumerable<Intenship.Domain.Models.Task>> CreateTask(Intenship.Domain.Models.Task task);
        Task<IEnumerable<Intenship.Domain.Models.Task>> DeleteTask(int id);
        Task<IEnumerable<Intenship.Domain.Models.Task>> UpdateTask(Intenship.Domain.Models.Task request);


    }
}
