namespace WolverineLoadTest

open Wolverine
open Wolverine.Attributes
open WolverineLoadTest.MyEvent

(*
[<StickyHandler("EventFirstHandler")>]
*)
module EventFirstHandler =
    (*
    type internal Marker = interface end
    let t = typeof<Marker>.DeclaringType
    *)
    
    let LoadAsync (event: MyEvent) =
        task {

            let handlerContinuation = HandlerContinuation.Continue

            return struct (handlerContinuation, 1)
        }
    let Handle (event: MyEvent, v: int) =
        printfn "Handling event with Id: %d and Name: %s and value: %d" event.Id event.Name v 
        // Add your event handling logic here
        ()

