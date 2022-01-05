using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIES.Entities
{
    [Table(name: "MobileRND_ModelWiseCriteria")]
    public class MobileRND_ModelWiseCriteria
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(150)]
        public string ModelID { get; set; }

        [ForeignKey("MobileRND_UserFeedbackCriteria")]
        public Guid CriteriaID { get; set; }
        public virtual MobileRND_UserFeedbackCriteria MobileRND_UserFeedbackCriteria { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedOn { get; set; }
        public Guid LUser { get; set; }
    }
}
