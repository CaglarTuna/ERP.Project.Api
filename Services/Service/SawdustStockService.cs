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
    public class SawdustStockService : ISawdustStockService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ISawdustStockRepository _sawdustStockRepository;

        public SawdustStockService(ISawdustStockRepository sawdustStockRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _sawdustStockRepository = sawdustStockRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public void Add(SawdustStockDTO entitiy)
        {
            var sawStock = _mapper.Map<SawdustStock>(entitiy);
            sawStock.Status = 1;
            var sawStockentity = _sawdustStockRepository.Add(sawStock);
            _unitOfWork.SaveChanges();
        }

        public bool Delete(int id)
        {
            var result = _sawdustStockRepository.GetById(id);
            if (result != null)
            {
                result.Status = 3;
                _sawdustStockRepository.Update(result);
                _unitOfWork.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<SawdustStockDTO> GetAll(int languageId)
        {
            return _mapper.Map<List<SawdustStockDTO>>(_sawdustStockRepository.sawdustStocks().ToList());
        }

        public List<SawdustStockDTO> GetBy(int languageId)
        {
            return _mapper.Map<List<SawdustStockDTO>>(_sawdustStockRepository.GetBy(x => x.Status == 1).ToList());
        }

        public SawdustStockDTO GetById(int id, int languageId)
        {
            return _mapper.Map<SawdustStockDTO>(_sawdustStockRepository.GetById(id));
        }

        public bool Update(SawdustStockDTO entitiy)
        {
            var data = _mapper.Map<SawdustStock>(entitiy);
            var updatedvalue = _sawdustStockRepository.Update(data);
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
