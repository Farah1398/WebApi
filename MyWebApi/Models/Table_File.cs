using System.Xml.Linq;

namespace MyWebApi.Models
{
    public class Table_File
    {
        
          
            public Table_File()
            {
                this.Comment = new HashSet<Comment>();
            }

            public int FileId { get; set; }
            public Nullable<int> LocationId { get; set; }
            public Nullable<int> UserId { get; set; }
            public string FileName { get; set; }
            public string FileDescription { get; set; }
            public Nullable<System.DateTime> Upload_date { get; set; }
            public Nullable<System.DateTime> Download_date { get; set; }

           
            public virtual ICollection<Comment> Comment { get; set; }
            public virtual Location Location { get; set; }
            public virtual User User { get; set; }
        }
    
}
