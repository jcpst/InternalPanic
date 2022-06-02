module InternalPanic.Views.Home

open Giraffe.ViewEngine

let homeView =
    [ section [] [
          hgroup [] [
              h2 [] [ str "Sumpin" ]
              h3 [] [ str "Sumpin Else" ]
          ]
          p [] [
              str
                  "Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                  Pellentesque lobortis est vel velit bibendum ultrices.
                  Sed aliquam tortor vel odio fermentum ullamcorper eu vitae neque.
                  Sed non diam at tellus venenatis viverra.
                  Vestibulum et leo laoreet arcu tempor eleifend venenatis ac leo.
                  Pellentesque euismod justo sed nisl sollicitudin varius.
                  Duis venenatis nisl sit amet ante rutrum posuere.
                  Etiam nec ullamcorper leo, sed placerat mauris."
          ]
          figure [] [
              img [ _src "https://source.unsplash.com/B7XNN9uNAh8/1500x750"
                    _alt "Architecture" ]
              figcaption [] [
                  str "Image from "
                  a [ _href "https://unsplash.com/" ] [
                      str "unsplash.com"
                  ]
              ]
          ]
          h3 [] [ str "Then another thing" ]
          p [] [
              str
                  "Pacilisis sed ante ut, posuere volutpat quam.
                  Maecenas maximus blandit mi ac finibus. Proin quis lacinia tellus.
                  Aliquam erat volutpat. Aliquam erat volutpat. Phasellus suscipit
                  nisi augue, id accumsan tortor auctor ut. Duis odio arcu,
                  egestas nec nulla vel, fermentum bibendum ex."
          ]
          h3 [] [
              str "Sed purus sapien, porta a cursus sed, maximus et metus."
          ]
          p [] [
              str
                  "Phasellus molestie ante sed massa bibendum, eget tempus ex
                  sollicitudin. Vestibulum libero nulla, porttitor nec faucibus et,
                  scelerisque eget quam. Nullam finibus tempor dui, vel congue
                  urna condimentum ac. Fusce ultricies mauris justo, nec
                  vulputate mauris pulvinar eu. Sed tempus ligula lorem, at
                  tincidunt risus mollis non. Quisque et turpis sit amet sapien
                  gravida ullamcorper in eu velit. Curabitur luctus ornare finibus.
                  Proin tempor nulla sagittis est fermentum dapibus. Vestibulum
                  posuere mattis congue. Ut porttitor id sem euismod tristique.
                  Quisque mi est, posuere nec lorem eu, vulputate vehicula diam.
                  Nullam scelerisque, libero posuere efficitur bibendum, urna odio
                  finibus lorem, sed volutpat dolor ligula in dolor. Suspendisse
                  suscipit efficitur neque, ut porta tellus mollis vel. Nam consequat
                  arcu ac tellus porta, nec egestas orci sodales."
          ]
      ] ]
