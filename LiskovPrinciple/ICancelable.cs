namespace LiskovPrinciple;

public interface ICancelable
{
    void Cancel(string trackingNumber);
}