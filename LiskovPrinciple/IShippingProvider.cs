namespace LiskovPrinciple;
public interface INewShippingProvider
{
    void Ship(string order);
    void Track(string trackingNumber);
}