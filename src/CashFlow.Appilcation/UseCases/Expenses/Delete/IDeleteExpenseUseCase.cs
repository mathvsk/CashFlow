namespace CashFlow.Appilcation.UseCases.Expenses.Delete;

public interface IDeleteExpenseUseCase
{
    Task Execute(long id);
}
