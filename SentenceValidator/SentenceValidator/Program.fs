open System

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

let noun str = match str with
    |"dog" -> true
    |"cat" -> true
    |"mouse" -> true
    |"tree" -> true
    |"cheese" -> true
    |_ -> false

let verb str = match str with
    |"likes" -> true
    |"eats" -> true
    |"chases" -> true
    |_ -> false

let rec stringProcessor (str:string) (index:int) =
    if str.[index] = ' ' then index
    else (stringProcessor str (index+1))
    
let rec processList lst index = 
    let output = match lst with
        |x::xs -> 
            (index, (stringProcessor x 0))
    output

[<EntryPoint>]
let main argv = 
    let argList = 
        List.ofArray argv
    let tupleList = 
        processList argList 0
    0 // return an integer exit code

