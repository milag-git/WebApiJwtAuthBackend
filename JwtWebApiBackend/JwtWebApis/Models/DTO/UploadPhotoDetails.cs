namespace JwtWebApis.Models.DTO
{
    public class UploadPhotoDetails
    {
        /// helpful in combination with @key to make list rendering more efficient
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String ContentType { get; set; }
        public Int64 Size { get; set; }
        public Byte[] Content { get; set; }
        public String ImageDataUrl { get; set; }

        public UploadPhotoDetails()
        {
            Id = Guid.NewGuid();
        }

    }
}
