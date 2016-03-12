// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

let lucky = 3 + 4 // 'let' binds name to value
let unlucky = lucky + 3
let duplicate = "1"
//let duplicate = "2" - 'let' creates immutable bindings

let mutable mutableValue = 10 // mutable allows to create mutable bindings
mutableValue <- 12 // <- assigment operator

let add x y =   // function definition
    x + y       // function body always intended

let sub(x:int32, y:int32) =     // function definition with type annotation (dosen't need in this case)
    x - y

// passing functions to functions
let operation a b oper = 
    oper a b

[<EntryPoint>]
let main argv = 
    printfn "hello world %d %d %s %d 3+2=%i 3-2=%d custom operation 3+3=%d" lucky unlucky duplicate mutableValue (add 3 2) (sub(3,2)) (operation 3 3 add)
    printfn "lambda add 3+4 = %d" (operation 3 4 (fun x y->x+y))
    System.Console.ReadLine() |> ignore
    0 // return an integer exit code

