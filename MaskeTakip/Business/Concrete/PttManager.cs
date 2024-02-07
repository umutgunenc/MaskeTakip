using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantServices;

        public PttManager(IApplicantService applicantService)
        {
            _applicantServices = applicantService;
            
        }

        public void GiveMask(Person person)
        {
            
            if (_applicantServices.CheckPerson(person))            
                Console.WriteLine($"{person.FirstName} için maske verildi.");
            else
                Console.WriteLine("Girilen Bilgiler Hatalı. Girilen Bilgileri Kontrol Ediniz.");

        }
    }
}
