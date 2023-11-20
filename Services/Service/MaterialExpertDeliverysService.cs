using AutoMapper;
using Core;
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
    public class MaterialExpertDeliverysService : IMaterialExpertDeliverys
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IMaterialExpertDeliverysRepository _materialExpertDeliverys;
        public MaterialExpertDeliverysService(IUnitOfWork unitOfWork, IMapper mapper, IMaterialExpertDeliverysRepository materialExpertDeliverys)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _materialExpertDeliverys = materialExpertDeliverys;
        }

        public void Add(MaterialExpertDeliverysDTO entitiy)
        {
            var expertMapper = _mapper.Map<MaterialExpertDeliverys>(entitiy);
            var entity = _materialExpertDeliverys.Add(expertMapper);
            _unitOfWork.SaveChanges();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<MaterialExpertDeliverysDTO> GetAll(int languageId)
        {
            throw new NotImplementedException();
        }

        public List<MaterialExpertDeliverysDTO> GetBy(int languageId)
        {
            throw new NotImplementedException();
        }

        public MaterialExpertDeliverysDTO GetById(int id, int languageId)
        {
            throw new NotImplementedException();
        }

        public bool Update(MaterialExpertDeliverysDTO entitiy)
        {
            throw new NotImplementedException();
        }
    }
}
