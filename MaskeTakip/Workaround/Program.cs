using Business.Concrete;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        Person person = new Person();
        person.FirstName = "Umut Can";
        person.LastName = "Günenç";
        person.DateOfBirthYear = 1989;
        person.NationalIdentity = 1234;

        PttManager pttManager = new(new PersonManager());
        pttManager.GiveMask(person);
                
    }
    
}