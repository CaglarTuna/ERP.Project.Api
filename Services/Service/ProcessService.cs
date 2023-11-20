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
    public class ProcessService : IProcessService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IProcessRepository _IProcessRepository;  //Core Katmanı
        private readonly IProcessLanguageRepository _IProcessLanguageRepository;
        

        public ProcessService(IUnitOfWork unitOfWork, IMapper mapper, IProcessRepository iProcessRepository, IProcessLanguageRepository iProcessLanguageRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _IProcessRepository = iProcessRepository;
            _IProcessLanguageRepository = iProcessLanguageRepository;
        }

        public void Add(ProcessDTO entitiy)
        {
            var processMapper = _mapper.Map<Process>(entitiy);
            processMapper.Status = 1;
            var processEntitiy = _IProcessRepository.Add(processMapper);
            _unitOfWork.SaveChanges();

            ProcessLanguage process = new ProcessLanguage()
            {
                Name=entitiy.Name,
                CreateDate=DateTime.Now,
                UpdateDate=DateTime.Now,
                ProcessId=processEntitiy.Id,
                Status=1,
                LanguageId=1
            };
            _IProcessLanguageRepository.Add(process);
            _unitOfWork.SaveChanges();
        }

        public bool Delete(int id)
        {
            var result = _IProcessRepository.GetById(id);
            if (result != null)
            {
                result.Status = 2;
                _IProcessRepository.Update(result);
                _unitOfWork.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<ProcessDTO> GetAll(int languageId)
        {
            return _mapper.Map<List<ProcessDTO>>(_IProcessRepository.GetAllWithProcessLanguage(languageId).ToList());
        }

        public List<ProcessDTO> GetBy(int languageId)
        {
            return _mapper.Map<List<ProcessDTO>>(_IProcessRepository.GetBy(x => x.Status == 1).ToList());
        }

        public ProcessDTO GetById(int id, int languageId)
        {
            return _mapper.Map<ProcessDTO>(_IProcessRepository.GetWithByIdProcessLanguage(languageId, id).FirstOrDefault());
        }

        public bool Update(ProcessDTO entitiy)
        {
            var data = _mapper.Map<Process>(entitiy);
            var updatedvalue = _IProcessRepository.Update(data);
            if (updatedvalue != null)
            {
                _unitOfWork.SaveChanges();
                var proccesLanguage = _mapper.Map<ProcessDTO>(_IProcessRepository.GetWithByIdProcessLanguage(1, data.Id).FirstOrDefault());
                proccesLanguage.ProcessLanguage.FirstOrDefault().Name = entitiy.Name;
                var processLanguageMapper = _mapper.Map<List<ProcessLanguage>>(proccesLanguage.ProcessLanguage);
                var updatevalue = _IProcessLanguageRepository.UpdateRange(processLanguageMapper);
                if (updatevalue != null)
                {
                    _unitOfWork.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}