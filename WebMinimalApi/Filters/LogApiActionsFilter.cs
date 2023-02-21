using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;
using System.Web.Http.Controllers;

namespace WebMinimalApi.Filters
{
    public class LogApiActionsFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext actionContext)
        {
            Trace.WriteLine(string.Format("Action Method {0} executing at {1}", actionContext.ActionDescriptor, DateTime.Now.ToShortDateString()), "Web API Logs");
        }

        public override void OnActionExecuted(ActionExecutedContext actionContext)
        {
            Trace.WriteLine(string.Format("Action Method {0} executed at {1}", actionContext.ActionDescriptor.DisplayName, DateTime.Now.ToShortDateString()), "Web API Logs");
        }

        public override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            return base.OnActionExecutionAsync(context, next);
        }
    }
}
