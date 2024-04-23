using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;

namespace CashFlow.Appilcation.UseCases.Expenses.Register;

public class RegisterExpanseUseCase
{
    public ResponseRegisterExpenseJson Execute(RequestRegisterExpenseJson request)
    {
        return new ResponseRegisterExpenseJson();
    }
}
