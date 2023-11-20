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
    public class StaffProcessService : IStaffProcessService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IStaffProcessRepository _staffProcessRepository;

        public StaffProcessService(IUnitOfWork unitOfWork, IMapper mapper, IStaffProcessRepository staffProcessRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _staffProcessRepository = staffProcessRepository;
        }

        public void Add(StaffProcessDTO entitiy)
        {
            var staffProccess = _mapper.Map<StaffProcess>(entitiy);
            var staffProccessEntity = _staffProcessRepository.Add(staffProccess);
            _unitOfWork.SaveChanges();
        }

        public void AddStaffProccess(List<StaffProcessDTO> entity)
        {
            var staffProccess = _mapper.Map<List<StaffProcess>>(entity);
            foreach (var item in staffProccess)
            {
                item.Status = 1;
                var staffProccessEntity = _staffProcessRepository.Add(item);
            }
            _unitOfWork.SaveChanges();
        }

        public bool Delete(int id)
        {
            var result = _staffProcessRepository.GetById(id);
            if (result != null)
            {
                result.Status = 3;
                _staffProcessRepository.Update(result);
                _unitOfWork.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<StaffProcessDTO> GetAll(int languageId)
        {
            return _mapper.Map<List<StaffProcessDTO>>(_staffProcessRepository.GetAll().ToList());
        }

        public List<StaffProcessDTO> GetBy(int languageId)
        {
            return _mapper.Map<List<StaffProcessDTO>>(_staffProcessRepository.GetBy(x => x.Status == 1).ToList());
        }

        public List<StaffProcessDTO> GetBy(int ProductId, int OrderProductId)
        {
            var result = _staffProcessRepository.GetByStaffProccess(ProductId, OrderProductId).AsEnumerable();
            List<StaffProcessDTO> staffProcesses = new List<StaffProcessDTO>();
            foreach (var item in result)
            {
                var StaffProccessMapper = _mapper.Map<StaffProcessDTO>(item);
                StaffProccessMapper.ProductDTO = _mapper.Map<ProductDTO>(item.Products);
                StaffProccessMapper.Orders = _mapper.Map<OrderProductDTO>(item.Orders);
                StaffProccessMapper.ProcessDTO = _mapper.Map<ProcessDTO>(item.Process);
                StaffProccessMapper.ProcessDTO.ProcessLanguage = _mapper.Map<List<ProcessLanguageDTO>>(item.Process.ProcessLanguage);
                StaffProccessMapper.StaffDTO = _mapper.Map<StaffDTO>(item.Staffs);
                staffProcesses.Add(StaffProccessMapper);
            }
            return staffProcesses;
        }

        public StaffProcessDTO GetById(int id, int languageId)
        {
            return _mapper.Map<StaffProcessDTO>(_staffProcessRepository.GetById(id));
        }

        public List<StaffProcessDTO> GetByStaffId(int id)
        {
            var result = _staffProcessRepository.GetByIdStaffProccess(id).AsEnumerable();
            List<StaffProcessDTO> staffProcesses = new List<StaffProcessDTO>();
            foreach (var item in result)
            {
                var StaffProccessMapper = _mapper.Map<StaffProcessDTO>(item);
                StaffProccessMapper.ProductDTO = _mapper.Map<ProductDTO>(item.Products);
                StaffProccessMapper.Orders = _mapper.Map<OrderProductDTO>(item.Orders);
                StaffProccessMapper.ProcessDTO = _mapper.Map<ProcessDTO>(item.Process);
                StaffProccessMapper.ProcessDTO.ProcessLanguage = _mapper.Map<List<ProcessLanguageDTO>>(item.Process.ProcessLanguage);
                StaffProccessMapper.StaffDTO = _mapper.Map<StaffDTO>(item.Staffs);
                staffProcesses.Add(StaffProccessMapper);
            }
            return staffProcesses;
        }

        public bool Update(StaffProcessDTO entitiy)
        {
            var data = _mapper.Map<StaffProcess>(entitiy);
            var updatedvalue = _staffProcessRepository.Update(data);
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

        public bool UpdateStaffProccess(List<StaffProcessDTO> entity)
        {
            var data = _mapper.Map<List<StaffProcess>>(entity);
            var updateValue = _staffProcessRepository.UpdateRange(data);
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
    }
}