public interface IDoctor
{
    string GetSpecialization();
}

public interface INurse
{
    string GetDepartment();
}

public class PediatricDoctor : IDoctor
{
    public string GetSpecialization() => "Pediatrics";
}

public class PediatricNurse : INurse
{
    public string GetDepartment() => "Child Care";
}

public interface IStaffFactory
{
    IDoctor CreateDoctor();
    INurse CreateNurse();
}

public class PediatricStaffFactory : IStaffFactory
{
    public IDoctor CreateDoctor() => new PediatricDoctor();
    public INurse CreateNurse() => new PediatricNurse();
}