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
    public class RawMaterialService : IRawMaterialService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IRawMaterialsRepository _IRawMaterialsRepository; //Core Katmanı

        public RawMaterialService(IUnitOfWork unitOfWork, IMapper mapper, IRawMaterialsRepository iRawMaterialsRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _IRawMaterialsRepository = iRawMaterialsRepository;
        }

        public void Add(RawMaterialDTO entitiy)
        {
            var rawMaterialMapper = _mapper.Map<RawMaterials>(entitiy);
            var rawMaterialEntitiy = _IRawMaterialsRepository.Add(rawMaterialMapper);
            _unitOfWork.SaveChanges();
        }

        public bool Delete(int id)
        {
            var result = _IRawMaterialsRepository.GetById(id);
            if (result != null)
            {
                result.Status = 3;
                _IRawMaterialsRepository.Delete(result);
                _unitOfWork.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<RawMaterialDTO> GetAll(int languageId)
        {
            return _mapper.Map<List<RawMaterialDTO>>(_IRawMaterialsRepository.GetAllWithRawMaterial().ToList());
        }

        public List<RawMaterialDTO> GetBy(int languageId)
        {
            return _mapper.Map<List<RawMaterialDTO>>(_IRawMaterialsRepository.GetBy(x => x.Status == 1).ToList());
        }

        public RawMaterialDTO GetById(int id, int languageId)
        {
            return _mapper.Map<RawMaterialDTO>(_IRawMaterialsRepository.GetById(id));
        }

        public bool Update(RawMaterialDTO entitiy)
        {
            var data = _mapper.Map<RawMaterials>(entitiy);
            var updatedvalue = _IRawMaterialsRepository.Update(data);
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
