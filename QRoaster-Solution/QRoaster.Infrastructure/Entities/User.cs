using QRoaster.Infrastructure.DBContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRoaster.Infrastructure.Entities
{
    [Table("users")]
    public partial class User : BaseEntity
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

        public User(long UserGkey, string Username)
        {
            this.UserGkey = UserGkey;
            this.Username = Username;
        }

        public override string? ToString()
        {
            return $"GKey = {UserGkey}, Username = {Username}, Password = {Password}";
        }
    }
}
