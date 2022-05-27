module InternalPanic.Views.Partials
open Giraffe.ViewEngine

let swapView =
    div [ _id "swapy" ] [
        p [] [ str "I told ya this was cool" ]
    ]