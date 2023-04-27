namespace Domain.Models
{
    public class Tweet
    {
        public int? Id { get; set; }

        public string? Content { get; set; }

        public DateTime? CreatedAt { get; set; }

        public int? ParentTweetId { get; set; }
    }
}
