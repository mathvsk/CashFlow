using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;

namespace CashFlow.Appilcation.UseCases.Expenses.Register;

public interface IRegisterExpanseUseCase
{
    Task<ResponseRegisterExpenseJson> Execute(RequestExpenseJson request);
}
