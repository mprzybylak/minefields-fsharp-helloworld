// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.


let add x y = x + y
let inc = add 1     // currying is used here inc is a add function with only first argument applied, so we can pass one argument to inc at it will be passed as 2nd to add

// sometimes it is difficult to use currying, because we might want to apply only second argument and let apply first later 
// (eg. when we want to delcare dec in terms of sub)
// we might need additional step of swapping arguments
let sub x y = x - y
let swapargs f x y = f y x
let dec = swapargs sub 1


[<EntryPoint>]
let main argv = 
    printfn "inc 10 = %i" (inc 10)
    printfn "dec 10 = %i" (dec 10)
    System.Console.ReadLine() |> ignore
    0 // return an integer exit code


    