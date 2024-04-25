﻿using CashFlow.Communication.Responses;
using CashFlow.Exception.ExceptionsBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CashFlow.Api.Filters;

public class ExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        if (context.Exception is CashFlowException) {
            HandleProjectException(context);
        } else
        {
            ThrowUnknowError(context);
        } 

    }

    private void HandleProjectException(ExceptionContext context)
    {
        if (context.Exception is ErrorOnValidationException)
        {
            var ex = context.Exception as ErrorOnValidationException;

            var errorsResponse = new ResponseErrorJson(ex!.Erros);

            context.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            context.Result = new ObjectResult(errorsResponse);
        }
    }

    private void ThrowUnknowError(ExceptionContext context)
    {
        var errorResponse = new ResponseErrorJson("Unknow error");

        context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
        context.Result = new ObjectResult(errorResponse);
    }
}
