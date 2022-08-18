// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;

Console.WriteLine("Hello, World!");



PersonManager personManager = new PersonManager(new EfPersonDal());

///GetList(personManager);

static void GetList(PersonManager personManager)
{
    foreach (var item in personManager.GetPeople())
    {
        Console.WriteLine(item.Name);
    }
}

Added(personManager);

static void Added(PersonManager personManager)
{
   
    
        Person people = new Person(Guid.NewGuid(), "Yavuz", "KAYA", 11111111, "556565656", "byndr28@gmail.com", DateTime.Now, DateTime.Now, true, true, "Önlisans", "Sancaktepe", true);
        personManager.Add(people);

    Console.WriteLine("Personel Kaydedilmiştir."+people.Id+" "+people.Name);
}

///Deleted(personManager);

static void Deleted(PersonManager personManager)
{
    Person people = new Person(Guid.NewGuid(), "Selim", "BAYINDIR", 11111111, "556565656", "byndr28@gmail.com", DateTime.Now, DateTime.Now, true, true, "Önlisans", "Sancaktepe", true);

    personManager.Delete(people);
    Console.WriteLine("Personel Silinmiştir.");
}