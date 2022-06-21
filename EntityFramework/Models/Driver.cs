using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.Models
{
    public enum License
    {
        G1, G2, G
    }
    public class Driver
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        public License License { get; set; }

        [Display(Name = "Experience Level")]
        public string Experience
        {
            get
            {
                return License == License.G ? "experienced!" : "not experienced";
            }
        }

        [Display(Name = "Name")]
        public string DisplayName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }

        public ICollection<Car> Cars { get; set; }
    }
}
