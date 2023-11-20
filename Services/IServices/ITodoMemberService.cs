using Core.IServices;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IServices
{
    public interface ITodoMemberService : IService<TodoMemberDto>
    {
        void SaveTodoMember(List<TodoMemberDto> todoMembers);
    }
}
