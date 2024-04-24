using CashFlow.Communication.Requests;
using FluentValidation;

namespace CashFlow.Appilcation.UseCases.Expenses.Register;

public class RegisterExpanseValidator : AbstractValidator<RequestRegisterExpenseJson>
{
    public RegisterExpanseValidator()
    {
        RuleFor(expanse => expanse.Title)
            .NotEmpty().WithMessage("Title is required");

        RuleFor(expanse => expanse.Amount)
            .GreaterThan(0).WithMessage("Value must be greater than zero");

        RuleFor(expanse => expanse.Date)
            .LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Date cannot be greater than the current date");

        RuleFor(expanse => expanse.PaymentType)
            .IsInEnum().WithMessage("Invalid payment type");
    }
}
