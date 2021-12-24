using Intenship.Domain.Interfaces;
using Intenship.Domain.Models;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace Internship.Data.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly DataContext _context;
        public ProjectRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Project>> CreateProject(Project project)
        {
            var numberOfProjects = _context.Projects.CountAsync();
            project.id = numberOfProjects.Id + 1;
            _context.Projects.Add(project);
            return _context.Projects; 
        }

        public async Task<IEnumerable<Project>> DeleteProject(int id)
        {
            var project = _context.Projects.Find(p=>p.Id==id);
            _context.Projects.Remove(project);
            return await _context.Projects.ToListAsync();
        }

        public async Task<IEnumerable<Intenship.Domain.Models.Project>> GetProjects() => await _context.Projects.ToListAsync();

        public async Task<IEnumerable<Project>> UpdateProject(Project request)
        {
            var project = _context.Projects.Find(p => p.Id == request.Id);
            project.StartDate = request.StartDate;
            project.CompletionDate = request.CompletionDate;
            project.CurrentStatus = request.CurrentStatus;
            project.Priority = request.Priority;
            project.TaskId = request.TaskId;
            return _context.Projects ;
        }
    }
}
