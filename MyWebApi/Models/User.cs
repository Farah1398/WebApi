namespace MyWebApi.Models
{
    public class User
    {
        public User()
        {
            this.Comment = new HashSet<Comment>();
            this.Table_File = new HashSet<Table_File>();
        }

        public int UserId { get; set; }
        public int UserTypeId { get; set; }
        public byte[] UserName { get; set; }
        public byte[] passwd { get; set; }
        public byte[] email { get; set; }

        
        public virtual ICollection<Comment> Comment { get; set; }
        
        public virtual ICollection<Table_File> Table_File { get; set; }
        //public virtual User User1 { get; set; }
        //public virtual User User2 { get; set; }
        public virtual UserType UserType { get; set; }
    }
}
