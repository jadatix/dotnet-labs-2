public class Manager
{
    public int ManagerId { get; set; }
    public string Surname { get; set; }
    public string FirstName { get; set; }
    public string Patronymic { get; set; }
    public int CompanyId { get; set; }
    public Company Company { get; set; }
}
