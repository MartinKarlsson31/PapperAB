using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PapperAB.Models
{
    public class Project
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectId { get; set; }
        [StringLength(50)]
        [DisplayName("Semester")]
        public string ProjectName { get; set; }
        [StringLength(500)]
        [DisplayName("Semestertyp")]
        public string Description { get; set; }
        [StringLength(50)]
        public string Status { get; set; }
        public virtual ICollection<ProjectList>? ProjectLists { get; set; }

    }
}
