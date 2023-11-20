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
    public class MeetingRecordService : IMeetingRecordService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IMeetingRecordRepository _meetingRecordRepository;

        public MeetingRecordService(IUnitOfWork unitOfWork, IMapper mapper, IMeetingRecordRepository meetingRecordRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _meetingRecordRepository = meetingRecordRepository;
        }

        public void Add(MeetingRecordDTO entitiy)
        {
            var meetingRecordMapper = _mapper.Map<MeetingRecord>(entitiy);
            var meetingEntity = _meetingRecordRepository.Add(meetingRecordMapper);
            _unitOfWork.SaveChanges();
        }

        public bool Delete(int id)
        {
            var result = _meetingRecordRepository.GetById(id);
            if (result != null)
            {
                result.Status = 3;
                _meetingRecordRepository.Update(result);
                _unitOfWork.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<MeetingRecordDTO> GetAll(int languageId)
        {
            return _mapper.Map<List<MeetingRecordDTO>>(_meetingRecordRepository.GetAll().ToList());
        }

        public List<MeetingRecordDTO> GetBy(int languageId)
        {
            return _mapper.Map<List<MeetingRecordDTO>>(_meetingRecordRepository.GetBy(x => x.Status == 1).ToList());
        }

        public MeetingRecordDTO GetById(int id, int languageId)
        {
            return _mapper.Map<MeetingRecordDTO>(_meetingRecordRepository.GetById(id));
        }

        public bool Update(MeetingRecordDTO entitiy)
        {
            var data = _mapper.Map<MeetingRecord>(entitiy);
            var updatedvalue = _meetingRecordRepository.Update(data);
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
