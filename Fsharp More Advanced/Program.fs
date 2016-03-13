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

let (><) x y = x * y    // custom operator example

// operator within type
type Point(x:int32, y:int32) = 
    member this.x = x;
    member this.y = y;
    static member (+)(p1:Point, p2:Point) = new Point(p1.x + p2.x, p1.y + p2.y)

let p1,p2 = new Point(2,2), new Point(3,4)
let p3 = p1 + p2

[<EntryPoint>]
let main argv = 
    printfn "inc 10 = %i" (inc 10)
    printfn "dec 10 = %i" (dec 10)
    printfn "10><2=%d" (10><2)
    printfn "x=2,y=2 + x=3,y=4 = x=%i,y=%i" p3.x p3.y
    System.Console.ReadLine() |> ignore
    0 // return an integer exit code


    