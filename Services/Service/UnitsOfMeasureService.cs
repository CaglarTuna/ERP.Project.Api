using AutoMapper;
using Core;
using Core.IUnitOfWork;
using DTO;
using Entity;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Service
{
    public class UnitsOfMeasureService : IUnitsOfMeasureService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IUnitsOfMeasureRepository _unitsOfMeasureRepository;

        public UnitsOfMeasureService(IUnitOfWork unitOfWork, IMapper mapper, IUnitsOfMeasureRepository unitsOfMeasureRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _unitsOfMeasureRepository = unitsOfMeasureRepository;
        }

        public void Add(UnitsOfMeasureDTO entitiy)
        {
            var unitsOfMeasureMapper = _mapper.Map<UnitsOfMeasure>(entitiy);
            var unitsOfMeasureentity = _unitsOfMeasureRepository.Add(unitsOfMeasureMapper);
            _unitOfWork.SaveChanges();
        }

        public bool Delete(int id)
        {
            var result = _unitsOfMeasureRepository.GetById(id);
            if (result != null)
            {
                result.Status = 3;
                _unitsOfMeasureRepository.Update(result);
                _unitOfWork.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<UnitsOfMeasureDTO> GetAll(int languageId)
        {
            return _mapper.Map<List<UnitsOfMeasureDTO>>(_unitsOfMeasureRepository.GetAll().ToList());
        }

        public List<UnitsOfMeasureDTO> GetBy(int languageId)
        {
            return _mapper.Map<List<UnitsOfMeasureDTO>>(_unitsOfMeasureRepository.GetBy(x => x.Status == 1).ToList());
        }

        public UnitsOfMeasureDTO GetById(int id, int languageId)
        {
            return _mapper.Map<UnitsOfMeasureDTO>(_unitsOfMeasureRepository.GetById(id));
        }

        public bool Update(UnitsOfMeasureDTO entitiy)
        {
            var data = _mapper.Map<UnitsOfMeasure>(entitiy);
            var updatedvalue = _unitsOfMeasureRepository.Update(data);
            if (updatedvalue != null)
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
