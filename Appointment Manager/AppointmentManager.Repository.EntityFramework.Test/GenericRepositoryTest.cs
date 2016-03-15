using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppointmentManager.Models;

namespace AppointmentManager.Repository.EntityFramework.Test
{
    [TestClass]
    public class GenericRepositoryTest
    {
        [TestMethod]
        public void TestInsertion()
        {
            var context = new AppointmentManagerContext();
            IRepository<ServiceType, int> serviceRepository = new EFRepository<ServiceType, int>(context);

            var serviceType = new ServiceType()
            {
                CreatedBy = "admin",
                CreationDate = DateTime.Now,
                LastModificationDate = DateTime.Now,
                Name = "Test service"
            };

            serviceType = serviceRepository.Add(serviceType);

            Assert.IsNotNull(serviceType);
            Assert.AreNotEqual(serviceType.ID, 0);


            serviceType = serviceRepository.GetByID(serviceType.ID);
            Assert.IsNotNull(serviceType);


            serviceRepository.Delete(serviceType);
            serviceType = serviceRepository.GetByID(serviceType.ID);
            Assert.IsNull(serviceType);
        }
    }
}
