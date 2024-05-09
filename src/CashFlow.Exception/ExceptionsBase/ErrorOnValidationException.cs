namespace CashFlow.Exception.ExceptionsBase;

public class ErrorOnValidationException : CashFlowException
{
    public List<string> Erros { get; }
    public ErrorOnValidationException(List<string> errorMessages) : base(string.Empty)
    {
        this.Erros = errorMessages;
    }
}
