using AutoMapper;
using Core.IRepository;
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
    public class OrderNeedService : IOrderNeesService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IOrderNeedsRepository _orderNeedRepository;

        public OrderNeedService(IOrderNeedsRepository orderNeedRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _orderNeedRepository = orderNeedRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public void Add(OrderNeedsDto entitiy)
        {
            var needsMapper = _mapper.Map<OrderNeeds>(entitiy);
            var NeedsEntity = _orderNeedRepository.Add(needsMapper);
            _unitOfWork.SaveChanges();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderNeedsDto> GetAll(int languageId)
        {
            return _mapper.Map<List<OrderNeedsDto>>(_orderNeedRepository.GetAll());
        }

        public List<OrderNeedsDto> GetBy(int languageId)
        {
            throw new NotImplementedException();
        }

        public OrderNeedsDto GetById(int id, int languageId)
        {
            throw new NotImplementedException();
        }

        public bool Update(OrderNeedsDto entitiy)
        {
            var data = _mapper.Map<OrderNeeds>(entitiy);
            var UpdateValue = _orderNeedRepository.Update(data);
            if (UpdateValue != null)
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
