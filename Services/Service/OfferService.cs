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
    public class OfferService : IOfferService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IOffersRepository _offersRepository;

        public OfferService(IUnitOfWork unitOfWork, IMapper mapper, IOffersRepository offersRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _offersRepository = offersRepository;
        }

        public void Add(OfferDTO entitiy)
        {
            var offerMapper = _mapper.Map<List<Offers>>(entitiy);
            var offerEntity = _offersRepository.AddRange(offerMapper);
            _unitOfWork.SaveChanges();
        }

        public bool Delete(int id)
        {
            var result = _offersRepository.GetById(id);
            if (result != null)
            {
                result.Status = 3;
                _offersRepository.Update(result);
                _unitOfWork.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<OfferDTO> GetAll(int languageId)
        {
            return _mapper.Map<List<OfferDTO>>(_offersRepository.GetAllOffer().ToList());
        }

        public List<OfferDTO> GetBy(int languageId)
        {
            return _mapper.Map<List<OfferDTO>>(_offersRepository.GetBy(x => x.Status == 1).ToList());
        }

        public OfferDTO GetById(int id, int languageId)
        {
            return _mapper.Map<OfferDTO>(_offersRepository.GetById(id));
        }

        public OfferDTO getLastOffer(int id)
        {
            return _mapper.Map<OfferDTO>(_offersRepository.getLastOffers(id));
        }

        public void listOfferAdd(List<OfferDTO> offers)
        {
            var offerMapper = _mapper.Map<List<Offers>>(offers);
            var offerEntity = _offersRepository.AddRange(offerMapper);
            _unitOfWork.SaveChanges();
        }

        public bool Update(OfferDTO entitiy)
        {
            int id = (int)entitiy.OrderId;
            var offerList = _offersRepository.GetAllOffer().Where(x=>x.OrderId==id).OrderByDescending(x => x.Id).FirstOrDefault();
            
            
                OfferDTO offerDTO = new OfferDTO()
                {
                    CreateDate = offerList.CreateDate,
                    CurrencyId = offerList.CurrencyId,
                    CustomerReply = entitiy.CustomerReply,
                    FinishDate = offerList.FinishDate,
                    Kdv= offerList.Kdv,
                    LineOfferAmount= offerList.LineOfferAmount,
                    OfferStatuId= entitiy.OfferStatuId,
                    OrderId= offerList.OrderId,
                    PaymentTerm= offerList.PaymentTerm,
                    ProductId= offerList.ProductId,
                    Quantitiy= offerList.Quantitiy,
                    Status=1,
                    TotalCost= offerList.TotalCost,
                    UnitCost= offerList.UnitCost,
                    UnitOfferAmount= offerList.UnitOfferAmount,
                    UpdateDate=DateTime.Now,
                    Id= offerList.Id
                };
                
            var data = _mapper.Map<Offers>(offerDTO);
            var updatedvalue = _offersRepository.Update(data);
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