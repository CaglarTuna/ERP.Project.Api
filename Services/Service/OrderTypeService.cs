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
    public class OrderTypeService : IOrderTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IOrderTypeRepository _orderTypeRepository;

        public OrderTypeService(IUnitOfWork unitOfWork, IMapper mapper, IOrderTypeRepository orderTypeRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _orderTypeRepository = orderTypeRepository;
        }

        public void Add(OrderTypeDTO entitiy)
        {
            var orderTypeMapper = _mapper.Map<OrderType>(entitiy);
            var orderTypeEntity = _orderTypeRepository.Add(orderTypeMapper);
            _unitOfWork.SaveChanges();
        }

        public bool Delete(int id)
        {
            var result = _orderTypeRepository.GetById(id);
            if (result != null)
            {
                result.Status = 3;
                _orderTypeRepository.Update(result);
                _unitOfWork.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<OrderTypeDTO> GetAll(int languageId)
        {
            return _mapper.Map<List<OrderTypeDTO>>(_orderTypeRepository.GetAll().ToList());
        }

        public List<OrderTypeDTO> GetBy(int languageId)
        {
            return _mapper.Map<List<OrderTypeDTO>>(_orderTypeRepository.GetBy(x => x.Status == 1).ToList());
        }

        public OrderTypeDTO GetById(int id, int languageId)
        {
            return _mapper.Map<OrderTypeDTO>(_orderTypeRepository.GetById(id));
        }

        public bool Update(OrderTypeDTO entitiy)
        {
            var data = _mapper.Map<OrderType>(entitiy);
            var updatedvalue = _orderTypeRepository.Update(data);
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