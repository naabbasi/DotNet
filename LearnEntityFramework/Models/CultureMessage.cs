using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LearnEntityFramework.Models
{
    [Table("culture_messages")]
    public partial class CultureMessage
    {
        [Key]
        [Column("culture_message_gkey")]
        public long CultureMessageGkey { get; set; }
        [Column("language_gkey")]
        public long LanguageGkey { get; set; }
        [Column("key")]
        [StringLength(255)]
        public string Key { get; set; } = null!;
        [Column("value", TypeName = "text")]
        public string Value { get; set; } = null!;

        [ForeignKey("CultureMessageGkey")]
        [InverseProperty("CultureMessage")]
        public virtual Language CultureMessageGkeyNavigation { get; set; } = null!;
    }
}
