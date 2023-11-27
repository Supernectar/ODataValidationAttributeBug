using System.ComponentModel.DataAnnotations;

namespace WebApplication1;

public class Customer
{
    [MinLength(5)]
    public string? Id { get; set; }
    public string? Name { get; set; }
}
