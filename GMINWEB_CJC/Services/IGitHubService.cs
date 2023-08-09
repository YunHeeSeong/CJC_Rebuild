using GMINWEB_Rebuild.Model.Github;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GMINWEB_Rebuild.Services
{
    public interface IGitHubService
    {
        Task<IEnumerable<Issue>> GetIssues(DateTime date);
    }
}