using Garage_3uzdPSP.GarageService.GarageServiceDomainEntities;
using Garage_3uzdPSP.GarageService.GarageServiceRepository;
using Gargage_3uzdPSP.GarageService.GarageServiceDomainServices;
using Gargage_3uzdPSP.GarageService.GarageServiceRepository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.GarageService.GarageServiceFacade
{
    class GarageServiceFacadeWithNotification : IGarageServiceFacade
    {
        ICustomerRepository customerRepository;
        IGarageServiceRepository garageServiceRepository;
        IGarageServiceProvider provider;
        IGarageServiceFactory factory;
        ISendMail mailSender;

        public GarageServiceFacadeWithNotification(ICustomerRepository customerRepository,
            IGarageServiceRepository garageServiceRepository, IGarageServiceProvider provider,
            IGarageServiceFactory factory, ISendMail mailSender)
        {
            this.customerRepository = customerRepository;
            this.garageServiceRepository = garageServiceRepository;
            this.provider = provider;
            this.factory = factory;
            this.mailSender = mailSender;
        }

        public int AddCustomer(string name, string surname, string email)
        {
            ICustomer newCustomer = factory.CreateCustomer(name, surname, email);
            int custID = customerRepository.AddCustomer(newCustomer);
            Debug.WriteLine("Customer with ID " + custID + " added to repo from facade");
            string content = "Congratulations on becoming one of our customers. We hope" +
                "you will be satisfied with our service.";
            mailSender.SendMail(email, content);
            return custID;
        }

        public int AddGarageService(string name, decimal price)
        {
            IGarageService newService = factory.CreateService(name, price);
            int serviceID = garageServiceRepository.AddGarageService(newService);
            Debug.WriteLine("Garage service with ID " + serviceID + " added to repo from facade");
            return serviceID;
        }

        public int ProvideGarageService(int custID, int serviceID)
        {
            Debug.WriteLine("Looking for customer with id " + custID + " in repo from facade");
            ICustomer customer = customerRepository.GetCustomer(custID);
            if (customer == null)
            {
                Console.WriteLine("Customer with entered ID not found");
                return -1;
            }
            Debug.WriteLine("Looking for garage service with id " + serviceID + " in repo from facade");
            IGarageService service = garageServiceRepository.GetGarageService(serviceID);
            if (service == null)
            {
                Console.WriteLine("Service with entered ID not found");
                return -1;
            }
            provider.WaitingTimeInDays = 3;
            provider.ProvideGarageService(customer, service);
            string content = "Thank you for using our services. Your waiting time is " +
                provider.WaitingTimeInDays +" days.";
            mailSender.SendMail(customer.Email, content);
            return 0;
        }
    }
}
