using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LearnEntityFramework.Models
{
    [Table("languages")]
    public partial class Language
    {
        public Language()
        {
            Users = new HashSet<User>();
        }

        [Key]
        [Column("lang_gkey")]
        public long LangGkey { get; set; }
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; } = null!;
        [Column("culture")]
        [StringLength(100)]
        public string Culture { get; set; } = null!;

        [InverseProperty("CultureMessageGkeyNavigation")]
        public virtual CultureMessage CultureMessage { get; set; } = null!;
        [InverseProperty("LanguageGkeyNavigation")]
        public virtual ICollection<User> Users { get; set; }
    }
}
