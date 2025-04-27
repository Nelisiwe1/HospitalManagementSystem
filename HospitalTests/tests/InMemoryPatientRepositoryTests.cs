using System;
using System.Diagnostics;
using HospitalManagementSystem.Entities;
using HospitalManagementSystem.Repositories.InMemory;

namespace HospitalManagementSystem.Tests
{
    public class InMemoryPatientRepositoryTests
    {
        public static void RunAll()
        {
            var repo = new InMemoryPatientRepository();
            var entity = new Patient { Id = "E001", Description = "Test Patient" };

            repo.Save(entity);
            Debug.Assert(repo.FindById("E001") != null, "Patient should be found.");
            Debug.Assert(repo.FindAll().Count == 1, "There should be one Patient.");
            repo.Delete("E001");
            Debug.Assert(repo.FindById("E001") == null, "Patient should be deleted.");

            Console.WriteLine("All Patient tests passed!");
        }
    }
}