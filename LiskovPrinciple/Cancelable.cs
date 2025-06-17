namespace LiskovPrinciple;

public abstract class CancelableShippingProvider : NewShippingProvider
{
    public abstract void Cancel(string orderNumber);
}