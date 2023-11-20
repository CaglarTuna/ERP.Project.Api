using AutoMapper;
using Core;
using Core.IUnitOfWork;
using DTO;
using Entity;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public class CompanyAdressService : ICompanyAdressService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ICompanyAddressRepository _ICompanyAddressRepository;

        public CompanyAdressService(ICompanyAddressRepository ıCompanyAddressRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _ICompanyAddressRepository = ıCompanyAddressRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public void Add(CompanyAddressDTO entitiy)
        {
            var companyAdressMapper = _mapper.Map<CompanyAddress>(entitiy);
            var adress = _ICompanyAddressRepository.Add(companyAdressMapper);
            _unitOfWork.SaveChanges();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<CompanyAddressDTO> GetAll(int languageId)
        {
            throw new NotImplementedException();
        }

        public List<CompanyAddressDTO> GetBy(int languageId)
        {
            throw new NotImplementedException();
        }

        public CompanyAddressDTO GetById(int id, int languageId)
        {

            throw new NotImplementedException();
        }

        public CompanyAddressDTO getComponyDetail(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(CompanyAddressDTO entitiy)
        {
            var data = _mapper.Map<CompanyAddress>(entitiy);
            var updateVal = _ICompanyAddressRepository.Update(data);
            if (updateVal != null)
            {
                _unitOfWork.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
