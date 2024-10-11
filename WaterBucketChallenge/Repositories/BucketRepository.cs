using WaterBucketChallenge.Models;

namespace WaterBucketChallenge.Repositories
{
    public class BucketRepository
    {
        public void Process(Bucket b1, Bucket b2, int z, List<Response> responses)
        {
            while (b2.GallonQuantity != z && b1.GallonQuantity != z)
            {
                if (b1.GallonQuantity == 0)
                    b1.Fill(b1.GallonCapacity, responses, b1, b2);
                b1.Transfer(b2, b1.GallonQuantity, responses, b1, b2);

            }
            responses.First(x => x.Step == responses.Count).Action += ". Solved";
        }

    }
}
