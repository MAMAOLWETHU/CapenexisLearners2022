using System.ComponentModel.DataAnnotations;

namespace CapenexisLearners2022.Models;

public class Facilitator
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? NationalIdentityNumber { get; set; }
    public string? NumberofLearners { get; set; }
}