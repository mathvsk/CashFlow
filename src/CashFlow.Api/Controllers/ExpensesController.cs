using CashFlow.Appilcation.UseCases.Expenses.Register;
using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;
using CashFlow.Exception.ExceptionsBase;
using Microsoft.AspNetCore.Mvc;

namespace CashFlow.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExpensesController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] RequestRegisterExpenseJson request)
    {
        try
        {
            var useCase = new RegisterExpanseUseCase();
            var response = useCase.Execute(request);

            return Created(string.Empty, response);

        }
        catch (ErrorOnValidationException ex)
        {
            return BadRequest(new ResponseErrorJson(ex.Erros));
            throw;
        }
        catch
        {
            return StatusCode(StatusCodes.Status500InternalServerError, new ResponseErrorJson("unknow error"));
        }
    }
}
