namespace WolverineLoadTest

open Wolverine
open Wolverine.Attributes
open WolverineLoadTest.MyEvent

(*
[<StickyHandler("EventSecondHandler")>]
*)
module EventSecondHandler =
    let LoadAsync (event: MyEvent) =
        task {

            let handlerContinuation = HandlerContinuation.Continue

            return struct (handlerContinuation, 2, 3)
        }
    let Handle (event: MyEvent, v: int) =
        printfn "Handling event with Id: %d and Name: %s and value: %d" event.Id event.Name v 
        // Add your event handling logic here
        ()

