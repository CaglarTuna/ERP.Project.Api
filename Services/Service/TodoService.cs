using AutoMapper;
using Core;
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
    public class TodoService : ITodoService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ITodoListRepository _todoRepository;
        private readonly ITodoMemberRepository _todoMemberRepository;

        public TodoService(ITodoListRepository todoRepository, IMapper mapper, IUnitOfWork unitOfWork, ITodoMemberRepository todoMemberRepository)
        {
            _todoRepository = todoRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _todoMemberRepository = todoMemberRepository;
        }

        public void Add(TodoDto entitiy)
        {
            var todoMapper = _mapper.Map<TodoList>(entitiy);
            var todoEntity = _todoRepository.Add(todoMapper);
            _unitOfWork.SaveChanges();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<TodoDto> GetAll(int languageId)
        {
            return _mapper.Map<List<TodoDto>>(_todoRepository.GetAll());
        }

        public List<TodoDto> GetBy(int languageId)
        {
            throw new NotImplementedException();
        }

        public TodoDto GetById(int id, int languageId)
        {
            throw new NotImplementedException();
        }

        public bool Update(TodoDto entitiy)
        {
            var update = _mapper.Map<TodoList>(entitiy);
            var updateValue = _todoRepository.Update(update);
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
