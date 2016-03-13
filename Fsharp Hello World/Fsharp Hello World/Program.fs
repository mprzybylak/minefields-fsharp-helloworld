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

let simpleList = [1;2;3]
let simpleRange = [1..10]
let simpleArray = [|1;2;3|]

type PersonRecord = 
    {   Name: string;
        Surname: string;
        Age: int32; }

let person = 
    {   Name = "Jan";
        Surname = "Kowalski";
        Age = 32; }

let secondPerson = { person with Name = "Jaroslaw"}

type Foo = 
    {   FieldA: string;
        FieldB: string; }

type DuplicatedFoo = 
    {   FieldA: string;
        FieldB: int32; } // all records with FieldA and FieldB will be infered as DuplicatedFoo because DuplicatedFoo is defined later than Foo

let fooObject:Foo = // explicit type definition 
    {   FieldA = "a";
        FieldB = "b"; }

let secondFooObject = 
    {   FieldA = "aa";
        Foo.FieldB = "bb"; } // explicit one field definition is enough to infer this record as Foo, not DuplicatedFoo

[<EntryPoint>]
let main argv = 
    printfn "hello world %d %d %s %d 3+2=%i 3-2=%d custom operation 3+3=%d" lucky unlucky duplicate mutableValue (add 3 2) (sub(3,2)) (operation 3 3 add)
    printfn "lambda add 3+4 = %d" (operation 3 4 (fun x y->x+y))
    printfn "list: %A list from range: %A, range and map call: %A" simpleList simpleRange (List.map (fun x->x*2) simpleList)
    printfn "many calls to List module functions: %A" (List.map (fun x->x*2) (List.filter (fun x -> x % 2 = 0) simpleRange))
    printfn "many calls to List module with foward pipe operator: %A" (simpleRange |> List.filter (fun x -> x % 2 = 0) |> List.map (fun x -> x *2))
    printfn "simple array: %A" simpleArray
    printfn "simple record: %A" person
    printfn "select field from record: %s" person.Name
    printfn "record creation based on other record %A" secondPerson
    System.Console.ReadLine() |> ignore
    0 // return an integer exit code

