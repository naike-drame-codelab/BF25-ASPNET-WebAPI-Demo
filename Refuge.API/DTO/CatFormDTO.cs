using System.ComponentModel.DataAnnotations;
using Refuge.BLL.Enums;

namespace Refuge.API.DTO
{
    public class CatFormDTO
    {
        [Required]
        [MaxLength(25)]
        public string Name { get; set; } = null!;
        public CatColor Color { get; set; }
    }
}
