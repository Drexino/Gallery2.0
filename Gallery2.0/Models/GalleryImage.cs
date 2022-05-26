namespace Gallery2._0.Models
{
    public class GalleryImage
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual IEnumerable<ImageTags> Tags { get; set; }

    }
}
