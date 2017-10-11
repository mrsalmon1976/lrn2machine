#r "../packages/MathNet.Numerics.3.20.0/lib/net40/MathNet.Numerics.dll"
#r "../packages/Accord.3.7.0/lib/net40/Accord.dll"
#r "../packages/Accord.Statistics.3.7.0/lib/net40/Accord.Statistics.dll"
#r "../packages/Accord.Math.3.7.0/lib/net40/Accord.Math.dll"
open MathNet.Numerics.Statistics
open Accord
open Accord.Statistics.Models.Regression.Linear

let input = [|1,1.;2,2.;3,2.25;4,4.75;5,5.|]

let x = input |> Array.map (fun (x,y) -> float x)
let y = input |> Array.map (fun (x,y) -> y)
let regression = SimpleLinearRegression()

let sse = regression.Regress(x,y)
let intercept = regression.Intercept
let slope = regression.Slope
let mse = sse/float x.Length
let rmse = sqrt mse
let r2 = regression.CoefficientOfDetermination(x,y)

