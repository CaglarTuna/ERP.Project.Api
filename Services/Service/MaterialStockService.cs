using AutoMapper;
using Core;
using Core.IRepository;
using Core.IUnitOfWork;
using DTO;
using Entity;
using Services.IServices;
using System.Collections.Generic;
using System.Linq;

namespace Services.Service
{
    public class MaterialStockService : IMaterialStockService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IMaterialStockRepository _materialStockRepository;
        private readonly IOrderMaterialRepository _orderMaterialRepository;
        public MaterialStockService(IMaterialStockRepository materialStockRepository, IMapper mapper, IUnitOfWork unitOfWork, IOrderMaterialRepository orderMaterialRepository)
        {
            _materialStockRepository = materialStockRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _orderMaterialRepository = orderMaterialRepository;
        }

        public void Add(MaterialStockDTO entitiy)
        {
            var materialStock = _mapper.Map<MaterialStock>(entitiy);
            var OrderMaterialMapper = _mapper.Map<List<OrderMaterial>>(entitiy.OrderMaterials);
            materialStock.Status = 1;
            var materialStockEntity = _materialStockRepository.Add(materialStock);
            if (materialStockEntity != null)
            {
                _unitOfWork.SaveChanges();
                if (OrderMaterialMapper != null)
                {
                    List<OrderMaterial> orders = new List<OrderMaterial>();
                    foreach (var item in OrderMaterialMapper)
                    {
                        orders.Add(new OrderMaterial()
                        {
                            CreateDate = item.CreateDate,
                            MaterialId = (int)entitiy.MaterialId,
                            OrderId = item.OrderId,
                            Quantitiy = item.Quantitiy,
                            Status = 1,
                            UpdateDate = item.UpdateDate
                        });
                    }
                    _orderMaterialRepository.AddRange(orders);
                    _unitOfWork.SaveChanges();
                }
            }
        }

        public bool Delete(int id)
        {
            var result = _materialStockRepository.GetById(id);
            if (result != null)
            {
                result.Status = 3;
                _materialStockRepository.Update(result);
                _unitOfWork.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<MaterialStockDTO> GetAll(int languageId)
        {
            var result = _materialStockRepository.GetAllStock();
            List<MaterialStockDTO> materialStocks = new List<MaterialStockDTO>();
            foreach (var item in result)
            {
                var stockMapper = _mapper.Map<MaterialStockDTO>(item);
                stockMapper.Materials = _mapper.Map<MaterialDTO>(item.Materials);
                stockMapper.Materials.CurrenciesDTO = _mapper.Map<CurrenciesDTO>(item.Materials.Currencies);
                stockMapper.Materials.HeightMeasureDTO = _mapper.Map<HeightMeasureDTO>(item.Materials.HeightMeasure);
                stockMapper.Companies = _mapper.Map<CompanyDTO>(item.Companies);
                stockMapper.Stores = _mapper.Map<StoreDTO>(item.Stores);
                materialStocks.Add(stockMapper);
            }
            return materialStocks;
        }

        public List<MaterialStockDTO> GetBy(int languageId)
        {
            return _mapper.Map<List<MaterialStockDTO>>(_materialStockRepository.GetBy(x => x.Status == 1).ToList());
        }

        public MaterialStockDTO GetById(int id, int languageId)
        {
            return _mapper.Map<MaterialStockDTO>(_materialStockRepository.GetById(id));
        }
        public bool Update(MaterialStockDTO entitiy)
        {
            var data = _mapper.Map<MaterialStock>(entitiy);
            var updatedvalue = _materialStockRepository.Update(data);
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
