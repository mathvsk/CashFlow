using CashFlow.Domain.Entities;
using CashFlow.Domain.Repositories.Expenses;

namespace CashFlow.Infrastructure.DataAccess.Repositories;

internal class ExpensesRepository : IExpensesRepository
{
    private readonly CashFlowDbContext _dbContext;
    public ExpensesRepository(CashFlowDbContext dbContext)
    {
        this._dbContext = dbContext;
    }

    public void Add(Expense expense)
    {
        this._dbContext.Expenses.Add(expense);
        this._dbContext.SaveChanges();
    }
}
