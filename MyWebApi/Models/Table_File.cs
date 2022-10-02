using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace MyWebApi.Models
{
    public class Table_File
    {
        
          
            public Table_File()
            {
                this.Comment = new HashSet<Comment>();
            }

            [Key]
            public int FileId { get; set; }
            public int LocationId { get; set; }
            public int UserId { get; set; }
            public string FileName { get; set; }
            public string FileDescription { get; set; }
            public Nullable<System.DateTime> Upload_date { get; set; }
            public Nullable<System.DateTime> Download_date { get; set; }

           
            public virtual ICollection<Comment> Comment { get; set; }
            public virtual Location Location { get; set; }
            public virtual User User { get; set; }
        }
    
}
