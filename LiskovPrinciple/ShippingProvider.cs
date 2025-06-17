namespace LiskovPrinciple;


/*
 "Liskov Substitution Principle states that subclasses or implementations must be substitutable 
 for their base types without altering the expected behavior of the program."
 */


/*
✅ ما هو Liskov Substitution Principle؟
   "الـ Liskov Substitution Principle — أو مبدأ الاستبدال في Liskov — بيقول:
   
   أي كلاس فرعي (subclass) لازم يقدر يحل محل الكلاس الأب أو الـ interface اللي بيورث منه من غير ما يبوظ توقعات الـ client.
   
   يعني لو أنا شغال مع abstraction (interface أو base class)، المفروض أقدر أبدله بأي implementation من غير مفاجآت أو استثناءات مش متوقعة."
   
   🔑 القاعدة الذهبية
   "لو الـ client استخدم abstraction زي ما هو متوقع، أي implementation لازم يشتغل زي العقد اللي الـ abstraction وعد بيه."
   
   ✅ المطلوب — السيناريو
   "إحنا عندنا شركات شحن في الـ system:
   
   DHL: بتدعم Ship + Track + Cancel.
   
   Aramex: بتدعم Ship + Track + Cancel.
   
   LocalCourier: بتدعم Ship + Track بس، ومفيهاش Cancel.
   
   وعايزين نعمل design يخلينا نقدر نستخدم أي شركة منهم مع الـ client من غير ما يوقعنا في مشاكل."
 
 */
public interface IShippingProvider
{
     void Ship(string order);
      void Track(string trackingNumber);
     void Cancel(string trackingNumber);
}

public class DHL : IShippingProvider
{
    public  void Ship(string order) => Console.WriteLine("DHL shipped");
    public  void Track(string trackingNumber) => Console.WriteLine("DHL tracking");
    public  void Cancel(string trackingNumber) => Console.WriteLine("DHL cancelled");
}

public class Aramex : IShippingProvider
{
    public  void Ship(string order) => Console.WriteLine("Aramex shipped");
    public  void Track(string trackingNumber) => Console.WriteLine("Aramex tracking");
    public  void Cancel(string trackingNumber) =>
        throw new NotImplementedException("Aramex does not support cancel via API");
}

public class LocalCourier : IShippingProvider
{
    public  void Ship(string order) => Console.WriteLine("LocalCourier shipped");
    public  void Track(string trackingNumber) =>
        throw new NotImplementedException("LocalCourier does not support tracking");
    public  void Cancel(string trackingNumber) =>
        throw new NotImplementedException("LocalCourier does not support cancel");
}




public class DHL2 : INewShippingProvider, ICancelable
{
    public void Ship(string order) => Console.WriteLine("DHL shipped");
    public void Track(string trackingNumber) => Console.WriteLine("DHL tracking");
    public void Cancel(string trackingNumber) => Console.WriteLine("DHL cancelled");
}

public class Aramex2 : INewShippingProvider, ICancelable
{
    public void Ship(string order) => Console.WriteLine("Aramex shipped");
    public void Track(string trackingNumber) => Console.WriteLine("Aramex tracking");
    public void Cancel(string trackingNumber) => Console.WriteLine("Aramex cancelled");
}


public class LocalCourier2 : INewShippingProvider
{
    public void Ship(string order) => Console.WriteLine("LocalCourier shipped");
    public void Track(string trackingNumber) => Console.WriteLine("LocalCourier tracking");
}
