﻿// Learn more about F# at http://fsharp.org

open System
open Suave
open App

let hostName = System.Net.IPAddress.Parse "0.0.0.0"

DotLiquid.setTemplatesDir (__SOURCE_DIRECTORY__)

[<EntryPoint>]
let main argv =
    startWebServer { defaultConfig with bindings = [ HttpBinding.create HTTP hostName 8080us ] } App.Router
    0 // return an integer exit code