namespace GameDataParser.Model
{
    public class VideoGame
    {
        public string Title { get; init; }
        public int ReleaseYear { get; init; }
        public decimal Rating { get; init; }
    
        public VideoGame(string title, int releaseYear, decimal rating)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Rating = rating;
        }
    
        public override string ToString()
        {
            return $"{Title}, released in {ReleaseYear}, rating: {Rating}";
        }
    }
}