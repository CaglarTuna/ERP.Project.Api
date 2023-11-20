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
    public class OrderChannelService : IOrderChannelService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IOrderChannelRepository _orderChannelRepository;

        public OrderChannelService(IUnitOfWork unitOfWork, IMapper mapper, IOrderChannelRepository orderChannelRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _orderChannelRepository = orderChannelRepository;
        }

        public void Add(OrderChannelDTO entitiy)
        {
            var orderChannelMapper = _mapper.Map<OrderChannel>(entitiy);
            var orderChannelEntity = _orderChannelRepository.Add(orderChannelMapper);
            _unitOfWork.SaveChanges();
        }

        public bool Delete(int id)
        {
            var result = _orderChannelRepository.GetById(id);
            if (result != null)
            {
                result.Status = 3;
                _orderChannelRepository.Update(result);
                _unitOfWork.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<OrderChannelDTO> GetAll(int languageId)
        {
            return _mapper.Map<List<OrderChannelDTO>>(_orderChannelRepository.GetAll().ToList());
        }

        public List<OrderChannelDTO> GetBy(int languageId)
        {
            return _mapper.Map<List<OrderChannelDTO>>(_orderChannelRepository.GetBy(x => x.Status == 1).ToList());
        }

        public OrderChannelDTO GetById(int id, int languageId)
        {
            return _mapper.Map<OrderChannelDTO>(_orderChannelRepository.GetById(id));
        }

        public bool Update(OrderChannelDTO entitiy)
        {
            var data = _mapper.Map<OrderChannel>(entitiy);
            var updatedvalue = _orderChannelRepository.Update(data);
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