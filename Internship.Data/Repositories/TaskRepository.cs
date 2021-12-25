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
            _context.Tasks.Add(task);

            var result = await _context.SaveChangesAsync() > 0;
            
            if (!result)
                throw new Exception("Database error saving changes");
            
            return  await _context.Tasks.ToListAsync();
        }

        public async Task<IEnumerable<Intenship.Domain.Models.Task>> DeleteTask(int id)
        {
            var task = await _context.Tasks.FindAsync(id);

            _context.Tasks.Remove(task);

            var result = await _context.SaveChangesAsync() > 0;

            if (!result)
                throw new Exception("Database error saving changes");

            return await _context.Tasks.ToListAsync();
        }

        public async Task<IEnumerable<Intenship.Domain.Models.Task>> GetTasks() =>
            await _context.Tasks.ToListAsync();

        public async Task<IEnumerable<Intenship.Domain.Models.Task>> UpdateTask(Intenship.Domain.Models.Task request)
        {
            var task = await _context.Tasks.FindAsync(request.Id);

            task.Name = request.Name;
            task.Priority = request.Priority;
            task.Status = request.Status;

            var result = await _context.SaveChangesAsync() > 0;

            if (!result)
                throw new Exception("Database error saving changes");

            return await _context.Tasks.ToListAsync();
        }
    }
}
