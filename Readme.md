# Water Jug Challenge

This API can resolve the water jug challenge and return step by step all the actions of the jugs.

## Install
1. Clone The Repository:
   ```bash
   git clone https://github.com/enmanueldbo/WaterJugChallenge.git

## Running project
1. Run the project

## Api
1. Request parameters: x_capacity, y_capacity, z_amount_wanted.
2. Response format: Json.

## EndPoints
1. Post: Resolve the challenge and return a Json with all the actions made for the buckets step by step.

## Algorithm
1. Verify if is parameters are ok.
2. Verify if the challenge can be resolve.
3. Analyze who is the better options to transfer the water for looking who is the one closer to the amount wanted.

## Examples
1. 
Sample Payload JSON: POST
{
    "x_capacity":2,
    "y_capacity":30,
    "z_amount_wanted":26
}
Sample Response JSON
[{"Step":1,"bucketX":0,"bucketY":30,"Solved":false,"Action":"Fill bucket Y"},{"Step":2,"bucketX":2,"bucketY":28,"Solved":false,"Action":"Transfer from bucket Y to X"},{"Step":3,"bucketX":0,"bucketY":28,"Solved":false,"Action":"Empty bucket X"},{"Step":4,"bucketX":2,"bucketY":26,"Solved":false,"Action":"Transfer from bucket Y to X. Solved"}]
2. 
Sample Payload JSON: POST
{
    "x_capacity":30,
    "y_capacity":2,
    "z_amount_wanted":26
}
Sample Response JSON
[{"Step":1,"bucketX":30,"bucketY":0,"Solved":false,"Action":"Fill bucket X"},{"Step":2,"bucketX":28,"bucketY":2,"Solved":false,"Action":"Transfer from bucket X to Y"},{"Step":3,"bucketX":28,"bucketY":0,"Solved":false,"Action":"Empty bucket Y"},{"Step":4,"bucketX":26,"bucketY":2,"Solved":false,"Action":"Transfer from bucket X to Y. Solved"}]