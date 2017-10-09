// Learn more about F# at http://fsharp.org. See the 'F# Tutorial' project
// for more guidance on F# programming.

#load "Library1.fs"
open Chapter2

// Define your library scripting code here
let input = [|1,1.;2,2.;3,2.25;4,4.75;5,5.|]
let variance (source:float seq) = 
    let mean = Seq.average source
    let deltas = Seq.map (fun x -> pown (x-mean) 2) source
    Seq.average deltas

// standard deviation - a quantity expressing by how much the members of a group differ from the mean value for the group
let standardDeviation values = 
    sqrt (variance values)

let x = input |> Seq.map (fun (x,y) -> float x)
let y = input |> Seq.map (fun (x,y) -> y)

let mX = Seq.average x
let mY = Seq.average y
let sX = standardDeviation x
let sY = standardDeviation y

// Pearson's correlation - a measure of the linear correlation between two variables X and Y. 
// It has a value between +1 and −1, where 1 is total positive linear correlation, 0 is no linear correlation, and −1 is total negative linear correlation.
let pearsonsCorrelation(a:float seq, b:float seq) = 
    let mX = Seq.average a
    let mY = Seq.average b
    
    let x = a |> Seq.map (fun x -> x - mX)
    let y = b |> Seq.map (fun y -> y - mY)

    let xys = Seq.zip x y
    let xy = xys |> Seq.map (fun (x, y) -> x*y, x*x, y*y)
    let sxy = xy |> Seq.sumBy (fun (xy, x2, y2) -> xy)
    let sx2 = xy |> Seq.sumBy (fun (xy, x2, y2) -> x2)
    let sy2 = xy |> Seq.sumBy (fun (xy, x2, y2) -> y2)
    sxy / sqrt (sx2*sy2)

let r = pearsonsCorrelation (x, y)

let b = r*(sY/sX)
let A = mY - b*mX


