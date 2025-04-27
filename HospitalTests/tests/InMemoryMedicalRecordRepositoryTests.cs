using System;
using System.Diagnostics;
using HospitalManagementSystem.Entities;
using HospitalManagementSystem.Repositories.InMemory;

namespace HospitalManagementSystem.Tests
{
    public class InMemoryMedicalRecordRepositoryTests
    {
        public static void RunAll()
        {
            var repo = new InMemoryMedicalRecordRepository();
            var entity = new MedicalRecord { Id = "E001", Description = "Test MedicalRecord" };

            repo.Save(entity);
            Debug.Assert(repo.FindById("E001") != null, "MedicalRecord should be found.");
            Debug.Assert(repo.FindAll().Count == 1, "There should be one MedicalRecord.");
            repo.Delete("E001");
            Debug.Assert(repo.FindById("E001") == null, "MedicalRecord should be deleted.");

            Console.WriteLine("All MedicalRecord tests passed!");
        }
    }
}