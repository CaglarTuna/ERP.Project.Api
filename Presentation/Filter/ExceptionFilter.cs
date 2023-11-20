using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Filter
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        public ExceptionFilter(string message)
        {

        }
        public override void OnException(ExceptionContext context)
        {
            var controllerActionDescriptor = context.ActionDescriptor as ControllerActionDescriptor;

            //exception oluşan metotun namespace bilgisi 
            var methodDescriptor = string.Format("{0} - {1} - {2}", controllerActionDescriptor.MethodInfo.ReflectedType.Namespace,
                controllerActionDescriptor.MethodInfo.ReflectedType.Name,
                controllerActionDescriptor.MethodInfo.Name);
            context.Result = new BadRequestObjectResult(methodDescriptor + "\n message : " + context.Exception.Message);

            var LogTxt = @"Filter\ExceptionLog.txt";
            using (System.IO.StreamWriter logTxt = new System.IO.StreamWriter(LogTxt, true))
                logTxt.WriteLine(methodDescriptor + " " + DateTime.Now);
        }
    }
}
