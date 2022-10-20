using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models.Entities;

public class User {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get;set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Tipe { get; set; }
}

// dotnet ef migrations add "InitialDB" -o "Models/Migrations" 