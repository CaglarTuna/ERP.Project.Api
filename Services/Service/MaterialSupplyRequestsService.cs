
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
    public class MaterialSupplyRequestsService : IMaterialSupplyRequestsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IMaterialSupplyRequestsRepository _materialSupplyRequestsRepository;
        public MaterialSupplyRequestsService(IUnitOfWork unitOfWork, IMapper mapper, IMaterialSupplyRequestsRepository materialSupplyRequestsRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _materialSupplyRequestsRepository = materialSupplyRequestsRepository;
        }


        public void Add(MaterialSupplyRequestsDTO entitiy)
        {
            var suppelyMapper = _mapper.Map<MaterialSupplyRequests>(entitiy);
            var supplyEntity = _materialSupplyRequestsRepository.Add(suppelyMapper);
            _unitOfWork.SaveChanges();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<MaterialSupplyRequestsDTO> GetAll(int languageId)
        {
            var result = _materialSupplyRequestsRepository.GetMaterialSupplyRequest();
            List<MaterialSupplyRequestsDTO> materialSupplyRequests = new List<MaterialSupplyRequestsDTO>();
            foreach (var item in result)
            {
                var mapper = _mapper.Map<MaterialSupplyRequestsDTO>(item);
                mapper.Materials = _mapper.Map<MaterialDTO>(item.Materials);
                mapper.Orders = _mapper.Map<OrderDTO>(item.Orders);
                mapper.Companies = _mapper.Map<CompanyDTO>(item.Companies);
                mapper.MaterialSupplyStatu = _mapper.Map<MaterialSupplyStatuDTO>(item.MaterialSupply);
                materialSupplyRequests.Add(mapper);
            }
            return materialSupplyRequests;
        }

        public List<MaterialSupplyRequestsDTO> GetBy(int languageId)
        {
            throw new NotImplementedException();
        }

        public MaterialSupplyRequestsDTO GetById(int id, int languageId)
        {
            throw new NotImplementedException();
        }

        public void materialSuppliesListAdd(List<MaterialSupplyRequestsDTO> materials)
        {
            var SupplyMapper = _mapper.Map<List<MaterialSupplyRequests>>(materials);
            var SupplyEntity = _materialSupplyRequestsRepository.AddRange(SupplyMapper);
            _unitOfWork.SaveChanges();
        }

        public void materialSupplyRequestReply(List<MaterialSupplyRequestsDTO> materials)
        {
            var supplyMapper = _mapper.Map<List<MaterialSupplyRequests>>(materials);
            var supplyEntity = _materialSupplyRequestsRepository.UpdateRange(supplyMapper);
            _unitOfWork.SaveChanges();
        }

        public bool Update(MaterialSupplyRequestsDTO entitiy)
        {
            throw new NotImplementedException();
        }
    }
}
