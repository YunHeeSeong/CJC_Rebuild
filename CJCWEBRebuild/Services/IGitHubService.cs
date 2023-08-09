using GMINWEB_CJC.Model.Github;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GMINWEB_CJC.Services
{
    public interface IGitHubService
    {
        Task<IEnumerable<Issue>> GetIssues(DateTime date);
    }
}