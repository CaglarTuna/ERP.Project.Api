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
    public class TodoMemberService : ITodoMemberService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ITodoMemberRepository _todoMemberRepository;

        public TodoMemberService(ITodoMemberRepository todoMemberRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _todoMemberRepository = todoMemberRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public void Add(TodoMemberDto entitiy)
        {
            var todoMapper = _mapper.Map<TodoMember>(entitiy);
            var todoEntity = _todoMemberRepository.Add(todoMapper);
            _unitOfWork.SaveChanges();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<TodoMemberDto> GetAll(int languageId)
        {
            return _mapper.Map<List<TodoMemberDto>>(_todoMemberRepository.GetAll());
        }

        public List<TodoMemberDto> GetBy(int languageId)
        {
            throw new NotImplementedException();
        }

        public TodoMemberDto GetById(int id, int languageId)
        {
            throw new NotImplementedException();
        }

        public void SaveTodoMember(List<TodoMemberDto> todoMembers)
        {
            var todoMapper = _mapper.Map<List<TodoMember>>(todoMembers);
            var todoEntity = _todoMemberRepository.AddRange(todoMapper);
            _unitOfWork.SaveChanges();
        }

        public bool Update(TodoMemberDto entitiy)
        {
            var update = _mapper.Map<TodoMember>(entitiy);
            var updateValue = _todoMemberRepository.Update(update);
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
