using CashFlow.Appilcation.UseCases.Expenses.Register;
using CommonTestUtilities.Requests;
using FluentAssertions;

namespace Validators.Tests.Expenses.Register;

public class RegisterExpenseValidatorTests
{
    [Fact]
    public void Success()
    {
        //Arrange
        var validator = new RegisterExpanseValidator();
        var request = RequestRegisterExpenseJsonBuilder.Build();

        //Act
        var result = validator.Validate(request);

        //Assert
        result.IsValid.Should().BeTrue();

    }
}
