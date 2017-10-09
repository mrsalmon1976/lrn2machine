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

let standardDeviation values = 
    sqrt (variance values)

let x = input |> Seq.map (fun (x,y) -> float x)
let y = input |> Seq.map (fun (x,y) -> y)

let mX = Seq.average x
let mY = Seq.average y
let sX = standardDeviation x
let sY = standardDeviation y


