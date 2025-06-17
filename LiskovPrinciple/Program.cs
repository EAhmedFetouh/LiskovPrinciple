// See https://aka.ms/new-console-template for more information

using LiskovPrinciple;

IShippingProvider provider = new LocalCourier();
provider.Ship("ORDER123");
provider.Track("TRACK123");
provider.Cancel("ORDER123");