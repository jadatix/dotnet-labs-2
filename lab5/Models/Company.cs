using System.ComponentModel.DataAnnotations;

public class Company
{
    public int CompanyId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string LegalAddress { get; set; }
    [Required]
    public string ContactPhone { get; set; }
    [Required]
    public List<Manager> Managers { get; set; }
    [Required]
    public List<Sale> Sales { get; set; }
}
