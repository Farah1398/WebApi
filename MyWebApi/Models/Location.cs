namespace MyWebApi.Models
{
    public class Location
    {
        public Location()
        {
            this.Table_File = new HashSet<Table_File>();
        }

        public int LocationId { get; set; }
        public Nullable<int> ServerId { get; set; }
        public string DirectoryPath { get; set; }

        public virtual Server Server { get; set; }
        
        public virtual ICollection<Table_File> Table_File { get; set; }
    }
}
}
