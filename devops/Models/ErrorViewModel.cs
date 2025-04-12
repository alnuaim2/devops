namespace devops.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }
         public string? RequestId2 { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
