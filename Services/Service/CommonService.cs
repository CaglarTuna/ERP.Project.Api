using AutoMapper;
using Core;
using Core.IRepository;
using Core.IUnitOfWork;
using DTO;
using Microsoft.AspNetCore.Mvc.Rendering;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public class CommonService : ICommonService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ICommonRepository _commonRepository;
        private readonly ICurrenciesRepository _currenciesRepository;
        private readonly IUnitsOfMeasureRepository _unitsOfMeasureRepository;
        private readonly ICountryRepository _countryRepository;
        private readonly ICityRepository _cityRepository;
        public CommonService(IUnitOfWork unitOfWork, IMapper mapper, ICommonRepository commonRepository, ICurrenciesRepository currenciesRepository, IUnitsOfMeasureRepository unitsOfMeasureRepository, ICountryRepository countryRepository, ICityRepository cityRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _commonRepository = commonRepository;
            _currenciesRepository = currenciesRepository;
            _unitsOfMeasureRepository = unitsOfMeasureRepository;
            _countryRepository = countryRepository;
            _cityRepository = cityRepository;
        }


        public void Add(CommonDTO entitiy)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<CommonDTO> GetAll(int languageId)
        {
            List<CommonDTO> commonDTOs = new List<CommonDTO>();
            var currency = _mapper.Map<List<CurrenciesDTO>>(_currenciesRepository.GetAll().ToList());
            var unitOfMeasure = _mapper.Map<List<UnitsOfMeasureDTO>>(_unitsOfMeasureRepository.GetAll().ToList());
            var country = _mapper.Map<List<CountryDTO>>(_countryRepository.GetAllCountry());

            commonDTOs.Add(new CommonDTO()
            {
                currenciesDTOs = currency,
                unitsOfMeasureDTOs=unitOfMeasure,
                countries=country,
                RoleNames=_commonRepository.getRoles(),
                proccessNames=_commonRepository.getProccess(),
                HeightMeasures=_commonRepository.GetHeightMeasures(),
                MaterialShape=_commonRepository.GetShape()
            });
            return commonDTOs;
        }

        public List<CommonDTO> GetBy(int languageId)
        {
            throw new NotImplementedException();
        }

        public CommonDTO GetById(int id, int languageId)
        {
            throw new NotImplementedException();
        }

        public List<CityDTO> getCity(int id)
        {
            var result = _mapper.Map<List<CityDTO>>(_cityRepository.getCity(id));
            return result;
        }

        public bool Update(CommonDTO entitiy)
        {
            throw new NotImplementedException();
        }
    }
}
