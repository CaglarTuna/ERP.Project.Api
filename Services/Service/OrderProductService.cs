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
    public class OrderProductService : IOrderProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IOrderProductsRepository _orderProductRepository;
        private readonly IMaterialSupplyRequestsRepository _materialSupplyRequestsRepository;
        public OrderProductService(IUnitOfWork unitOfWork, IMapper mapper, IOrderProductsRepository orderProductRepository, IMaterialSupplyRequestsRepository materialSupplyRequestsRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _orderProductRepository = orderProductRepository;
            _materialSupplyRequestsRepository = materialSupplyRequestsRepository;
        }

        public void Add(OrderProductDTO entitiy)
        {
            var orderProductMapper = _mapper.Map<OrderProducts>(entitiy);
            var orderProductEntity = _orderProductRepository.Add(orderProductMapper);
            _unitOfWork.SaveChanges();
        }

        public bool Delete(int id)
        {
            var result = _orderProductRepository.GetById(id);
            if (result != null)
            {
                result.Status = 3;
                _orderProductRepository.Update(result);
                _unitOfWork.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<OrderProductDTO> GetAll(int languageId)
        {
            var result = _orderProductRepository.OrderProducts();
            List<OrderProductDTO> orderProducts = new List<OrderProductDTO>();
            foreach (var item in result)
            {
                var OrderProductMapper = _mapper.Map<OrderProductDTO>(item);
                OrderProductMapper.Products = _mapper.Map<ProductDTO>(item.Products);
                OrderProductMapper.Products.productMaterialDTOs = _mapper.Map<List<ProductMaterialDTO>>(item.Products.ProductMaterials);
                OrderProductMapper.Products.Categories = _mapper.Map<CategoryDTO>(item.Products.Categories);
                OrderProductMapper.Products.Categories.CategoryLanguageDTOs = _mapper.Map<List<CategoryLanguageDTO>>(item.Products.Categories.CategoriesLanguage);

                orderProducts.Add(OrderProductMapper);
            }
            return orderProducts;
            
        }

        public List<OrderProductDTO> GetBy(int languageId)
        {
            return _mapper.Map<List<OrderProductDTO>>(_orderProductRepository.GetBy(x => x.Status == 1).ToList());
        }

        public OrderProductDTO GetById(int id, int languageId)
        {
            return _mapper.Map<OrderProductDTO>(_orderProductRepository.GetById(id));
        }

        public List<OrderProductDTO> getProductWithOrderId(int id, int orderId)
        {
            var result = _orderProductRepository.GetByIdOrderProducts(id, orderId).ToList();
            List<OrderProductDTO> orderProducts = new List<OrderProductDTO>();
            foreach (var item in result)
            {
                var orderProductMaterial = _mapper.Map<OrderProductDTO>(item);
                orderProductMaterial.Products.productMaterialDTOs = _mapper.Map<List<ProductMaterialDTO>>(item.Products.ProductMaterials);
                orderProducts.Add(orderProductMaterial);
            }
            return orderProducts;
        }

        public List<OrderProductDTO> GetSelectOrderProduct()
        {
            throw new System.NotImplementedException();
        }

        public bool PropertyUpdate(OrderProductDTO orderProduct)
        {
            var data = _mapper.Map<OrderProducts>(orderProduct);
            _orderProductRepository.Update(data);
            _unitOfWork.SaveChanges();
            return true;
        }

        public bool Update(OrderProductDTO entitiy)
        {
            var data = _mapper.Map<OrderProducts>(entitiy);
            var updatedvalue = _orderProductRepository.Update(data);
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