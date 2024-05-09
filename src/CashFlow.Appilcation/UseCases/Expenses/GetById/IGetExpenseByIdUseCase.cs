using CashFlow.Communication.Responses;

namespace CashFlow.Appilcation.UseCases.Expenses.GetById;

public interface IGetExpenseByIdUseCase
{
    Task<ResponseExpenseJson> Execute(long id);
}
