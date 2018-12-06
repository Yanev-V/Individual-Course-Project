using F1Cafe.Data.Models;
using F1Cafe.Common.Exceptions;
using F1Cafe.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using F1Cafe.Common;

namespace F1Cafe.Web.Extensions.Filters
{
    public class GlobalExceptionFilter : ExceptionFilterAttribute
    {
        private readonly F1CafeDbContext dbContext;
        private readonly ITempDataDictionaryFactory tempDataFactory;

        public GlobalExceptionFilter(F1CafeDbContext dbContext,
            ITempDataDictionaryFactory tempDataFactory)
        {
            this.dbContext = dbContext;
            this.tempDataFactory = tempDataFactory;
        }

        public override void OnException(ExceptionContext context)
        {
            var exceptionType = context.Exception.GetType().Name;
            var message = context.Exception.Message;
            var stackTrace = context.Exception.StackTrace;

            var controllerName = string.Empty;
            var actionName = string.Empty;
            var area = string.Empty;
            var page = string.Empty;

            var routeValues = context.RouteData.Values;
            if (routeValues.ContainsKey("controller"))
            {
                controllerName = routeValues["controller"].ToString();
                actionName = routeValues["action"].ToString();
            }
            else if (routeValues.ContainsKey("area"))
            {
                area = routeValues["area"].ToString();
                page = routeValues["page"].ToString();
            }
            
            var user = context.HttpContext.User.Identity.Name ?? GlobalConstants.AnonymousUser;
            var logTime = DateTime.UtcNow;

            var log = new DbExceptionLog
            {
                ExeptionType = exceptionType,
                Message = message,
                StackTrace = stackTrace,
                Area = area,
                Page = page,
                Controller = controllerName,
                Action = actionName,
                User = user,
                LogTime = logTime
            };

            this.dbContext.DbExceptionLogs.Add(log);
            this.dbContext.SaveChanges();            

            var tempData = tempDataFactory.GetTempData(context.HttpContext);

            if (context.Exception is F1CafeBaseException)
            {
                tempData.Add(GlobalConstants.ErrorMessage, context.Exception.Message);
            }

            context.ExceptionHandled = true;

            context.Result = new RedirectResult(GlobalConstants.HomeErrorRoute);
        }
    }
}
