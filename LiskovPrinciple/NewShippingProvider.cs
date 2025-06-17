namespace LiskovPrinciple;
public abstract class NewShippingProvider
{
    public abstract void Ship(string order);
    public abstract void Track(string trackingNumber);
}