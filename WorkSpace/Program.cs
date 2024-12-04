using Business.Concreate;
using Entities.Concreate;


class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.FirstName = "YASİN";
        person.Lastname = "YILDIZ";
        person.DateOfBirth = 2003;
        person.NationalIdentity = 111;

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person);
    }
}


