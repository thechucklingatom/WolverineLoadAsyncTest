namespace WolverineLoadTest

open Wolverine
open WolverineLoadTest.MyEvent

module EventFirstHandler =
    let LoadAsync (event: MyEvent) =
        task {

            let handlerContinuation = HandlerContinuation.Continue

            return struct (handlerContinuation, 1)
        }
    let Handle (event: MyEvent) =
        printfn "Handling event with Id: %d and Name: %s" event.Id event.Name
        // Add your event handling logic here
        ()

