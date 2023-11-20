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
    public class ConsumptionMaterialStockService : IConsumptionMaterialStockService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IConsumptionMaterialStockRepository _consumptionMaterialStockRepository;
        public ConsumptionMaterialStockService(IUnitOfWork unitOfWork, IMapper mapper, IConsumptionMaterialStockRepository consumptionMaterialStockRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _consumptionMaterialStockRepository = consumptionMaterialStockRepository;
        }


        public void Add(ConsumptionMaterialStockDTO entitiy)
        {
            var StockMapper = _mapper.Map<ConsumptionMaterialStock>(entitiy);
            var AddStock = _consumptionMaterialStockRepository.Add(StockMapper);
            _unitOfWork.SaveChanges();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ConsumptionMaterialStockDTO> GetAll(int languageId)
        {
            return _mapper.Map<List<ConsumptionMaterialStockDTO>>(_consumptionMaterialStockRepository.GetAllMaterialStock().ToList());
        }

        public List<ConsumptionMaterialStockDTO> GetBy(int languageId)
        {
            return _mapper.Map<List<ConsumptionMaterialStockDTO>>(_consumptionMaterialStockRepository.GetBy(x => x.Status == 1).ToList());
        }

        public ConsumptionMaterialStockDTO GetById(int id, int languageId)
        {
            return _mapper.Map<ConsumptionMaterialStockDTO>(_consumptionMaterialStockRepository.GetByIdStock(id).AsEnumerable());
        }

        public bool Update(ConsumptionMaterialStockDTO entitiy)
        {
            var stockMapper = _mapper.Map<ConsumptionMaterialStock>(entitiy);
            var updateStock = _consumptionMaterialStockRepository.Update(stockMapper);
            if (updateStock != null)
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
