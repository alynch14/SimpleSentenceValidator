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


[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code

