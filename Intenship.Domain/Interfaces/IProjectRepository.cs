using System.Collections.Generic;
using System.Threading.Tasks;

namespace Intenship.Domain.Interfaces
{
    public interface IProjectRepository
    {
        Task<IEnumerable<Models.Project>> GetProjects();
        Task<IEnumerable<Intenship.Domain.Models.Project>> DeleteProject(int id);
        Task<IEnumerable<Intenship.Domain.Models.Project>> CreateProject(Intenship.Domain.Models.Project project);
        Task<IEnumerable<Intenship.Domain.Models.Project>> UpdateProject(Intenship.Domain.Models.Project request);

    }
}
