#r "../packages/MathNet.Numerics.3.20.0/lib/net40/MathNet.Numerics.dll"
open MathNet.Numerics.Statistics

let input = [|1,1.;2,2.;3,2.25;4,4.75;5,5.|]

let x = input |> Array.map (fun (x,y) -> float x)
let y = input |> Array.map (fun (x,y) -> y)

let mX = Array.average x
let mY = Array.average y

let sX = ArrayStatistics.StandardDeviation x
let sY = ArrayStatistics.StandardDeviation y
let r = Correlation.Pearson (x,y)

let b = r*(sY/sX)
let A = mY - b*mX
