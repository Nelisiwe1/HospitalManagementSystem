using System;
using System.Diagnostics;
using HospitalManagementSystem.Entities;
using HospitalManagementSystem.Repositories.InMemory;

namespace HospitalManagementSystem.Tests
{
    public class InMemoryBillingRepositoryTests
    {
        public static void RunAll()
        {
            var repo = new InMemoryBillingRepository();
            var entity = new Billing { Id = "E001", Description = "Test Billing" };

            repo.Save(entity);
            Debug.Assert(repo.FindById("E001") != null, "Billing should be found.");
            Debug.Assert(repo.FindAll().Count == 1, "There should be one Billing.");
            repo.Delete("E001");
            Debug.Assert(repo.FindById("E001") == null, "Billing should be deleted.");

            Console.WriteLine("All Billing tests passed!");
        }
    }
}