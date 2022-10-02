namespace MyWebApi.Models
{
    public class Server
    {
        public Server()
        {
            this.Location = new HashSet<Location>();
        }

        public int ServerId { get; set; }
        public string ServerIp { get; set; }
        public string ServerName { get; set; }

        
        public virtual ICollection<Location> Location { get; set; }
    }
}
}
