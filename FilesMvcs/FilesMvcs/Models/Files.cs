namespace FilesMvcs.Models
{
    public class Files
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public byte[] Data { get; set; }
        public long length { get; set; }
        public string ContentType { get; set; }
    }
}
