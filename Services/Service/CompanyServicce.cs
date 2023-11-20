using AutoMapper;
using Core;
using Core.IUnitOfWork;
using DTO;
using Entity;
using Services.IServices;
using System.Collections.Generic;
using System.Linq;

namespace Services.Service
{
    public class CompanyService : ICompanyService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ICompaniesRepository _ICompaniesRepository;  //Core Katmanı
        private readonly ICompanyAddressRepository _ICompanyAddressRepository;

        public CompanyService(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            ICompaniesRepository iCompaniesRepository,
            ICompanyAddressRepository iCompanyAddressRepository
            )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _ICompaniesRepository = iCompaniesRepository;
            _ICompanyAddressRepository = iCompanyAddressRepository;
        }

        public void Add(CompanyDTO entitiy)
        {
            var companiesMapper = _mapper.Map<Companies>(entitiy);
            var companyAddressMapper = _mapper.Map<List<CompanyAddress>>(entitiy.CompanyAddressDTOs);
            var company = _ICompaniesRepository.Add(companiesMapper);
            _unitOfWork.SaveChanges();
        }

        public bool Delete(int id)
        {
            var result = _ICompaniesRepository.GetById(id);
            if (result != null)
            {
                result.Status = 3;
                _ICompaniesRepository.Update(result);
                _unitOfWork.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<CompanyDTO> GetAll(int languageId)
        {
            var result = _ICompaniesRepository.GetAllWithCompanyAddress();
            List<CompanyDTO> _companyList = new List<CompanyDTO>();
            foreach (var item in result)
            {
                var companyMapper = _mapper.Map<CompanyDTO>(item);
                companyMapper.CompanyAddressDTOs = _mapper.Map<List<CompanyAddressDTO>>(item.CompanyAddress);
                _companyList.Add(companyMapper);
            }
            return _companyList;

        }

        public List<CompanyDTO> GetBy(int languageId)
        {
            return _mapper.Map<List<CompanyDTO>>(_ICompaniesRepository.GetBy(x => x.Status == 1).ToList());
        }

        public CompanyDTO GetById(int id, int languageId)
        {
            var result = _ICompaniesRepository.GetById(id);
            var companyDTO = _mapper.Map<CompanyDTO>(result);
            companyDTO.CompanyAddressDTOs = _mapper.Map<List<CompanyAddressDTO>>(result.CompanyAddress);
            return companyDTO;
        }

        public CompanyDTO getComponyDetail(int id)
        {
            var result = _ICompaniesRepository.GetCompanyDetail(id);
            var companyDto = _mapper.Map<CompanyDTO>(result);
            companyDto.CompanyAddressDTOs = _mapper.Map<List<CompanyAddressDTO>>(result.CompanyAddress);
            return companyDto;
        }

        public bool Update(CompanyDTO entitiy)
        {
            var data = _mapper.Map<Companies>(entitiy);
            var updatedvalue = _ICompaniesRepository.Update(data);
            if (updatedvalue != null)
            {
                _unitOfWork.SaveChanges();
                if (entitiy.CompanyAddressDTO != null)
                {
                    var companyAddressMapper = _mapper.Map<CompanyAddress>(entitiy.CompanyAddressDTO);
                    var updatevalue = _ICompanyAddressRepository.Update(companyAddressMapper);
                    if (updatevalue != null)
                    {
                        _unitOfWork.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }

            }
            else
            {
                return false;
            }
        }
    }
}