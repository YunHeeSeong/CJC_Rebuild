using DataAccessLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public interface IMenuData
    {
        Task<List<MenuModel>> GetAllMenus();
    }
}