namespace WebApplication1.Models
{
    public class AnhBacSi
    {
        public Guid BacsiAnhId { get; set; }
        public Guid BacsiId { get; set; }
        public byte[] AnhData { get; set; }

        public virtual BacSi BacSi { get; set; }
    }
}
