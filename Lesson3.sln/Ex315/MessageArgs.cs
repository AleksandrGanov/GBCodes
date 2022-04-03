namespace Ex315
{

    public abstract class Content { }

    public class Document : Content { }

    public class Image : Content { }

    public class Audio : Content { }

    public class MessageArgs
    {
        public string Message { get; set; }
        public int Id { get; set; }
        public Content[] Contents { get; set; }

    }
}
