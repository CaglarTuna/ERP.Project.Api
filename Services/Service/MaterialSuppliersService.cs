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
    public class MaterialSuppliersService : IMaterialSuppliersService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IMaterialSuppliersRepository _materialSuppliersRepository;

        public MaterialSuppliersService(IMaterialSuppliersRepository materialSuppliersRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _materialSuppliersRepository = materialSuppliersRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public void Add(MaterialSupplierDTO entitiy)
        {
            var supperlierManager = _mapper.Map<MaterialSuppliers>(entitiy);
            supperlierManager.Status = 1;
            var supperlierEntity = _materialSuppliersRepository.Add(supperlierManager);
            _unitOfWork.SaveChanges();
        }

        public bool Delete(int id)
        {
            var result = _materialSuppliersRepository.GetById(id);
            if (result != null)
            {
                result.Status = 3;
                _materialSuppliersRepository.Update(result);
                _unitOfWork.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<MaterialSupplierDTO> GetAll(int languageId)
        {
            return _mapper.Map<List<MaterialSupplierDTO>>(_materialSuppliersRepository.GetAll().ToList());
        }

        public List<MaterialSupplierDTO> GetBy(int languageId)
        {
            return _mapper.Map<List<MaterialSupplierDTO>>(_materialSuppliersRepository.GetBy(x => x.Status == 1).ToList());
        }

        public MaterialSupplierDTO GetById(int id, int languageId)
        {
            return _mapper.Map<MaterialSupplierDTO>(_materialSuppliersRepository.GetById(id));
        }

        public bool Update(MaterialSupplierDTO entitiy)
        {
            var data = _mapper.Map<MaterialSuppliers>(entitiy);
            var updatedvalue=_materialSuppliersRepository.Update(data);
            if (updatedvalue!=null)
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