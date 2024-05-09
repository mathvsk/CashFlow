using AutoMapper;
using CashFlow.Communication.Responses;
using CashFlow.Domain.Repositories.Expenses;

namespace CashFlow.Appilcation.UseCases.Expenses.GetAll;

public class GetExpensesUseCase : IGetExpensesUseCase
{
    private readonly IExpensesReadOnlyRepository _repository;
    private readonly IMapper _mapper;
    public GetExpensesUseCase(
        IExpensesReadOnlyRepository repository,
        IMapper mapper)
    {
        this._repository = repository;
        this._mapper = mapper;
    }

    public async Task<ResponseExpensesJson> Execute()
    {
        var result = await this._repository.GetAll();

        return new ResponseExpensesJson
        {
            Expenses = this._mapper.Map<List<ResponseShortExpenseJson>>(result)
        };
    }
}
