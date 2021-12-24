using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Intenship.Domain.Interfaces
{
    public interface ITaskRepository
    {
        Task<IEnumerable<Models.Task>> GetTasks();
        Task<IEnumerable<Intenship.Domain.Models.Task>> CreateTask(Intenship.Domain.Models.Task task);
        Task<IEnumerable<Intenship.Domain.Models.Task>> DeleteTask(int id);
        Task<IEnumerable<Intenship.Domain.Models.Task>> UpdateTask(Intenship.Domain.Models.Task request);

    }
}
