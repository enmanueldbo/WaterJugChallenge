using WaterBucketChallenge.Models;

namespace WaterBucketChallenge.Interfaces
{
    public interface IBucket
    {
        public void Fill(int gallons, List<Response> response, Bucket x, Bucket y);
        public void Empty(List<Response> responses, Bucket x, Bucket y);
        public void Transfer(Bucket receiver, int gallons, List<Response> response, Bucket x, Bucket y);

    }
}
