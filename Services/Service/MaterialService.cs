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
    public class MaterialService : IMaterialService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IMaterialsRepository _materialRepository;
        private readonly IMaterialRawMaterialsRepository _materialRawMaterialReposiyory;
        private readonly IRawMaterialsRepository _rawMaterialsRepository;
        private readonly IMaterialCertificatesRepository _materialCertificatesRepository;
        private readonly IMaterialSuppliersRepository _materialSuppliersRepository;
        private readonly IMaterialUnitsOfMeasuresRepository _materialUnitsOfMeasuresRepository;
        private readonly IMaterialExpertDeliverysRepository _materialExpertDeliverysRepository;
        private readonly IMaterialHeightMeasureRepository _materialHeightMeasureRepository;
        public MaterialService(IUnitOfWork unitOfWork, IMapper mapper, IMaterialsRepository materialsRepository, IMaterialRawMaterialsRepository materialRawMaterialReposiyory, IRawMaterialsRepository rawMaterialsRepository, IMaterialCertificatesRepository materialCertificatesRepository, IMaterialSuppliersRepository materialSuppliersRepository, IMaterialUnitsOfMeasuresRepository materialUnitsOfMeasuresRepository, IMaterialExpertDeliverysRepository materialExpertDeliverysRepository, IMaterialHeightMeasureRepository materialHeightMeasureRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _materialRepository = materialsRepository;
            _materialRawMaterialReposiyory = materialRawMaterialReposiyory;
            _rawMaterialsRepository = rawMaterialsRepository;
            _materialCertificatesRepository = materialCertificatesRepository;
            _materialSuppliersRepository = materialSuppliersRepository;
            _materialUnitsOfMeasuresRepository = materialUnitsOfMeasuresRepository;
            _materialExpertDeliverysRepository = materialExpertDeliverysRepository;
            _materialHeightMeasureRepository = materialHeightMeasureRepository;
        }
        public void Add(MaterialDTO entitiy)
        {
            var materialMapper = _mapper.Map<Materials>(entitiy);
            var RawMaterial = _mapper.Map<List<RawMaterials>>(entitiy.rawMaterialDTOs);
            var MaterialRawMaterialMapper = _mapper.Map<List<MaterialRawMaterials>>(entitiy.materialRawMaterial);
            var MaterialSupplier = _mapper.Map<List<MaterialSuppliers>>(entitiy.materialSupplierDTOs);
            
            var MaterialEntity = _materialRepository.Add(materialMapper);
            _unitOfWork.SaveChanges();

            List<MaterialRawMaterials> materialRawMaterials = new List<MaterialRawMaterials>();
            foreach (var item in MaterialRawMaterialMapper)
            {
                materialRawMaterials.Add(new MaterialRawMaterials()
                {
                    MaterialId = MaterialEntity.Id,
                    CreateDate = item.CreateDate,
                    RawMaterialId = item.RawMaterialId,
                    UpdateDate = item.UpdateDate,
                    Status=1
                });
            }
            _materialRawMaterialReposiyory.AddRange(materialRawMaterials);
            _unitOfWork.SaveChanges();
            MaterialUnitsOfMeasures units = new MaterialUnitsOfMeasures()
            {
                CreateDate = MaterialEntity.CreateDate,
                MaterialId = MaterialEntity.Id,
                UnitsOfMeasureId = entitiy.UnitsOfMeasureId,
                PurchasingUnitId = entitiy.PurchasingUnitId,
                UpdateDate = MaterialEntity.UpdateDate,
                Status = 1
            };
            _materialUnitsOfMeasuresRepository.Add(units);
            _unitOfWork.SaveChanges();
            List<RawMaterials> rawMaterials = new List<RawMaterials>();
            foreach (var item in RawMaterial)
            {
                rawMaterials.Add(new RawMaterials()
                {
                    Code = item.Code,
                    CreateDate = item.CreateDate,
                    Name = item.Name,
                    UpdateDate = item.UpdateDate,
                    Status=1
                });
            }
            _rawMaterialsRepository.AddRange(rawMaterials);
            _unitOfWork.SaveChanges();
            List<MaterialSuppliers> materialSuppliers = new List<MaterialSuppliers>();
            foreach (var item in MaterialSupplier)
            {
                materialSuppliers.Add(new MaterialSuppliers()
                {
                    CompanyId = item.CompanyId,
                    CreateDate = item.CreateDate,
                    MaterialId = MaterialEntity.Id,
                    Status = item.Status,
                    UpdateDate = item.UpdateDate,
                   
                });
            }
            _materialSuppliersRepository.AddRange(materialSuppliers);
            _unitOfWork.SaveChanges();
        }

        public bool Delete(int id)
        {
            var result = _materialRepository.GetById(id);
            if (result != null)
            {
                result.Status = 3;
                _materialRepository.Delete(result);
                _unitOfWork.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool deleteCertificate(int id)
        {
            var result = _materialCertificatesRepository.GetById(id);
            if (result != null)
            {
                result.Status = 3;
                _materialCertificatesRepository.Delete(result);
                _unitOfWork.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<MaterialDTO> GetAll(int languageId)
        {
            var result = _materialRepository.GetAllMaterial();
            List<MaterialDTO> materials = new List<MaterialDTO>();
            foreach (var item in result)
            {
                var materialMapper = _mapper.Map<MaterialDTO>(item);
                materialMapper.HeightMeasureDTO = _mapper.Map<HeightMeasureDTO>(item.HeightMeasure);
                materialMapper.CurrenciesDTO = _mapper.Map<CurrenciesDTO>(item.Currencies);
                materialMapper.materialRawMaterial = _mapper.Map<List<MaterialRawMaterialDTO>>(item.MaterialRawMaterials);
                materialMapper.materialSuppliers = _mapper.Map<List<MaterialSupplierDTO>>(item.MaterialSuppliers);
                materialMapper.materialUnitsOfMeasuresDTOs = _mapper.Map<List<MaterialUnitsOfMeasuresDTO>>(item.MaterialUnitsOfMeasures);
                materialMapper.materialCertificatesDTOs = _mapper.Map<List<MaterialCertificatesDTO>>(item.MaterialCertificates);
                materialMapper.materialExpertDeliverysDTOs = _mapper.Map<List<MaterialExpertDeliverysDTO>>(item.MaterialExpertDeliverys);
                materialMapper.materialStockDTOs = _mapper.Map<List<MaterialStockDTO>>(item.MaterialStock);
                materialMapper.MaterialShape = _mapper.Map<MaterialShapeDTO>(item.MaterialShapes);
                materialMapper.MaterialHeightMeasureDTOs = _mapper.Map<List<MaterialHeightMeasureDTO>>(item.MaterialHeightMeasures);
                materialMapper.materialSupplyRequestsDTOs = _mapper.Map<List<MaterialSupplyRequestsDTO>>(item.MaterialSupplyRequests);
                materials.Add(materialMapper);
            }
            return materials;
            
        }

        public List<MaterialDTO> GetBy(int languageId)
        {
            return _mapper.Map<List<MaterialDTO>>(_materialRepository.GetBy(x => x.Status == 1).ToList());
        }

        public MaterialDTO GetById(int id, int languageId)
        {
            var result = _materialRepository.getByMaterial(id);
            var materialDto = _mapper.Map<MaterialDTO>(result);
            materialDto.CurrenciesDTO = _mapper.Map<CurrenciesDTO>(result.Currencies);
            materialDto.materialRawMaterial = _mapper.Map<List<MaterialRawMaterialDTO>>(result.MaterialRawMaterials);
            materialDto.materialSuppliers = _mapper.Map<List<MaterialSupplierDTO>>(result.MaterialSuppliers);
            materialDto.materialUnitsOfMeasuresDTOs = _mapper.Map<List<MaterialUnitsOfMeasuresDTO>>(result.MaterialUnitsOfMeasures);
            materialDto.materialCertificatesDTOs = _mapper.Map<List<MaterialCertificatesDTO>>(result.MaterialCertificates);
            materialDto.materialExpertDeliverysDTOs = _mapper.Map<List<MaterialExpertDeliverysDTO>>(result.MaterialExpertDeliverys);
            materialDto.materialStockDTOs = _mapper.Map<List<MaterialStockDTO>>(result.MaterialStock);
            materialDto.materialSupplyRequestsDTOs = _mapper.Map<List<MaterialSupplyRequestsDTO>>(result.MaterialSupplyRequests);
            materialDto.MaterialHeightMeasureDTOs = _mapper.Map<List<MaterialHeightMeasureDTO>>(result.MaterialHeightMeasures);
            materialDto.MaterialShape = _mapper.Map<MaterialShapeDTO>(result.MaterialShapes);
            return materialDto;
        }

        public List<MaterialCertificatesDTO> getMaterialCertificate(int id)
        {
            return _mapper.Map<List<MaterialCertificatesDTO>>(_materialRepository.GetByMaterialCettificate(id).ToList());
        }

        public List<MaterialExpertDeliverysDTO> GetExpertDelivery()
        {
            
            var result = _materialExpertDeliverysRepository.GetAllDeliverys();
            List<MaterialExpertDeliverysDTO> MaterialExpertDeliverysDTO = new List<MaterialExpertDeliverysDTO>();
            foreach (var item in result)
            {
                var ExpertMapper = _mapper.Map<MaterialExpertDeliverysDTO>(item);
                ExpertMapper.Materials = _mapper.Map<MaterialDTO>(item.Materials);
                ExpertMapper.Materials.MaterialHeightMeasureDTOs = _mapper.Map<List<MaterialHeightMeasureDTO>>(item.Materials.MaterialHeightMeasures);
                ExpertMapper.Staffs = _mapper.Map<StaffDTO>(item.Staffs);
                MaterialExpertDeliverysDTO.Add(ExpertMapper);
            }
            return MaterialExpertDeliverysDTO;
        }

        public void SaveCertificate(MaterialCertificatesDTO material)
        {
            var materialCertificate = _mapper.Map<MaterialCertificates>(material);
            var certificate = _materialCertificatesRepository.Add(materialCertificate);
            _unitOfWork.SaveChanges();
        }

        public bool Update(MaterialDTO entitiy)
        {
            var materialMapper = _mapper.Map<Materials>(entitiy);
            var materialRawMaterialMapper = _mapper.Map<List<MaterialRawMaterials>>(entitiy.materialRawMaterial);
            var materialSupperlierMapper = _mapper.Map<List<MaterialSuppliers>>(entitiy.materialSupplierDTOs);
            var materialHeightOfMeasureMapper = _mapper.Map<List<MaterialHeightMeasure>>(entitiy.MaterialHeightMeasureDTOs);
            var material = _materialRepository.Update(materialMapper);
            if (material != null)
            {
                _unitOfWork.SaveChanges();
                if (materialRawMaterialMapper != null)
                {
                    var materialRawMaterial = _materialRawMaterialReposiyory.GetBy(x => x.MaterialId == entitiy.Id).ToList();
                    _materialRawMaterialReposiyory.DeleteRange(materialRawMaterial);
                    List<MaterialRawMaterials> materialRawMaterials = new List<MaterialRawMaterials>();
                    foreach (var item in materialRawMaterialMapper)
                    {
                        materialRawMaterials.Add(new MaterialRawMaterials()
                        {
                            CreateDate = DateTime.Now,
                            MaterialId = entitiy.Id,
                            RawMaterialId = item.RawMaterialId,
                            UpdateDate = DateTime.Now,
                            Status = 1
                        });
                    }
                    _materialRawMaterialReposiyory.AddRange(materialRawMaterials);
                    _unitOfWork.SaveChanges();
                }
                
                if (materialSupperlierMapper != null)
                {
                    var supperlierDelete = _materialSuppliersRepository.GetBy(x => x.MaterialId == entitiy.Id).ToList();
                    _materialSuppliersRepository.DeleteRange(supperlierDelete);
                    List<MaterialSuppliers> materialSuppliers = new List<MaterialSuppliers>();
                    foreach (var item in materialSupperlierMapper)
                    {
                        materialSuppliers.Add(new MaterialSuppliers()
                        {
                            CompanyId = item.CompanyId,
                            CreateDate = DateTime.Now,
                            MaterialId = entitiy.Id,
                            Status = 1,
                            UpdateDate = DateTime.Now
                        });
                    }
                    _materialSuppliersRepository.AddRange(materialSuppliers);
                    _unitOfWork.SaveChanges();
                }
                if (entitiy.PurchasingUnitId != null)
                {
                    var unitsget = _materialUnitsOfMeasuresRepository.GetBy(x => x.MaterialId == entitiy.Id).ToList();
                     _materialUnitsOfMeasuresRepository.DeleteRange(unitsget);
                    MaterialUnitsOfMeasures units = new MaterialUnitsOfMeasures()
                    {
                        CreateDate = material.CreateDate,
                        MaterialId = material.Id,
                        UnitsOfMeasureId = entitiy.UnitsOfMeasureId,
                        PurchasingUnitId = entitiy.PurchasingUnitId,
                        UpdateDate = material.UpdateDate,
                        Status = 1
                    };
                    _materialUnitsOfMeasuresRepository.Add(units);
                    _unitOfWork.SaveChanges();
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