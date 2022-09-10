namespace Bloggie.Data
{
    public class Comment
    {
        public int Id { get; set; }

        [Required, MaxLength(200)]
        public string Content { get; set; }



        [ForeignKey("AuthorId")]
        public ApplicationUser Author { get; set; }


        [ForeignKey("PostId")]
        public Post Post { get; set; }

        public DateTime CreatedTime { get; set; } = DateTime.Now;
    }
}
