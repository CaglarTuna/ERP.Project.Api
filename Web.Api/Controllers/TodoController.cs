using DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Filters;

namespace Web.Api.Controllers
{
    [ExceptionFilter("")]
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : Controller
    {
        ITodoService _todoService;
        ITodoMemberService _todoMemberService;

        public TodoController(ITodoMemberService todoMemberService, ITodoService todoService)
        {
            _todoMemberService = todoMemberService;
            _todoService = todoService;
        }
        [HttpGet("TodoList")]
        public JsonResult ListTodo()
        {
            var result = _todoService.GetAll(1);
            var model = new ResultDTO<TodoDto>()
            {
                Statu = true,
                DataList = result,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpGet("TodoMemberList")]
        public JsonResult TodoMemberList()
        {
            var result = _todoMemberService.GetAll(1);
            var model = new ResultDTO<TodoMemberDto>()
            {
                DataList = result,
                Message = "Success",
                Statu = true
            };
            return Json(model);
        }
        [HttpPost("SaveTodo")]
        public JsonResult SaveTodo(TodoDto todoDto)
        {
            _todoService.Add(todoDto);
            var model = new ResultDTO<TodoDto>()
            {
                Message = "Success",
                Statu = true
            };
            return Json(model);
        }
        [HttpPost("SaveTodoMember")]
        public JsonResult SaveTodoMember(List<TodoMemberDto> todoMembers)
        {
            _todoMemberService.SaveTodoMember(todoMembers);
            var model = new ResultDTO<TodoMemberDto>()
            {
                Message = "Success",
                Statu = true
            };
            return Json(model);
        }
    }
}
