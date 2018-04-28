open System
open System.Security.Cryptography.X509Certificates

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

let mutable errorMessage = " "

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
    
let adjective str = match str with
    |"fast" -> true
    |"slow" -> true
    |"furry" -> true
    |"yellow" -> true
    |_ -> false
    
let adverb str = match str with
    |"quickly" -> true
    |"slowly" -> true
    |"quietly" -> true
    |_ -> false

let article str = match str with
    |"a" -> true
    |"the" -> true
    |_ -> false

let conjunction str = match str with
    |"and" -> true
    |"or" -> true
    |_ -> false

let preposition str = match str with
    |"of" -> true
    |"around" -> true
    |_ -> false

let eos str = match str with
    |"." -> true
    |"!" -> true
    |_ -> false

let comma str = match str with
    |"," -> true
    |_ -> false

let rec processNounPhrase lst = 
    if noun (List.head lst) then true
    elif List.isEmpty(List.tail lst) then 
        errorMessage <- "You did not enter a noun into one of your noun phrases."
        false
    else processNounPhrase (List.tail lst)



let rec adjList lst =
    if not(adjective (List.head lst)) then 
        errorMessage <- "Invalid word in adjective list." 
        false
    elif List.isEmpty(List.tail lst) then adjList (List.tail lst)
    else true

let rec nounPhrase lst = 
    if noun (List.head lst) then true
    else 
        let index = List.findIndex(List.contains(processNounPhrase lst ))
        

    
let rec processString lst =
    if verb (List.head lst) then List.head lst
    else processString (List.tail lst)

let stringProcessor lst = 
    let indexToBeSplitAt = 
        List.findIndex(List.contains(processString lst))
    indexToBeSplitAt
    
let main () = 
    Console.Write("Please enter a sentence to be processed: ")
    let sentence = Console.ReadLine()
    let list = List.ofArray(sentence.Split ' ')
    stringProcessor list



