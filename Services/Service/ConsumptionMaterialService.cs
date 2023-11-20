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
    public class ConsumptionMaterialService : IConsumptionMaterialService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IConsumptionMaterialsRepository _consumptionMaterialsRepository;
        private readonly IConsumptionMaterialStockRepository _consumptionMaterialStockRepository;
        private readonly IConsumptionMaterialSuppliersRepository _consumptionMaterialSuppliersRepository;

        public ConsumptionMaterialService(IUnitOfWork unitOfWork, IMapper mapper, IConsumptionMaterialsRepository consumptionMaterialsRepository, IConsumptionMaterialStockRepository consumptionMaterialStockRepository, IConsumptionMaterialSuppliersRepository consumptionMaterialSuppliersRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _consumptionMaterialsRepository = consumptionMaterialsRepository;
            _consumptionMaterialStockRepository = consumptionMaterialStockRepository;
            _consumptionMaterialSuppliersRepository = consumptionMaterialSuppliersRepository;
        }

        public void Add(ConsumptionMaterialDTO entitiy)
        {
            var consumptionMaterialMapper = _mapper.Map<ConsumptionMaterials>(entitiy);
            var consumptionMaterialSupplierMapper = _mapper.Map<List<ConsumptionMaterialSuppliers>>(entitiy.ConsumptionMaterialSuppliers);
            var consumptionMaterialEntity = _consumptionMaterialsRepository.Add(consumptionMaterialMapper);
            _unitOfWork.SaveChanges();
            List<ConsumptionMaterialSuppliers> consumptionMaterialSuppliers = new List<ConsumptionMaterialSuppliers>();
            foreach (var item in consumptionMaterialSupplierMapper)
            {
                consumptionMaterialSuppliers.Add(new ConsumptionMaterialSuppliers()
                {
                    CompanyId=item.CompanyId,
                    ConsumptionMaterialId= consumptionMaterialEntity.Id,
                    CreateDate=item.CreateDate,
                    UpdateDate=item.UpdateDate,
                    Status=item.Status
                });
            }
            _consumptionMaterialSuppliersRepository.AddRange(consumptionMaterialSuppliers);
            _unitOfWork.SaveChanges();
        }

        public bool Delete(int id)
        {
            var result = _consumptionMaterialsRepository.GetById(id);
            if (result != null)
            {
                result.Status = 3;
                _consumptionMaterialsRepository.Update(result);
                _unitOfWork.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<ConsumptionMaterialDTO> GetAll(int languageId)
        {
            return _mapper.Map<List<ConsumptionMaterialDTO>>(_consumptionMaterialsRepository.GetAllConsumptionMaterial().ToList());
        }

        public List<ConsumptionMaterialStockDTO> GetAllStock()
        {
            return _mapper.Map<List<ConsumptionMaterialStockDTO>>(_consumptionMaterialsRepository.GetAllMaterialStock().ToList());
        }

        public List<ConsumptionMaterialDTO> GetBy(int languageId)
        {
            return _mapper.Map<List<ConsumptionMaterialDTO>>(_consumptionMaterialsRepository.GetBy(x => x.Status == 1).ToList());
        }

        public ConsumptionMaterialDTO GetById(int id, int languageId)
        {
            return _mapper.Map<ConsumptionMaterialDTO>(_consumptionMaterialsRepository.GetById(id));
        }

        public ConsumptionMaterialStockDTO GetByIdStock(int id)
        {
            return _mapper.Map<ConsumptionMaterialStockDTO>(_consumptionMaterialsRepository.GetByIdStock(1).AsEnumerable());
        }

        public ConsumptionMaterialDTO getConsumptionMaterialDetail(int id)
        {
            var result = _consumptionMaterialsRepository.GetByConsumptionDetail(id).FirstOrDefault();
            var consumptionMaterialDto = _mapper.Map<ConsumptionMaterialDTO>(result);
            consumptionMaterialDto.ConsumptionMaterialSuppliers = _mapper.Map<List<ConsumptionMaterialSupplierDTO>>(result.ConsumptionMaterialSuppliers);
            return consumptionMaterialDto;
        }

        public bool Update(ConsumptionMaterialDTO entitiy)
        {
            var materialMapper = _mapper.Map<ConsumptionMaterials>(entitiy);
            var materailSupperlier = _mapper.Map<List<ConsumptionMaterialSuppliers>>(entitiy.ConsumptionMaterialSuppliers);
            var consuptionUpdate = _consumptionMaterialsRepository.Update(materialMapper);
            if (consuptionUpdate != null)
            {
                _unitOfWork.SaveChanges();
                if (materailSupperlier != null)
                {
                    var materialPermissions = _consumptionMaterialSuppliersRepository.GetBy(x => x.ConsumptionMaterialId == entitiy.Id).ToList();
                    _consumptionMaterialSuppliersRepository.DeleteRange(materialPermissions);
                    List<ConsumptionMaterialSuppliers> consumptionMaterialSuppliers = new List<ConsumptionMaterialSuppliers>();
                    foreach (var item in materailSupperlier)
                    {
                        consumptionMaterialSuppliers.Add(new ConsumptionMaterialSuppliers()
                        {
                            CompanyId = item.CompanyId,
                            ConsumptionMaterialId = entitiy.Id,
                            Status = 1,
                            UpdateDate = entitiy.UpdateDate,
                            CreateDate = entitiy.CreateDate
                        });
                    }
                    _consumptionMaterialSuppliersRepository.AddRange(consumptionMaterialSuppliers);
                    _unitOfWork.SaveChanges();
                    return true;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}