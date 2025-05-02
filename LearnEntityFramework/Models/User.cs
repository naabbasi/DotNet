using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnEntityFramework.Models;

[Table("users")]
[Index("LanguageGkey", Name = "users_FK")]
public partial class User
{
    [Key]
    [Column("user_gkey")]
    public long UserGkey { get; set; }
    
    [Column("username")]
    [StringLength(255)]
    public string Username { get; set; } = null!;
    
    [Column("password")]
    [StringLength(255)]
    public string Password { get; set; } = null!;
    [Column("language_gkey")]
    public long LanguageGkey { get; set; }

    public override string? ToString()
    {
        return $"User Id = {UserGkey}, Username = {Username}, Password = {Password}";
    }
}
