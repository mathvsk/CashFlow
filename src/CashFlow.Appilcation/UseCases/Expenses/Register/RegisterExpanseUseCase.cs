using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;

namespace CashFlow.Appilcation.UseCases.Expenses.Register;

public class RegisterExpanseUseCase
{
    public ResponseRegisterExpenseJson Execute(RequestRegisterExpenseJson request)
    {
        Validate(request);
        return new ResponseRegisterExpenseJson();
    }

    private void Validate(RequestRegisterExpenseJson request)
    {
        var validator = new RegisterExpanseValidator();
        var result = validator.Validate(request);

        if (result.IsValid)
        {
            return;
        }

        var errorMessages = result.Errors.Select(error => error.ErrorMessage).ToList();

        throw new ArgumentException();        
    }
}
