using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace DBLocalizationSupport.Models
{
    [Table("users")]
    [Index("LanguageGkey", Name = "users_FK")]
    public partial class User
    {
        [Key]
        [Column("user_gkey")]
        [JsonPropertyName("userGenericKey")]
        public long UserGkey { get; set; }
        [Column("username")]
        [StringLength(255)]
        public string Username { get; set; } = null!;
        [Column("password")]
        [StringLength(255)]
        public string Password { get; set; } = null!;
        [Column("language_gkey")]
        public long LanguageGkey { get; set; }

        [ForeignKey("LanguageGkey")]
        [InverseProperty("Users")]
        public virtual Language LanguageGkeyNavigation { get; set; } = null!;

        public override string? ToString()
        {
            return $"UserGkey = {UserGkey}, Username = {Username}, Password = {Password}, LanguageGkey = {LanguageGkey}";
        }
    }
}
