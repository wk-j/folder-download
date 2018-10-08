// Learn more about F# at http://fsharp.org

open System
let PS = StartProcess.Processor.StartProcess

[<EntryPoint>]
let main argv =
    match argv with
    | [| url; targetDir |] ->
        // https://github.com/dotnet/orleans/tree/master/Samples/2.0
        // https://github.com/dotnet/orleans/trunk/Sample/2.0
        let svn = url.Replace("tree/master", "trunk")
        let command = sprintf """svn export "%s" "%s" """ svn targetDir
        printfn "> %s" command
        PS command
        0
    | _ ->
        printfn "> Invalid argument"
        -1
