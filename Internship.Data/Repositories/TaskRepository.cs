using Intenship.Domain.Interfaces;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;

namespace Internship.Data.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly DataContext _context;
        public TaskRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Intenship.Domain.Models.Task>> CreateTask(Intenship.Domain.Models.Task task)
        {
            var numberOfTasks = _context.Tasks.CountAsync();
            task.Id = numberOfTasks.Id + 1; 
           _context.Tasks.Add(task);
            return  _context.Tasks;
        }

        public async Task<IEnumerable<Intenship.Domain.Models.Task>> DeleteTask(int id)
        {
            var task = _context.Tasks.Find(t => t.Id == id);
            _context.Tasks.Remove(task);
            return await _context.Tasks.ToListAsync();
        }

        public async Task<IEnumerable<Intenship.Domain.Models.Task>> GetTasks() =>
            await _context.Tasks.ToListAsync();

        public async Task<IEnumerable<Intenship.Domain.Models.Task>> UpdateTask(Intenship.Domain.Models.Task request)
        {
            var task= _context.Tasks.Find(t => t.Id == request.Id);
            task.Name = request.Name;
            task.Priority = request.Priority;
            task.Status = request.Status;
            return _context.Tasks;
        }
    }
}
