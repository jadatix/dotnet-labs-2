using System.ComponentModel.DataAnnotations;

public class Manager
{
    public int ManagerId { get; set; }
    [Required]
    public string Surname { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string Patronymic { get; set; }
    [Required]
    public int CompanyId { get; set; }
    [Required]
    public Company Company { get; set; }
}
