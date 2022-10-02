namespace MyWebApi.Models
{
    public class UserType
    {
        public UserType()
        {
            this.User = new HashSet<User>();
        }

        public int UserTypeId { get; set; }
        public byte[] UserTypeName { get; set; }

        
        public virtual ICollection<User> User { get; set; }
    }
}

