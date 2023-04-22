using System.ComponentModel;

namespace PapperAB.Models
{
    public class InfoViewModel
    {
        [DisplayName("First Name")]
        public string FirstMidName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Semester")]
        public string ProjectName { get; set; }
        [DisplayName("Semestertyp")]
        public string Description { get; set; }
        [DisplayName("First Day")]
        public DateTime Start { get; set; }
        [DisplayName("Last Day")]
        public DateTime Stop { get; set; }  

    }
}
