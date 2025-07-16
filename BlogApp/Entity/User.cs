namespace BlogApp.Entity
{
    public class User
    {
        public int UserId { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }


        public List<Post> Posts { get; set; } = new List<Post>();
        public List<Commend> Commends { get; set; } = new List<Commend>();
    }
}