using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartBikeBD.Models
{
    public class Model
    {
        public int ModelId { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [ForeignKey("Make")]
        public int MakeFK { get; set; }
        public Make Make { get; set; }
    }
}
