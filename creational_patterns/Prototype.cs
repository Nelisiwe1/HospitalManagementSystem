public abstract class Prescription
{
    public string MedicineName;
    public int Dosage;

    public abstract Prescription Clone();
}

public class AntibioticPrescription : Prescription
{
    public AntibioticPrescription(string name, int dosage)
    {
        MedicineName = name;
        Dosage = dosage;
    }

    public override Prescription Clone()
    {
        return (Prescription)this.MemberwiseClone();
    }
}