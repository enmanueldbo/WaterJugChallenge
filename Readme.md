# Water Jug Challenge

This API can resolve the water jug challenge and return step by step all the actions of the jugs.

## Install
1. Clone The Repository:
   ```bash
   git clone https://github.com/enmanueldbo/WaterJugChallenge.git

## Running project
```bash
1. Run the project

## Api
1. Request parameters:
 ```bash
 x_capacity, y_capacity, z_amount_wanted.
2. Response format:
```bash
Json.

## EndPoints
1. Post:
```bash
Resolve the challenge and return a Json with all the actions made for the buckets step by step.

## Algorithm
1. Verify if is parameters are ok.
2. Verify if the challenge can be resolve.
3. Analyze who is the better options to transfer the water for looking who is the one closer to the amount wanted.