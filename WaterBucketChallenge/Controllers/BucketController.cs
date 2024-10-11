using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WaterBucketChallenge.Models;
using WaterBucketChallenge.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WaterBucketChallenge.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BucketController : ControllerBase
    {

        // POST api/<BucketController>
        [HttpPost]
        public string Post([FromBody] WaterJug waterJugs)
        {
            if (!ModelState.IsValid)
            {
                return JsonSerializer.Serialize(BadRequest(ModelState));
            }

            if (( waterJugs.z_amount_wanted % waterJugs.x_capacity == 0 || waterJugs.z_amount_wanted % waterJugs.y_capacity == 0) 
                &&(waterJugs.x_capacity >= waterJugs.z_amount_wanted || waterJugs.y_capacity >= waterJugs.z_amount_wanted))
            {

                List<Response> responses = new List<Response>();
                Bucket x = new Bucket { GallonCapacity = waterJugs.x_capacity, Name = "X" };
                Bucket y = new Bucket { GallonCapacity = waterJugs.y_capacity, Name = "Y" };
                BucketRepository bucketRepository = new BucketRepository();
                if (Math.Abs(waterJugs.x_capacity - waterJugs.z_amount_wanted) < Math.Abs(waterJugs.y_capacity - waterJugs.z_amount_wanted))
                    bucketRepository.Process(x, y, waterJugs.z_amount_wanted, responses);
                else
                    bucketRepository.Process(y, x, waterJugs.z_amount_wanted, responses);
                return JsonSerializer.Serialize(responses);
            }

            else
            {
                return JsonSerializer.Serialize("No Solution");
            }
        }


    }
}
