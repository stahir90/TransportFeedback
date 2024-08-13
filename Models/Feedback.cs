namespace TransportFeedback.Models
{
    public class Feedback
    {
        public int Id { get; set; }  // Capitalized 'Id'
        public string? TransportType { get; set; } // Bus, Train, Ferry
        public string? RouteNumber { get; set; }
        public DateTime TravelDate { get; set; }
        public required string Comments { get; set; }
        public bool IsResolved { get; set; } = false;
        public string? ContactInfo { get; set; } // Optional
    }
}