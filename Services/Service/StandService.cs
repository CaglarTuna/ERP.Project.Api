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
    public class StandService : IStandService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IStandsRepository _IstandRepository;
        private readonly IStandProcessRepository _IStandProccessRepository;

        public StandService(IUnitOfWork unitOfWork, IMapper mapper, IStandsRepository standsRepository, IStandProcessRepository standProcessRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _IstandRepository = standsRepository;
            _IStandProccessRepository = standProcessRepository;
        }
        public void Add(StandDTO entitiy)
        {
            var standManager = _mapper.Map<Stands>(entitiy);
            var standProccesMapper = _mapper.Map<List<StandProcess>>(entitiy.StandProcess);
            standManager.Status = 1;
            var standEntity = _IstandRepository.Add(standManager);
            _unitOfWork.SaveChanges();
            //Stand Procces
            List<StandProcess> proccees = new List<StandProcess>();
            foreach (var item in standProccesMapper)
            {
                proccees.Add(new StandProcess()
                {
                    CreateDate = item.CreateDate,
                    ProcessId = item.ProcessId,
                    StandId = standEntity.Id,
                    UpdateDate = item.UpdateDate,
                    Status = 1
                });
            }
            _unitOfWork.SaveChanges();

        }

        public bool Delete(int id)
        {
            var result = _IstandRepository.GetById(id);
            if (result != null)
            {
                result.Status = 3;
                _IstandRepository.Update(result);
                _unitOfWork.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<StandDTO> GetAll(int languageId)
        {
            return _mapper.Map<List<StandDTO>>(_IstandRepository.GetAllStand(languageId).ToList());
        }

        public List<StandDTO> GetBy(int languageId)
        {
            return _mapper.Map<List<StandDTO>>(_IstandRepository.GetBy(x => x.Status == 1).ToList());
        }

        public StandDTO GetById(int id, int languageId)
        {
            return _mapper.Map<StandDTO>(_IstandRepository.getStand(1, id));
        }

        public bool Update(StandDTO entitiy)
        {
            var data = _mapper.Map<Stands>(entitiy);
            var updateValue = _IstandRepository.Update(data);
            var proccesList = _mapper.Map<List<StandProcess>>(entitiy.StandProcess);
            var procces = _IStandProccessRepository.GetBy(x => x.StandId == entitiy.Id).ToList();
            _IStandProccessRepository.DeleteRange(procces);
            List<StandProcess> standProcesses = new List<StandProcess>();
            foreach (var item in proccesList)
            {
                standProcesses.Add(new StandProcess()
                {
                    CreateDate = DateTime.Now,
                    ProcessId = item.ProcessId,
                    StandId = data.Id,
                    Status = 1,
                    UpdateDate = DateTime.Now
                });
            }
            _unitOfWork.SaveChanges();
            return true;
           
        }
    }
}