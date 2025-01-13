using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class Document
    {
        public long Id { get; set; }

        [Required]
        [MinLength(3)]
        public string Name { get; set; }
    }
}