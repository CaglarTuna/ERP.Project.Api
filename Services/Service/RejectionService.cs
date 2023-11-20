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
    public class RejectionService : IRejectionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IRejectionRepository _rejectionRepository;


        public RejectionService(IUnitOfWork unitOfWork, IMapper mapper, IRejectionRepository rejectionRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _rejectionRepository = rejectionRepository;
        }

        public void Add(RejectionDTO entitiy)
        {
            var rejectionMapper = _mapper.Map<Rejection>(entitiy);
            var rejectionEntity = _rejectionRepository.Add(rejectionMapper);
            _unitOfWork.SaveChanges();
        }

        public bool Delete(int id)
        {
            var result = _rejectionRepository.GetById(id);
            if (result != null)
            {
                result.Status = 3;
                _rejectionRepository.Update(result);
                _unitOfWork.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<RejectionDTO> GetAll(int languageId)
        {
            return _mapper.Map<List<RejectionDTO>>(_rejectionRepository.GetAll().ToList());
        }

        public List<RejectionDTO> GetBy(int languageId)
        {
            return _mapper.Map<List<RejectionDTO>>(_rejectionRepository.GetBy(x => x.Status == 1).ToList());
        }

        public RejectionDTO GetById(int id, int languageId)
        {
            return _mapper.Map<RejectionDTO>(_rejectionRepository.GetById(id));
        }

        public bool Update(RejectionDTO entitiy)
        {
            var data = _mapper.Map<Rejection>(entitiy);
            var updatedvalue = _rejectionRepository.Update(data);
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
