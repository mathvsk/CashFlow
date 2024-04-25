namespace CashFlow.Exception.ExceptionsBase;

public class ErrorOnValidationException : CashFlowException
{
    public List<string> Erros { get; }
    public ErrorOnValidationException(List<string> errorMessages)
    {
        this.Erros = errorMessages;
    }
}
