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
    public class StoreService : IStoreService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IStoresRepository _IStoreRepository; //Core Katmanı

        public StoreService(IUnitOfWork unitOfWork, IMapper mapper, IStoresRepository iStoreRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _IStoreRepository = iStoreRepository;
        }

        public void Add(StoreDTO entitiy)
        {
            var storeMapper = _mapper.Map<Stores>(entitiy);
            var storeEntitiy = _IStoreRepository.Add(storeMapper);
            _unitOfWork.SaveChanges();
        }

        public bool Delete(int id)
        {
            var result = _IStoreRepository.GetById(id);
            if (result != null)
            {
                result.Status = 3;
                _IStoreRepository.Delete(result);
                _unitOfWork.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<StoreDTO> GetAll(int languageId)
        {
            return _mapper.Map<List<StoreDTO>>(_IStoreRepository.GetAllWithStore().ToList());
        }

        public List<StoreDTO> GetBy(int languageId)
        {
            return _mapper.Map<List<StoreDTO>>(_IStoreRepository.GetBy(x => x.Status == 1).ToList());
        }

        public StoreDTO GetById(int id, int languageId)
        {
            return _mapper.Map<StoreDTO>(_IStoreRepository.GetById(id));
        }

        public bool Update(StoreDTO entitiy)
        {
            var data = _mapper.Map<Stores>(entitiy);
            var updatedvalue = _IStoreRepository.Update(data);
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