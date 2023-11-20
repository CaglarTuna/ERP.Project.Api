using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Presentation.ApiHandlers;
using Presentation.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Common
{
    public class TodoSend
    {
        private readonly IConfiguration _configuration;

        public TodoSend(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        ApiHandler ApiHandler = new ApiHandler();

        public bool TodoSendList(string description, int[] roleId, int orderId, string token)
        {
            string TodoUrl = _configuration["UrlVariable"] + "Todo/SaveTodo";
            var staffRoleList = _configuration["UrlVariable"] + "Staff/list/1";
            var StaffResult = ApiHandler.GetAPI<DataDto<StaffDTO>>(staffRoleList, token);
            List<StaffDTO> staffs = new List<StaffDTO>();
            foreach (var item in StaffResult.dataList)
            {
                foreach (var role in roleId)
                {
                    if (item.StaffRolesDTO.Any(x => x.RoleId == role))
                    {
                        staffs.Add(item);
                        
                    }
                }
            }
            var enes = staffs.Distinct();
            List<TodoMemberDto> todoMember = new List<TodoMemberDto>();
            foreach (var item in enes)
            {
                todoMember.Add(new TodoMemberDto()
                {
                    FlagMember = false,
                    StaffId = item.Id,
                    CreateDate = DateTime.Now,
                    Status = 1,
                    UpdateDate = DateTime.Now
                });
            }
            TodoDto todo = new TodoDto()
            {
                CreateDate = DateTime.Now,
                Description = description,
                Flag = false,
                InterestId = orderId,
                Status = 1,
                UpdateDate = DateTime.Now,
                TodoMembers = todoMember
            };
            var SaveTodo = ApiHandler.PostAPIWithModel<DataDto<TodoDto>>(todo, TodoUrl, token);
            if (SaveTodo.statu == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
