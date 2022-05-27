module InternalPanic.Views.Layout

open Giraffe.ViewEngine

let private head =
    head [] [
        meta [ _charset "utf-8" ]
        meta [ _name "viewport"
               _content "width=device-width, initial-scale=1" ]
        title [] [ str "Internal Panic" ]
        link [ _rel "stylesheet"
               _href "css/pico.min.css" ]
        link [ _rel "stylesheet"
               _href "css/style.css" ]
        script [ _src "js/htmx.js"; _defer ] []
    ]

let private nav =
    nav [ _class "container-fluid" ] [
        ul [] [
            li [] [
                a [ _href "./"
                    _class "contrast"
                    _onclick "event.preventDefault()" ] [
                    strong [] [ str "Internal Panic" ]
                ]
            ]
        ]
        ul [] [
            li [] [
                details [ attr "role" "list"; _dir "rtl" ] [
                    summary [ attr "aria-haspopup" "listbox"
                              attr "role" "link"
                              _class "contrast" ] [
                        str "Menu"
                    ]
                    ul [ attr "role" "listbox" ] [
                        li [] [ str "1" ]
                        li [] [ str "2" ]
                        li [] [ str "3" ]
                    ]
                ]
            ]
        ]
    ]

let htmlLayout (content: XmlNode list) =
    html [] [
        head
        body [] [
            div [ _class "hero"
                  attr "data-theme" "dark" ] [
                nav
                header [ _class "container" ] []
            ]
            main [ _class "container" ] [
                div [ _class "grid" ] [
                    div [] content
                    aside [] [ p [] [ str "yup" ] ]
                ]
            ]
        ]
    ]
