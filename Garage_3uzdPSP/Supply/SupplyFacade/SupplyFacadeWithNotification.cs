using Garage_3uzdPSP.Supply.SupplyDomainEntities;
using Garage_3uzdPSP.Supply.SupplyRepository;
using Garage_3uzdPSP.Supply.SupplyDomainServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garage_3uzdPSP.Integration;

namespace Garage_3uzdPSP.Supply.SupplyFacade
{
    class SupplyFacadeWithNotification : ISupplyFacade
    {
        ISupplierRepository supplierRepository;
        IPartRepository partRepository;
        ISupplyFactory factory;
        IOrderingRiskEvaluator evaluator;
        ISendMail mailSender;

        public SupplyFacadeWithNotification(ISupplierRepository supplierRepository, IPartRepository partRepository,
            ISupplyFactory factory, IOrderingRiskEvaluator evaluator, ISendMail mailSender)
        {
            this.supplierRepository = supplierRepository;
            this.partRepository = partRepository;
            this.factory = factory;
            this.evaluator = evaluator;
            this.mailSender = mailSender;
        }

        public int AddPart(int supplierID, string partNumber, string manufacturer)
        {
            Debug.WriteLine("Looking for supplier with id " + supplierID + " in repo from facade");
            ISupplier supplier = supplierRepository.GetSupplier(supplierID);
            if (supplier == null)
            {
                Console.WriteLine("Supplier with entered ID not found");
                return -1;
            }
            IPart part = factory.CreatePart(partNumber, manufacturer, supplier);
            int id = partRepository.AddPart(part);
            string content = "We would like to place an order for part "+ part.PartNumber +
                " manufacturer " + part.Manufacturer;
            mailSender.SendMail(supplier.Email, content);
            Debug.WriteLine("Part with ID " + id + " added to repo from facade");
            return id;
        }

        public int AddSupplier(string name, string email)
        {
            ISupplier supplier = factory.CreateSupplier(name, email);
            int id = supplierRepository.AddSupplier(supplier);
            Debug.WriteLine("Supplier with ID " + id + " added to repo from facade");
            string content = "Congratulations on becoming our supplier!";
            mailSender.SendMail(supplier.Email, content);
            return id;
        }

        public int EvaluteRisk(int partID)
        {
            Debug.WriteLine("Looking for part with id " + partID + " in repo from facade");
            IPart part = partRepository.GetPart(partID);
            if (part == null)
            {
                Console.WriteLine("Part with entered ID not found");
                return -1;
            }
            return evaluator.EvaluateOrderingRiskRate(part);
        }
    }
}
