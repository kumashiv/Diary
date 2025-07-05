using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry     //Table name
    {
        //[Key]
        public int Id { get; set; }     //If Id - it's primary key by default
        [Required]
        public string Title{ get; set; } = string.Empty;
        [Required]
        public string Content { get; set; } = string.Empty ;
        [Required]
        public DateTime Created { get; set; } = DateTime.Now;
    }
}

