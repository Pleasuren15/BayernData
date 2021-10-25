using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BayernData.Models
{
    public class Staff
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StaffId { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string StaffFirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string StaffLastName { get; set; }

        [DisplayName("Kit Number")]
        public string StaffKitNumber { get; set; }

        [Required]
        [DisplayName("Image Url")]
        public string StaffImageUrl { get; set; }

        [Required]
        [DisplayName("Staff Position")]
        public string StaffPosition { get; set; }
    }
}
