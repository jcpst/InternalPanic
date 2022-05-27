module InternalPanic.App

open Microsoft.AspNetCore.Http
open Giraffe
open InternalPanic.Handlers

let webApp: (HttpFunc -> HttpContext -> HttpFuncResult) =
    choose [ route "/"            >=> GET  >=> homeHandler
             route "/healthcheck" >=> GET  >=> healthcheckHandler
             route "/swappy"      >=> POST >=> swapHandler ]
