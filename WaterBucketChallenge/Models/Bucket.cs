using WaterBucketChallenge.Interfaces;

namespace WaterBucketChallenge.Models
{
    public class Bucket:IBucket
    {
        public Bucket()
        {
          
        }
        private string _name;
        private int _capacity;
        private int _quantity;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int GallonCapacity { 
            get
            {
                return _capacity;
            }
            set 
            { 
                _capacity = value;
            }
        }
        public int GallonQuantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }


        public void Empty(List<Response> response, Bucket b1, Bucket b2)
        {            
            _quantity = 0;
            response.Add(new Response { Step = response.Count + 1,
                bucketX = b1.Name == "X" ? b1.GallonQuantity : b2.GallonQuantity,
                bucketY = b2.Name == "Y" ? b2.GallonQuantity : b1.GallonQuantity,
                Action = $"Empty bucket {_name}" });
        }

        public void Fill(int gallons, List<Response> response, Bucket b1, Bucket b2)
        {
            _quantity = gallons;
            response.Add(new Response { Step = response.Count + 1,
                bucketX = b1.Name == "X" ? b1.GallonQuantity : b2.GallonQuantity,
                bucketY = b2.Name == "Y" ? b2.GallonQuantity : b1.GallonQuantity, 
                Action = $"Fill bucket {_name}" });
        }

        public void Transfer(Bucket receiver, int gallons, List<Response> response, Bucket b1, Bucket b2)
        {
            if (_capacity > receiver.GallonCapacity)
                gallons = receiver.GallonCapacity;
           // gallons =  receiver.GallonCapacity - receiver.GallonQuantity;
            
            if (receiver.GallonQuantity + gallons > receiver.GallonCapacity)
            {
                receiver.Empty(response, b1, b2);
                
            }

            else
            {
                receiver.GallonQuantity += gallons;
                _quantity -= gallons;
                response.Add(new Response { Step = response.Count + 1, 
                    bucketX = b1.Name == "X" ? b1.GallonQuantity : b2.GallonQuantity,
                    bucketY = b2.Name == "Y" ? b2.GallonQuantity : b1.GallonQuantity, 
                    Action = $"Transfer from bucket {_name} to {receiver.Name}" });
            }
            
        }

       /* public void Process(Bucket b1, Bucket b2, int z, List<Response> responses)
        {
            while (b2.GallonQuantity != z && b1.GallonQuantity != z)
            {
                if (b1.GallonQuantity == 0)
                    b1.Fill(b1.GallonCapacity, responses, b1, b2);
                b1.Transfer(b2, b1.GallonQuantity, responses, b1, b2);

            }
        }*/

    }
}
