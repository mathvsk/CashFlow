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

    public async Task Add(Expense expense)
    {
        await this._dbContext.Expenses.AddAsync(expense);
    }
}
