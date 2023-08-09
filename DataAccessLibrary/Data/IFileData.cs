using DataAccessLibrary.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public interface IFileData
    {
        Task<List<FileModel>> GetFile(string loginId, DateTime startDt, DateTime endDt, int selectedFileCls);
        Task InsertData(FileModel file, string loginId);
        Task UpdateData(FileModel file, string loginId);
        Task DeleteData(FileModel file, string loginId);
    }
}