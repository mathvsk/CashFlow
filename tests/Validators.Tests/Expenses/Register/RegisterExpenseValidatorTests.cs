using CashFlow.Appilcation.UseCases.Expenses.Register;
using CashFlow.Communication.Requests;

namespace Validators.Tests.Expenses.Register;

public class RegisterExpenseValidatorTests
{
    [Fact]
    public void Success()
    {
        //Arrange
        var validator = new RegisterExpanseValidator();
        var request = new RequestRegisterExpenseJson
        {
            Title = "Title",
            Date = DateTime.UtcNow.AddDays(-1),
            Description = "Description",
            Amount = 1,
            PaymentType = CashFlow.Communication.Enums.PaymentType.CREDIT_CARD
        };

        //Act
        var result = validator.Validate(request);

        //Assert
        Assert.True(result.IsValid);

    }
}
