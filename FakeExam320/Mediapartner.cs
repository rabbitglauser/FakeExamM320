namespace ExamM320
{
    public class MediaPartner : Partner
    {
        public EMediaType MediaType { get; }
        public MediaPartner(string name, EMediaType mediaType) : base(name)
        {
            MediaType = mediaType;
        }
    }
}