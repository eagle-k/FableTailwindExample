module App

// CSS Settings
open Zanaptak.TypedCssClasses

type tailwind =
    CssClasses<"src/tailwind.css", Naming.CamelCase, commandFile="node", argumentPrefix="tailwind.process.js tailwind.config.js", resolutionFolder="./">


// CSS import
open Fable.Core

JsInterop.importSideEffects "./tailwind.css"


// DOM manipulation
open Browser.Dom

let appContainer = document.getElementById "app"

let button = document.createElement "button"
button.textContent <- "Button"

button.classList.add [| tailwind.px2
                        tailwind.py1
                        tailwind.bgBlue500
                        tailwind.textWhite
                        tailwind.fontSemibold
                        tailwind.rounded
                        tailwind.hoverBgBlue800 |]

appContainer.appendChild button |> ignore
