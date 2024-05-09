using CashFlow.Communication.Requests;
using CashFlow.Exception;
using FluentValidation;

namespace CashFlow.Appilcation.UseCases.Expenses;

public class ExpanseValidator : AbstractValidator<RequestExpenseJson>
{
    public ExpanseValidator()
    {
        RuleFor(expanse => expanse.Title)
            .NotEmpty().WithMessage(ResourceErrorMessages.TITLE_REQUIRED);

        RuleFor(expanse => expanse.Amount)
            .GreaterThan(0).WithMessage(ResourceErrorMessages.AMOUN_MUST_BE_GREATER_THAN_ZERO);

        RuleFor(expanse => expanse.Date)
            .LessThanOrEqualTo(DateTime.UtcNow).WithMessage(ResourceErrorMessages.EXPENSES_CANNOT_FOR_THE_FUTURE);

        RuleFor(expanse => expanse.PaymentType)
            .IsInEnum().WithMessage(ResourceErrorMessages.PAYMENT_TYPE_INVALID);
    }
}
