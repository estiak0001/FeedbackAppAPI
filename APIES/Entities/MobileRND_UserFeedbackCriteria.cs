using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIES.Entities
{
    [Table(name: "MobileRND_UserFeedbackCriteria")]
    public class MobileRND_UserFeedbackCriteria
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(150)]
        public string CriteriaNameEnglish { get; set; }

        [Required]
        [StringLength(150)]
        public string CriteriaNameBangla { get; set; }

        public string ImageUrl { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedOn { get; set; }
        public Guid LUser { get; set; }
    }
}
