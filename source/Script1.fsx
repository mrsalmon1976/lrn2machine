let x = "Hello World"
let ints = [|1;2;3;4;5;6|]
let multipleByTwo x = x * 2
let multiplied = ints |> Array.map (fun i -> i * 3)
let multiplied' = ints |> Array.map (fun i -> multipleByTwo i)

let isEven x = 
    match x % 2 = 0 with
    | true -> "even"
    | false -> "odd"
let multipliedAndIsEven = 
    ints
    |> Array.map (fun i -> multipleByTwo i)
    |> Array.map (fun i -> isEven i)

let a2 = isEven 5






