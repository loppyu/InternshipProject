using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Internship.Business.BusinessRepositories
{
    public interface IProjectBusiness
    {
        Task<IEnumerable<Intenship.Domain.Models.Project>> GetProjects();
        Task<IEnumerable<Intenship.Domain.Models.Project>> DeleteProject(int id);
        Task<IEnumerable<Intenship.Domain.Models.Project>> CreateProject(Intenship.Domain.Models.Project project);
        Task<IEnumerable<Intenship.Domain.Models.Project>> UpdateProject(Intenship.Domain.Models.Project request);
    }
}
