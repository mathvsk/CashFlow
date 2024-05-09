using CashFlow.Communication.Requests;

namespace CashFlow.Appilcation.UseCases.Expenses.Update;

public interface IUpdateExpenseUseCase
{
    Task Execute(long id ,RequestExpenseJson request);
}
