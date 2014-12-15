using AcurenzAppFramework.Data;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcurenzAppFramework.Service
{
    public class DriverLicenseService:IDriverLicenseService
    {
         private readonly IUnitOfWorkForService _unitOfWork;

         public DriverLicenseService(IUnitOfWorkForService unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<LicenseType> GetAll()
         {
             return _unitOfWork.Repository<LicenseType>().Query().Get();
         }
        public async Task<IEnumerable<LicenseType>> GetAllAsync()
        {
            return await _unitOfWork.Repository<LicenseType>().Query().GetAsync();
        }
        public LicenseType GetLicenseType(string licensetypeid)
        {
            return _unitOfWork.Repository<LicenseType>().Find(licensetypeid);
        }

        public LicenseType Create(LicenseType licensetype)
        {
            licensetype.ObjectState = ObjectState.Added;
            _unitOfWork.Repository<LicenseType>().Insert(licensetype);
            return licensetype;
        }

        public void Delete(string id)
        {
            _unitOfWork.Repository<LicenseType>().Delete(id);
        }

        public void Update(LicenseType licensetype)
        {
            licensetype.ObjectState = ObjectState.Modified;
            _unitOfWork.Repository<LicenseType>().Update(licensetype);
        }

        public IEnumerable<LicenseType> GetPagedList(int pageNumber, int pageSize, out int totalRecords)
        {
            var customers = _unitOfWork.Repository<LicenseType>()
                .Query()
                .OrderBy(q => q
                    .OrderBy(c => c.DisplayName)
                    .ThenBy(c => c.LookupName))
                .Filter(q => !string.IsNullOrEmpty(q.DisplayName))
                .GetPage(pageNumber, pageSize, out totalRecords);

            return customers;
        }

        public LicenseType Add(LicenseType licensetype)
        {
            _unitOfWork.Repository<LicenseType>().Insert(licensetype);
            return licensetype;
        }

        public void Dispose()
        {
        }
    }
}
