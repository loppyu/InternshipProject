using Intenship.Domain.Interfaces;
using Intenship.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Internship.Business.BusinessRepositories
{
    public class ProjectBusiness : IProjectBusiness
    {
        private readonly IProjectRepository _projectRepository;
        public ProjectBusiness(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<IEnumerable<Project>> CreateProject(Project project)
        {
            return await _projectRepository.CreateProject(project);
        }

        public async Task<IEnumerable<Project>> DeleteProject(int id)
        {
            return await _projectRepository.DeleteProject(id);
        }

        public async Task<IEnumerable<Intenship.Domain.Models.Project>> GetProjects()
        {
            var projects = await _projectRepository.GetProjects();
            return projects; 
        }
       
        public async Task<IEnumerable<Project>> UpdateProject(Project request)
        {
            return await _projectRepository.UpdateProject(request);
        }
    }
}
