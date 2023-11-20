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
    public class ProductStockService : IProductStockService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IProductStockRepository _productStockRepository;

        public ProductStockService(IProductStockRepository productStockRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _productStockRepository = productStockRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public void Add(ProductStockDTO entitiy)
        {
            var stock = _mapper.Map<ProductStock>(entitiy);
            stock.Status = 1;
            var stockEntity = _productStockRepository.Add(stock);
            _unitOfWork.SaveChanges();
        }

        public bool Delete(int id)
        {
            var result = _productStockRepository.GetById(id);
            if (result != null)
            {
                result.Status = 3;
                _productStockRepository.Update(result);
                _unitOfWork.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<ProductStockDTO> GetAll(int languageId)
        {
            return _mapper.Map<List<ProductStockDTO>>(_productStockRepository.GetAll().ToList());
        }

        public List<ProductStockDTO> GetBy(int languageId)
        {
            return _mapper.Map<List<ProductStockDTO>>(_productStockRepository.GetBy(x => x.Status == 1).ToList());
        }

        public ProductStockDTO GetById(int id, int languageId)
        {
            return _mapper.Map<ProductStockDTO>(_productStockRepository.GetById(id));
        }

        public List<ProductDTO> GetByIdProductStock(int id)
        {
            var result = _productStockRepository.ProductStock(id);
            List<ProductDTO> products = new List<ProductDTO>();
            foreach (var item in result)
            {
                var productMapper = _mapper.Map<ProductDTO>(item);
                productMapper.productStockDTOs = _mapper.Map<List<ProductStockDTO>>(item.ProductStock);
                productMapper.orderProductDTOs = _mapper.Map<List<OrderProductDTO>>(item.OrderProducts);
                products.Add(productMapper);
            }
            return products;
        }

        public bool ProductStockUpdate(ProductStockDTO productStock)
        {
            var data = _mapper.Map<ProductStock>(productStock);
            var updateValue = _productStockRepository.Update(data);
            if (updateValue != null)
            {
                _unitOfWork.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Update(ProductStockDTO entitiy)
        {
            var data = _mapper.Map<ProductStock>(entitiy);
            var updatedvalue = _productStockRepository.Update(data);
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
