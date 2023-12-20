namespace ReviewService
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int MovieId { get; set; }
        public string Header { get; set; }

        public string ReviewText { get; set; }
    }
}
