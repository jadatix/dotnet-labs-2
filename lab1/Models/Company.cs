public class Company
{
    public int CompanyId { get; set; }
    public string Name { get; set; }
    public string LegalAddress { get; set; }
    public string ContactPhone { get; set; }
    public List<Manager> Managers { get; set; }
    public List<Sale> Sales { get; set; }
}
