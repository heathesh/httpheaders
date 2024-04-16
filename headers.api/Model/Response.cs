namespace headers.api.Model;

public class Response
{
    public required Dictionary<string, string> Headers { get; set; }

    public required string Message { get; set; }
}