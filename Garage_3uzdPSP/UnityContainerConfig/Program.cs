using Garage_3uzdPSP.GarageService.GarageServiceUI;
using Garage_3uzdPSP.HR.HRUI;
using Garage_3uzdPSP.Supply.SupplyUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Garage_3uzdPSP.UnityContainerConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainer container = SecondConfiguration();
            ConsoleGarageServiceUI garageUI = new ConsoleGarageServiceUI(container.Resolve<GarageService.GarageServiceControllers.IGarageServiceController>());
            ConsoleSupplyUI supplyUI = new ConsoleSupplyUI(container.Resolve<Supply.SupplyControllers.ISupplyController>());
            ConsoleHRUI hrUI = new ConsoleHRUI(container.Resolve<HR.HRControllers.IHRController>());

                int choice;
            while ((choice = displayMenu()) != 10)
            {
                switch (choice)
                {
                    case 1:
                        hrUI.RegisterEmployee();
                        break;
                    case 2:
                        hrUI.GenerateWorkSheet();
                        break;
                    case 3:
                        hrUI.PaySalary();
                        break;
                    case 4:
                        supplyUI.RegisterSupplier();
                        break;
                    case 5:
                        supplyUI.RegisterPart();
                        break;
                    case 6:
                        supplyUI.EvaluateOrderingRisk();
                        break;
                    case 7:
                        garageUI.RegisterCustomer();
                        break;
                    case 8:
                        garageUI.RegisterGarageService();
                        break;
                    case 9:
                        garageUI.ProvideService();
                        break;
                }
            }
            Environment.Exit(0);
        }

        static int displayMenu()
        {
            Console.WriteLine("\n--MENU--");
            Console.WriteLine("1. Register new employee");
            Console.WriteLine("2. Submit  worksheet");
            Console.WriteLine("3. Pay salary");
            Console.WriteLine("4. Register new supplier");
            Console.WriteLine("5. Order part");
            Console.WriteLine("6. Evaluate part ordering risk");
            Console.WriteLine("7. Register new customer");
            Console.WriteLine("8. Add new garage service");
            Console.WriteLine("9. Provide garage service");
            Console.WriteLine("10. Exit program");
            Console.WriteLine("\nPlease enter menu selction number:");
            int selection;
            while(!Int32.TryParse(Console.ReadLine(), out selection))
            {
                Console.WriteLine("Please enter valid selection");
                Console.ReadLine();
            }
            return selection;
        }

        static UnityContainer FirstConfiguration()
        {
            var container = new UnityContainer();

            container.RegisterType<GarageService.GarageServiceControllers.IGarageServiceController, GarageService.GarageServiceControllers.GarageServiceController>();
            container.RegisterType<GarageService.GarageServiceDomainEntities.ICustomer, GarageService.GarageServiceDomainEntities.RegularCustomer>();
            container.RegisterType<GarageService.GarageServiceDomainEntities.IGarageService, GarageService.GarageServiceDomainEntities.RegularGarageService>();
            container.RegisterType<GarageService.GarageServiceDomainEntities.IGarageServiceFactory, GarageService.GarageServiceDomainEntities.RegularGarageServiceFactory>();
            container.RegisterType<GarageService.GarageServiceDomainServices.IGarageServiceProvider, GarageService.GarageServiceDomainServices.RegularGarageServiceProvider>();
            container.RegisterType<GarageService.GarageServiceFacade.IGarageServiceFacade, GarageService.GarageServiceFacade.GarageServiceFacadeWithNotification>();
            container.RegisterType<GarageService.GarageServiceRepository.ICustomerRepository, GarageService.GarageServiceRepository.MemoryCustomerRepository>();
            container.RegisterType<GarageService.GarageServiceRepository.IGarageServiceRepository, GarageService.GarageServiceRepository.MemoryGarageServiceRepository>();
            container.RegisterType<Integration.ISendMail, Integration.SimpleMailSender>();

            container.RegisterType<HR.HRControllers.IHRController, HR.HRControllers.SimpleHRController>();
            container.RegisterType<HR.HRDomainEntities.IEmployee, HR.HRDomainEntities.FullTimeEmployee>();
            container.RegisterType<HR.HRDomainEntities.IWorkSheet, HR.HRDomainEntities.FullTimeWorkSheet>();
            container.RegisterType<HR.HRDomainEntities.IHRFactory, HR.HRDomainEntities.FullTimeHRFactory>();
            container.RegisterType<HR.HRDomainServices.IPayCalculator, HR.HRDomainServices.BonusPayCalculator>();
            container.RegisterType<HR.HRFacade.IHRFacade, HR.HRFacade.HRFacadeWithNotification>();
            container.RegisterType<HR.HRRepository.IEmployeeRepository, HR.HRRepository.MemoryEmployeeRepository>();
            container.RegisterType<HR.HRRepository.IWorkSheetRepository, HR.HRRepository.MemoryWorkSheetRepository>();

            container.RegisterType<Supply.SupplyControllers.ISupplyController, Supply.SupplyControllers.SimpleSupplyController>();
            container.RegisterType<Supply.SupplyDomainEntities.IPart, Supply.SupplyDomainEntities.AfterMarketPart>();
            container.RegisterType<Supply.SupplyDomainEntities.ISupplier, Supply.SupplyDomainEntities.AfterMarketSupplier>();
            container.RegisterType<Supply.SupplyDomainEntities.ISupplyFactory, Supply.SupplyDomainEntities.AfterMarketSupplyFactory>();
            container.RegisterType<Supply.SupplyDomainServices.IOrderingRiskEvaluator, Supply.SupplyDomainServices.SmallAmountOrderRiskRateEvaluator>();
            container.RegisterType<Supply.SupplyFacade.ISupplyFacade, Supply.SupplyFacade.SupplyFacadeSimple>();
            container.RegisterType<Supply.SupplyRepository.IPartRepository, Supply.SupplyRepository.MemoryPartRepository>();
            container.RegisterType<Supply.SupplyRepository.ISupplierRepository, Supply.SupplyRepository.MemorySupplierRepository>();
            container.RegisterType<Supply.SupplyUI.ISupplyUI, Supply.SupplyUI.ConsoleSupplyUI>();

            return container;
        }

        static UnityContainer SecondConfiguration()
        {
            var container = new UnityContainer();

            container.RegisterType<GarageService.GarageServiceControllers.IGarageServiceController, GarageService.GarageServiceControllers.GarageServiceController>();
            container.RegisterType<GarageService.GarageServiceDomainEntities.ICustomer, GarageService.GarageServiceDomainEntities.EmployeeCustomer>();
            container.RegisterType<GarageService.GarageServiceDomainEntities.IGarageService, GarageService.GarageServiceDomainEntities.EmployeeGarageService>();
            container.RegisterType<GarageService.GarageServiceDomainEntities.IGarageServiceFactory, GarageService.GarageServiceDomainEntities.EmployeeGarageServiceFactory>();
            container.RegisterType<GarageService.GarageServiceDomainServices.IGarageServiceProvider, GarageService.GarageServiceDomainServices.NoWaitingLineGarageServiceProvider>();
            container.RegisterType<GarageService.GarageServiceFacade.IGarageServiceFacade, GarageService.GarageServiceFacade.GarageServiceFacadeSimple>();
            container.RegisterType<GarageService.GarageServiceRepository.ICustomerRepository, GarageService.GarageServiceRepository.MemoryCustomerRepository>();
            container.RegisterType<GarageService.GarageServiceRepository.IGarageServiceRepository, GarageService.GarageServiceRepository.MemoryGarageServiceRepository>();
            container.RegisterType<GarageService.GarageServiceUI.ConsoleGarageServiceUI>();
            container.RegisterType<Integration.ISendMail, Integration.MailSenderWithSiganture>();

            container.RegisterType<HR.HRControllers.IHRController, HR.HRControllers.SimpleHRController>();
            container.RegisterType<HR.HRDomainEntities.IEmployee, HR.HRDomainEntities.PartTimeEmployee>();
            container.RegisterType<HR.HRDomainEntities.IWorkSheet, HR.HRDomainEntities.PartTimeWorkSheet>();
            container.RegisterType<HR.HRDomainEntities.IHRFactory, HR.HRDomainEntities.PartTimeHRFactory>();
            container.RegisterType<HR.HRDomainServices.IPayCalculator, HR.HRDomainServices.SimplePayCalculator>();
            container.RegisterType<HR.HRFacade.IHRFacade, HR.HRFacade.HRFacadeSimple>();
            container.RegisterType<HR.HRRepository.IEmployeeRepository, HR.HRRepository.MemoryEmployeeRepository>();
            container.RegisterType<HR.HRRepository.IWorkSheetRepository, HR.HRRepository.MemoryWorkSheetRepository>();

            container.RegisterType<Supply.SupplyControllers.ISupplyController, Supply.SupplyControllers.SimpleSupplyController>();
            container.RegisterType<Supply.SupplyDomainEntities.IPart, Supply.SupplyDomainEntities.OriginalPart>();
            container.RegisterType<Supply.SupplyDomainEntities.ISupplier, Supply.SupplyDomainEntities.OriginalSupplier>();
            container.RegisterType<Supply.SupplyDomainEntities.ISupplyFactory, Supply.SupplyDomainEntities.OriginalSupplyFactory>();
            container.RegisterType<Supply.SupplyDomainServices.IOrderingRiskEvaluator, Supply.SupplyDomainServices.BigAmountOrderRiskRateEvaluator>();
            container.RegisterType<Supply.SupplyFacade.ISupplyFacade, Supply.SupplyFacade.SupplyFacadeWithNotification>();
            container.RegisterType<Supply.SupplyRepository.IPartRepository, Supply.SupplyRepository.MemoryPartRepository>();
            container.RegisterType<Supply.SupplyRepository.ISupplierRepository, Supply.SupplyRepository.MemorySupplierRepository>();
            container.RegisterType<Supply.SupplyUI.ISupplyUI, Supply.SupplyUI.ConsoleSupplyUI>();

            return container;
        }
    }
}
