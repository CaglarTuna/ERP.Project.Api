using AutoMapper;
using Core;
using Core.IRepository;
using Core.IUnitOfWork;
using DTO;
using Entity;
using Services.IServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Service
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IProductsRepository _productsRepository;
        private readonly IProductProcessRepository _productProcessRepository;
        private readonly IProductMaterialsRepository _productMaterialRepository;
        private readonly IDocumentRepository _documentRepository;
        private readonly IProductDocumentRepository _productDocumentRepository;
        private readonly ISpeacialProductDescriptionRepository _speacialProductDescriptionRepository;
        public ProductService(IUnitOfWork unitOfWork, IMapper mapper, IProductsRepository productsRepository, IProductProcessRepository productProcessRepository, IProductMaterialsRepository productMaterialRepository, IProductDocumentRepository productDocumentRepository, IDocumentRepository documentRepository, ISpeacialProductDescriptionRepository speacialProductDescriptionRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _productsRepository = productsRepository;
            _productProcessRepository = productProcessRepository;
            _productMaterialRepository = productMaterialRepository;
            _productDocumentRepository = productDocumentRepository;
            _documentRepository = documentRepository;
            _speacialProductDescriptionRepository = speacialProductDescriptionRepository;
        }


        public void Add(ProductDTO entitiy)
        {
            var productMapper = _mapper.Map<Products>(entitiy);
            var productProccessMapper = _mapper.Map<List<ProductProcess>>(entitiy.productProcessDTOs);
            var productMaterialMapper = _mapper.Map<List<ProductMaterials>>(entitiy.productMaterialDTOs);
            var documents = _mapper.Map<List<Document>>(entitiy.documentDTOs);
            productMapper.Status = 1;
            var productEntity = _productsRepository.Add(productMapper);
            _unitOfWork.SaveChanges();
            ProductProcess productProcess = new ProductProcess();
            foreach (var item in productProccessMapper)
            {
                productProcess = new ProductProcess()
                {
                    CreateDate = item.CreateDate,
                    ProcessDuration = item.ProcessDuration,
                    ProcessId = item.ProcessId,
                    ProcessOrderNo = item.ProcessOrderNo,
                    ProductId = productEntity.Id,
                    UpdateDate = item.UpdateDate,
                    Status = 1
                };
                _productProcessRepository.Add(productProcess);
                _unitOfWork.SaveChanges();
            }
            ProductMaterials productMaterials = new ProductMaterials();
            foreach (var item in productMaterialMapper)
            {
                productMaterials = new ProductMaterials()
                {
                    Count = item.Count,
                    CreateDate = item.CreateDate,
                    MaterialId = item.MaterialId,
                    ProductId = productEntity.Id,
                    Status = 1,
                    UpdateDate = item.UpdateDate
                };
                _productMaterialRepository.Add(productMaterials);
                _unitOfWork.SaveChanges();
            }
            List<Document> document = new List<Document>();
            foreach (var item in documents)
            {
                document.Add(new Document()
                {
                    CreateDate = item.CreateDate,
                    Name = item.Name,
                    Path = item.Path,
                    Status = 1,
                    Type = item.Type,
                    UpdateDate = item.UpdateDate,
                    UrlPath = item.UrlPath

                });
            }
            _documentRepository.AddRange(document);
            _unitOfWork.SaveChanges();
            ProductDocument productDocument = new ProductDocument();
            foreach (var item in document)
            {
                productDocument = new ProductDocument()
                {
                    CreateDate = item.CreateDate,
                    DocumentId = item.Id,
                    ProductId = productEntity.Id,
                    Status = 1,
                    UpdateDate = item.UpdateDate
                };
                _productDocumentRepository.Add(productDocument);
                _unitOfWork.SaveChanges();
            }
        }

        public bool Delete(int id)
        {
            var result = _productsRepository.GetById(id);
            if (result != null)
            {
                result.Status = 3;
                _productsRepository.Update(result);
                _unitOfWork.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<ProductDTO> GetAll(int languageId)
        {
            var result = _productsRepository.GetAllProducts();
            List<ProductDTO> products = new List<ProductDTO>();
            foreach (var item in result)
            {
                var productMapper = _mapper.Map<ProductDTO>(item);
                productMapper.productMaterialDTOs = _mapper.Map<List<ProductMaterialDTO>>(item.ProductMaterials);
                productMapper.productProcessDTOs = _mapper.Map<List<ProductProcessDTO>>(item.ProductProcess);
                productMapper.productStockDTOs = _mapper.Map<List<ProductStockDTO>>(item.ProductStock);
                productMapper.offerDTOs = _mapper.Map<List<OfferDTO>>(item.Offers);
                productMapper.orderProductDTOs = _mapper.Map<List<OrderProductDTO>>(item.OrderProducts);
                productMapper.staffProcessPermisionsDTOs = _mapper.Map<List<StaffProcessPermisionsDTO>>(item.StaffProcesses);
                productMapper.productDocumentDTOs = _mapper.Map<List<ProductDocumentDTO>>(item.ProductDocuments);
                products.Add(productMapper);
            }
            return products;
        }

        public async Task<List<ProductDTO>> getAllAsync()
        {
            var reslt = await _productsRepository.getAllProductAsync();
            return _mapper.Map<List<ProductDTO>>(reslt);
        }

        public List<ProductDTO> GetBy(int languageId)
        {
            return _mapper.Map<List<ProductDTO>>(_productsRepository.GetBy(x => x.Status == 1).ToList());
        }

        public List<ProductDTO> GetByCategoryIdProducts(int id)
        {
            var result = _productsRepository.GetCategoryByProducts(id);
            List<ProductDTO> products = new List<ProductDTO>();
            foreach (var item in result)
            {
                var productMapper = _mapper.Map<ProductDTO>(item);
                productMapper.productMaterialDTOs = _mapper.Map<List<ProductMaterialDTO>>(item.ProductMaterials);
                productMapper.productProcessDTOs = _mapper.Map<List<ProductProcessDTO>>(item.ProductProcess);
                productMapper.productStockDTOs = _mapper.Map<List<ProductStockDTO>>(item.ProductStock);
                productMapper.offerDTOs = _mapper.Map<List<OfferDTO>>(item.Offers);
                productMapper.orderProductDTOs = _mapper.Map<List<OrderProductDTO>>(item.OrderProducts);
                productMapper.staffProcessPermisionsDTOs = _mapper.Map<List<StaffProcessPermisionsDTO>>(item.StaffProcesses);
                productMapper.productDocumentDTOs = _mapper.Map<List<ProductDocumentDTO>>(item.ProductDocuments);
                products.Add(productMapper);
            }
            return products;
        }

        public ProductDTO GetById(int id, int languageId)
        {
            var result = _productsRepository.GetProducts(id);
            var productDto = _mapper.Map<ProductDTO>(result);
            productDto.productMaterialDTOs = _mapper.Map<List<ProductMaterialDTO>>(result.ProductMaterials);
            productDto.productProcessDTOs = _mapper.Map<List<ProductProcessDTO>>(result.ProductProcess);
            productDto.productStockDTOs = _mapper.Map<List<ProductStockDTO>>(result.ProductStock);
            productDto.offerDTOs = _mapper.Map<List<OfferDTO>>(result.Offers);
            productDto.orderProductDTOs = _mapper.Map<List<OrderProductDTO>>(result.OrderProducts);
            productDto.staffProcessPermisionsDTOs = _mapper.Map<List<StaffProcessPermisionsDTO>>(result.StaffProcesses);
            productDto.productDocumentDTOs = _mapper.Map<List<ProductDocumentDTO>>(result.ProductDocuments);
            return productDto;

        }

        public List<SpeacialProductDescriptionDTO> GetSpecialProduct()
        {
            return _mapper.Map<List<SpeacialProductDescriptionDTO>>(_speacialProductDescriptionRepository.GetAll());
        }

        public List<ProductProcessDTO> productProcesses()
        {
            return _mapper.Map<List<ProductProcessDTO>>(_productProcessRepository.GetAllProductProccess().ToList());
        }

        public bool Update(ProductDTO entitiy)
        {
            var productMapper = _mapper.Map<Products>(entitiy);
            var productMaterialMapper = _mapper.Map<List<ProductMaterials>>(entitiy.productMaterialDTOs);
            var productProccesMapper = _mapper.Map<List<ProductProcess>>(entitiy.productProcessDTOs);
            var documents = _mapper.Map<List<Document>>(entitiy.documentDTOs);
            var productUpdate = _productsRepository.Update(productMapper);
            if (productUpdate != null)
            {
                _unitOfWork.SaveChanges();
                if (productProccesMapper != null)
                {
                    ProductProcess productProcess = new ProductProcess();
                    var allProductProcces = _productProcessRepository.GetBy(x => x.ProductId == productMapper.Id).ToList();
                    _productProcessRepository.DeleteRange(allProductProcces);
                    foreach (var item in productProccesMapper)
                    {
                        productProcess = new ProductProcess()
                        {
                            CreateDate = item.CreateDate,
                            ProcessDuration = item.ProcessDuration,
                            ProcessId = item.ProcessId,
                            ProcessOrderNo = item.ProcessOrderNo,
                            ProductId = productMapper.Id,
                            UpdateDate = item.UpdateDate,
                            Status = 1
                        };
                        _productProcessRepository.Add(productProcess);
                        _unitOfWork.SaveChanges();
                    }
                }
                if (productMaterialMapper != null)
                {
                    ProductMaterials materials = new ProductMaterials();
                    var allProductMaterials = _productMaterialRepository.GetBy(x => x.ProductId == productMapper.Id).ToList();
                    _productMaterialRepository.DeleteRange(allProductMaterials);
                    foreach (var item in productMaterialMapper)
                    {
                        materials = new ProductMaterials()
                        {
                            Count = item.Count,
                            CreateDate = item.CreateDate,
                            MaterialId = item.MaterialId,
                            ProductId = productMapper.Id,
                            Status = 1,
                            UpdateDate = item.UpdateDate
                        };
                        _productMaterialRepository.Add(materials);
                        _unitOfWork.SaveChanges();
                    }
                }
                List<Document> document = new List<Document>();
                if (documents != null)
                {
                    foreach (var item in documents)
                    {
                        document.Add(new Document()
                        {
                            CreateDate = item.CreateDate,
                            Name = item.Name,
                            Path = item.Path,
                            Status = 1,
                            UrlPath = item.UrlPath,
                            UpdateDate = item.UpdateDate,
                            Type = item.Type
                        });
                        _documentRepository.AddRange(document);
                        _unitOfWork.SaveChanges();
                    }
                    var allProductDocument = _productDocumentRepository.GetBy(x => x.ProductId == productMapper.Id).ToList();
                    _productDocumentRepository.DeleteRange(allProductDocument);

                    ProductDocument productDocument = new ProductDocument();
                    foreach (var item in document)
                    {
                        productDocument = new ProductDocument()
                        {
                            CreateDate = item.CreateDate,
                            DocumentId = item.Id,
                            ProductId = productMapper.Id,
                            Status = 1,
                            UpdateDate = item.UpdateDate
                        };
                        _productDocumentRepository.Add(productDocument);
                        _unitOfWork.SaveChanges();
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}