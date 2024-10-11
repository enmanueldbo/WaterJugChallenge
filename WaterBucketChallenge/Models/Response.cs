namespace WaterBucketChallenge.Models
{
    public class Response
    {
        public int Step { get; set; }
        public int bucketX { get; set; }
        public int bucketY { get; set; }
        public bool Solved { get; set; }

        public string Action { get; set; }

    }
}
