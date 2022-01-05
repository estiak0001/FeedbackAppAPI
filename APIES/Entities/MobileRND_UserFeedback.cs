using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIES.Entities
{
    [Table(name: "MobileRND_UserFeedback")]
    public class MobileRND_UserFeedback
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(150)]
        public string IEMI { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedOn { get; set; }
        public Guid LUser { get; set; }
    }
}
