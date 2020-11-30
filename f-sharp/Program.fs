open System

let foo x = x * 2

let bar y = y + y

[<EntryPoint>]
let main argv =
    foo 5 |> printfn "We ran foo and got %A"
    bar 10 |> printfn "Then we ran bar and got %A"
    0 // return an integer exit code

