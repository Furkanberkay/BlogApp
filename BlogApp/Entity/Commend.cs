namespace BlogApp.Entity
{
    public class Commend
    {
        public int CommendId { get; set; }
        public string? Text { get; set; }
        public DateTime CreatedOn { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; } = null!;

        public int UserId { get; set; }
        public User User { get; set; } = null!;

    }
}