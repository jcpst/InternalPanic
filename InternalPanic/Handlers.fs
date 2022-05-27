module InternalPanic.Handlers

open Microsoft.AspNetCore.Http
open Giraffe
open InternalPanic.Views

let homeHandler =
    fun (next: HttpFunc) (ctx: HttpContext) ->
        Home.homeView |> Layout.htmlLayout |> htmlView <|| (next, ctx)

let healthcheckHandler =
    fun (next: HttpFunc) (ctx: HttpContext) ->
        ctx.SetStatusCode 200
        text "ok" next ctx

let swapHandler =
    fun (next: HttpFunc) (ctx: HttpContext) ->
        Partials.swapView |> htmlView <|| (next, ctx)
