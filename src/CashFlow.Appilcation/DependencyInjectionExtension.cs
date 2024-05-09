using CashFlow.Appilcation.AutoMapper;
using CashFlow.Appilcation.UseCases.Expenses.GetAll;
using CashFlow.Appilcation.UseCases.Expenses.GetById;
using CashFlow.Appilcation.UseCases.Expenses.Register;
using Microsoft.Extensions.DependencyInjection;

namespace CashFlow.Appilcation;

public static class DependencyInjectionExtension
{
    public static void AddApplication(this IServiceCollection services)
    {
        AddAutoMapper(services);
        AddUseCases(services);
    }

    private static void AddAutoMapper(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(AutoMapping));
    }

    private static void AddUseCases(IServiceCollection services)
    {
        services.AddScoped<IRegisterExpanseUseCase, RegisterExpanseUseCase>();
        services.AddScoped<IGetExpensesUseCase, GetExpensesUseCase>();
        services.AddScoped<IGetExpenseByIdUseCase, GetExpenseByIdUseCase>();
    }
}
