using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace WFClassic.Web.Logic.Middleware
{
    public class WFClassicProblemDetailsFactory : ProblemDetailsFactory
    {
        public override ProblemDetails CreateProblemDetails(HttpContext httpContext, int? statusCode = null, string title = null, string type = null, string detail = null, string instance = null)
        {
            ProblemDetails details = new ProblemDetails()
            {
                Title = title,
                Status = statusCode,
                Type = type,
                Detail = detail,
                Extensions = {
                    { "path",   httpContext.Request!=null?  httpContext.Request.Path :"" } ,
                    { "traceIdentifier",  httpContext.TraceIdentifier!=null?  httpContext.TraceIdentifier :""    } ,
                    { "queryString",  httpContext.Request!=null  ? httpContext.Request.QueryString.Value :"" } ,
                },
                Instance = instance,

            };

            return details; 
        }

        public override ValidationProblemDetails CreateValidationProblemDetails(HttpContext httpContext, ModelStateDictionary modelStateDictionary, int? statusCode = null, string title = null, string type = null, string detail = null, string instance = null)
        {
            ValidationProblemDetails details = new ValidationProblemDetails()
            {
                Title = title,
                Status = statusCode,
                Type = type,
                Detail = detail,
                Extensions = {
                    { "path",   httpContext.Request!=null?  httpContext.Request.Path :"" } ,
                    { "traceIdentifier",  httpContext.TraceIdentifier!=null?  httpContext.TraceIdentifier :""    } ,
                    { "queryString",  httpContext.Request!=null  ? httpContext.Request.QueryString.Value :"" } ,
                },
                Instance = instance,

            };

            return details;
        }
    }
}
