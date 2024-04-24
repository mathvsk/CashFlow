using CashFlow.Communication.Enums;
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
        var titleIsEmpty = string.IsNullOrWhiteSpace(request.Title);
        if (titleIsEmpty)
        {
            throw new ArgumentException("Title is required");
        }

        if (request.Amount <= 0)
        {
            throw new ArgumentException("Value must be greater than zero");
        }

        var result = DateTime.Compare(request.Date, DateTime.UtcNow);
        if (result > 0)
        {
            throw new ArgumentException("Date cannot be greater than the current date");
        }

        var paymentTypeIsValida = Enum.IsDefined(typeof(PaymentType), request.PaymentType);
        if (!paymentTypeIsValida)
        {
            throw new ArgumentException("Invalid payment type");
        }
    }
}
