using System;
using HospitalLib; // Ensure HospitalLib is the correct namespace

class Program
{
    static void Main()
    {
        try
        {
            // Use the Simple Factory to create a patient
            var patient = PatientFactory.CreatePatient("General");

            // Output patient details
            Console.WriteLine("=== Patient Info ===");
            patient.PrintDetails();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
