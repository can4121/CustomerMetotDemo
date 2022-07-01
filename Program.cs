
using ClassMetotDemo;

Console.WriteLine("Hello, World!");

//3 adet Customer classımdan örnek oluşturdum.
Customer customer = new Customer();
customer.Id = 01;
customer.CustomerName = "Ali";
customer.CustomerSurname = "Kaya";
customer.CustomerCity = "İstanbul";
customer.CustomerAge = 21;

Customer customer1 = new Customer();
customer1.Id = 02;
customer1.CustomerName = "Ali";
customer1.CustomerSurname = "Kaya";
customer1.CustomerCity = "Ankara";
customer1.CustomerAge = 16;


Customer customer2 = new Customer();
customer1.Id = 03;
customer1.CustomerName = "Salih";
customer1.CustomerSurname = "Kaya";
customer1.CustomerCity = "İzmir";
customer1.CustomerAge = 25;


//Örneklediğim Customer'ları Customer tipi içerisinde diziye ekledim
Customer[] customers = new Customer[] { customer, customer1, customer2 };
//diziyi foreach ile dönerek çıktısını ekrana yazdırdım.
foreach(var item in customers)
{
    Console.WriteLine("Müşteri adı : " + item.CustomerName);
}

CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer);
customerManager.List(customer1);
customerManager.Deleted(customer2);