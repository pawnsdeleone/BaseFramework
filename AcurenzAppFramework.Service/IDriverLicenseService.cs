using AcurenzAppFramework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcurenzAppFramework.Service
{
    public interface IDriverLicenseService : IDisposable
    {
        LicenseType Create(LicenseType licensetype);
        void Delete(string id);
        LicenseType GetLicenseType(string licensetypeid);
        IEnumerable<LicenseType> GetPagedList(int pageNumber, int pageSize, out int totalRecords);
        IEnumerable<LicenseType> GetAll();
        Task<IEnumerable<LicenseType>> GetAllAsync();
        void Update(LicenseType licensetype);
        LicenseType Add(LicenseType licensetype);
    }
}
