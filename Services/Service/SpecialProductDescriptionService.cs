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
    public class SpecialProductDescriptionService : ISpecialProductDescriptionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ISpeacialProductDescriptionRepository _speacialProductDescriptionRepository;

        public SpecialProductDescriptionService(ISpeacialProductDescriptionRepository speacialProductDescriptionRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _speacialProductDescriptionRepository = speacialProductDescriptionRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public void Add(SpeacialProductDescriptionDTO entitiy)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<SpeacialProductDescriptionDTO> GetAll(int languageId)
        {
            var result= _mapper.Map<List<SpeacialProductDescriptionDTO>>(_speacialProductDescriptionRepository.GetAll());
            return result;
        }

        public List<SpeacialProductDescriptionDTO> GetBy(int languageId)
        {
            throw new NotImplementedException();
        }

        public SpeacialProductDescriptionDTO GetById(int id, int languageId)
        {
            return _mapper.Map<SpeacialProductDescriptionDTO>(_speacialProductDescriptionRepository.GetById(id));
        }

        public bool Update(SpeacialProductDescriptionDTO entitiy)
        {
            var specialMapper = _mapper.Map<SpeacialProductDescription>(entitiy);
            var UpdateValue = _speacialProductDescriptionRepository.Update(specialMapper);
            if (UpdateValue!=null)
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
