using System.ComponentModel.DataAnnotations;

namespace GoogleClone.Shared.Models
{
    public class SearchDto
    {
        [Required(ErrorMessage = "this field is required")]
        [StringLength(100, ErrorMessage = "The search parameter you provided is too long")]
        public string searchKey { get; set; } = string.Empty;
    }
}