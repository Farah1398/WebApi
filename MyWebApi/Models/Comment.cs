using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebApi.Models
{
    public class Comment
    {
        public int CommentId { get; set; }

        [ForeignKey("UserId")]
        public int? UserId { get; set; }

        [ForeignKey("FileId")]
        public int? FileId { get; set; }
        public string Com_Content { get; set; }
        public Nullable<System.DateTime> Post_Date { get; set; }

        public virtual Table_File Table_File { get; set; }
        public virtual User User { get; set; }
    }
}

