using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoList.Shared.Domains
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostId { get; set; }

        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        public Status? Status { get; set; }
    }
}
