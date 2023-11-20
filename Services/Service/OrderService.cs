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
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IOrdersRepository _ordersRepository;
        private readonly IOrderProductsRepository _orderProductsRepository;
        private readonly IOrderChannelRepository _orderChannelRepository;
        private readonly IMeetingRecordRepository _meetingReport;
        private readonly ISpeacialProductDescriptionRepository _speacialProductDescriptionRepository;

        public OrderService(IUnitOfWork unitOfWork, IMapper mapper, IOrdersRepository ordersRepository, IOrderProductsRepository orderProductsRepository, IOrderChannelRepository orderChannelRepository, IMeetingRecordRepository meetingReport, ISpeacialProductDescriptionRepository speacialProductDescriptionRepository)
        {
            _unitOfWork = unitOfWork;
            _speacialProductDescriptionRepository = speacialProductDescriptionRepository;
            _mapper = mapper;
            _ordersRepository = ordersRepository;
            _orderProductsRepository = orderProductsRepository;
            _orderChannelRepository = orderChannelRepository;
            _meetingReport = meetingReport;
        }

        public void Add(OrderDTO entitiy)
        {
            var orderMapper = _mapper.Map<Orders>(entitiy);
            var orderEntity = _ordersRepository.Add(orderMapper);
            if (entitiy.speacialProductDescriptions.Count > 0)
            {
                var specialProduct = _mapper.Map<List<SpeacialProductDescription>>(entitiy.speacialProductDescriptions);
                var specialProductEntity = _speacialProductDescriptionRepository.AddRange(specialProduct);
            }
            _unitOfWork.SaveChanges();
            var meetingRecord = _mapper.Map<MeetingRecord>(entitiy.MeetingRecord);
            MeetingRecord meetingRecor = new MeetingRecord();
            meetingRecor = new MeetingRecord()
            {
                CreateDate = meetingRecord.CreateDate,
                MeetingDate = meetingRecord.MeetingDate,
                MeetingNote = meetingRecord.MeetingNote,
                OrderId = orderEntity.Id,
                ReminderDate = meetingRecord.ReminderDate,
                ReminderNote = meetingRecord.ReminderNote,
                Status = 1,
                UpdateDate = meetingRecord.UpdateDate
            };
            _meetingReport.Add(meetingRecor);
            _unitOfWork.SaveChanges();

        }
        public void AddProduction(OrderDTO orderDTO)
        {
            var orderMapper = _mapper.Map<Orders>(orderDTO);
            var specialProduct = _mapper.Map<List<SpeacialProductDescription>>(orderDTO.speacialProductDescriptions);
            var orderProduct = _mapper.Map<List<OrderProducts>>(orderDTO.OrderProducts);
            var orderEntity = _ordersRepository.Add(orderMapper);
            var specialProductEntity = _speacialProductDescriptionRepository.AddRange(specialProduct);
            _unitOfWork.SaveChanges();
        }

        public bool Delete(int id)
        {
            var result = _ordersRepository.GetById(id);
            if (result != null)
            {
                result.Status = 3;
                _ordersRepository.Update(result);
                _unitOfWork.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<OrderDTO> GetAll(int languageId)
        {
            var result = _ordersRepository.GetAllOrder();
            List<OrderDTO> orders = new List<OrderDTO>();
            foreach (var item in result)
            {
                var orderMapper = _mapper.Map<OrderDTO>(item);
                orderMapper.Companies = _mapper.Map<CompanyDTO>(item.Companies);
                orderMapper.Companies.CompanyAddressDTOs = _mapper.Map<List<CompanyAddressDTO>>(item.Companies.CompanyAddress);
                orderMapper.MaterialSupplyRequests = _mapper.Map<List<MaterialSupplyRequestsDTO>>(item.MaterialSupplyRequests);
                orderMapper.Stores = _mapper.Map<StoreDTO>(item.Stores);
                orderMapper.OrderChannel = _mapper.Map<OrderChannelDTO>(item.OrderChannel);
                orderMapper.Offers = _mapper.Map<List<OfferDTO>>(item.Offers);
                orderMapper.MeetingRecords = _mapper.Map<List<MeetingRecordDTO>>(item.MeetingRecords);
                orderMapper.OrderProducts = _mapper.Map<List<OrderProductDTO>>(item.OrderProducts);
                orderMapper.Statuss = _mapper.Map<StatusDTO>(item.Statuss);
                orderMapper.Staff = _mapper.Map<StaffDTO>(item.Staff);
                orders.Add(orderMapper);

            }
            return orders;
        }

        public List<OrderDTO> GetBy(int languageId)
        {
            return _mapper.Map<List<OrderDTO>>(_ordersRepository.GetBy(x => x.Status == 1).ToList());
        }

        public OrderDTO GetById(int id, int languageId)
        {
            return _mapper.Map<OrderDTO>(_ordersRepository.GetById(id));
        }

        public OrderDTO getOrder(int id)
        {
            //return _mapper.Map<OrderDTO>(_ordersRepository.GetByOrderId(id));
            var result = _ordersRepository.GetByOrderId(id);
            if (result != null)
            {
                var orderDto = _mapper.Map<OrderDTO>(result);
                orderDto.MeetingRecords = _mapper.Map<List<MeetingRecordDTO>>(result.MeetingRecords);
                orderDto.Stores = _mapper.Map<StoreDTO>(result.Stores);
                orderDto.Statuss = _mapper.Map<StatusDTO>(result.Statuss);
                orderDto.Staff = _mapper.Map<StaffDTO>(result.Staff);
                orderDto.Companies = _mapper.Map<CompanyDTO>(result.Companies);
                orderDto.Companies.CompanyAddressDTOs = _mapper.Map<List<CompanyAddressDTO>>(result.Companies.CompanyAddress);
                orderDto.OrderChannel = _mapper.Map<OrderChannelDTO>(result.OrderChannel);
                orderDto.MaterialSupplyRequests = _mapper.Map<List<MaterialSupplyRequestsDTO>>(result.MaterialSupplyRequests);
                orderDto.Offers = _mapper.Map<List<OfferDTO>>(result.Offers);
                orderDto.OrderProducts = _mapper.Map<List<OrderProductDTO>>(result.OrderProducts);
                foreach (var item in orderDto.OrderProducts)
                {
                    foreach (var rslt in result.OrderProducts.Where(x=>x.ProductId==item.ProductId))
                    {
                        item.Products = _mapper.Map<ProductDTO>(rslt.Products);
                        item.Products.productMaterialDTOs = _mapper.Map<List<ProductMaterialDTO>>(rslt.Products.ProductMaterials);
                    }
                }
                return orderDto;
            }
            return null;
        }

        public List<OrderDTO> GetOrderProductionList()
        {
            return _mapper.Map<List<OrderDTO>>(_ordersRepository.GetOrderProduction());
            
        }

        public bool OrderConfirmUpdate(OrderDTO order)
        {
            int id = order.Id;
            var orderList = _ordersRepository.GetByOrderId(id);
            OrderDTO orderDTO = new OrderDTO()
            {
                RejectNote = orderList.RejectNote,
                OrderStatuId = 1,
                StoreId = orderList.StoreId,
                CompanyId = orderList.CompanyId,
                OrderChannelId = orderList.OrderChannelId,
                AddressId = orderList.AddressId,
                OrderDate = orderList.OrderDate,
                OrderNote = orderList.OrderNote,
                OrderType = orderList.OrderType,
                OrderNo=orderList.OrderNo,
                OrderFrom = orderList.OrderFrom,
                OrderCustomerNo = orderList.OrderCustomerNo,
                CreateDate = orderList.CreateDate,
                UpdateDate = DateTime.Now,
                Status = 1,
                Deadline = orderList.Deadline,
                Id = orderList.Id,
                OrderStatus=order.OrderStatus
            };
            var data = _mapper.Map<Orders>(orderDTO);
            var updateValue = _ordersRepository.Update(data);
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

        public bool OrderRejectNote(OrderDTO order)
        {
            int id = order.Id;
            var orderList = _ordersRepository.GetByOrderId(id);
            OrderDTO orderDTO = new OrderDTO()
            {
                RejectNote = order.RejectNote,
                OrderStatuId=orderList.OrderStatuId,
                StoreId = orderList.StoreId,
                CompanyId = orderList.CompanyId,
                OrderChannelId = orderList.OrderChannelId,
                AddressId = orderList.AddressId,
                OrderDate = orderList.OrderDate,
                OrderNote = orderList.OrderNote,
                OrderType = orderList.OrderType,
                OrderNo=orderList.OrderNo,
                OrderFrom = orderList.OrderFrom,
                OrderCustomerNo = orderList.OrderCustomerNo,
                CreateDate = orderList.CreateDate,
                UpdateDate = DateTime.Now,
                Status = 1,
                Deadline = orderList.Deadline,
                Id = orderList.Id,
                OrderStatus=3
            };
            var data = _mapper.Map<Orders>(orderDTO);
            var updateValue = _ordersRepository.Update(data);
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

        public bool OrderWaybillUpdate(OrderDTO orderDTO)
        {
            var data = _mapper.Map<Orders>(orderDTO);
            var updateValue = _ordersRepository.Update(data);
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

        public bool Update(OrderDTO entitiy)
        {
            int id = entitiy.Id;
            var orderList = _ordersRepository.GetByOrderId(id);
            OrderDTO orderDTO = new OrderDTO()
            {
                RejectNote = orderList.RejectNote,
                OrderStatuId = 1,
                StoreId = orderList.StoreId,
                CompanyId = orderList.CompanyId,
                OrderChannelId = orderList.OrderChannelId,
                AddressId = orderList.AddressId,
                OrderDate = orderList.OrderDate,
                OrderNote = orderList.OrderNote,
                OrderType = orderList.OrderType,
                OrderNo=orderList.OrderNo,
                OrderFrom = orderList.OrderFrom,
                OrderCustomerNo = orderList.OrderCustomerNo,
                CreateDate = orderList.CreateDate,
                UpdateDate = DateTime.Now,
                Status = 1,
                Deadline = orderList.Deadline,
                Id = orderList.Id,
            };
            var data = _mapper.Map<Orders>(orderDTO);
            var updateValue = _ordersRepository.Update(data);
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