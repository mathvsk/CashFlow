using CashFlow.Communication.Responses;

namespace CashFlow.Appilcation.UseCases.Expenses.GetAll;

public interface IGetExpensesUseCase
{
    Task<ResponseExpensesJson> Execute();
}
