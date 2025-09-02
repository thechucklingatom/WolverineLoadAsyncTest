namespace WolverineLoadTest

open WolverineLoadTest.MyEvent

module EventSecondHandler =
    let Handle (event: MyEvent) =
        printfn "Handling event with Id: %d and Name: %s" event.Id event.Name
        // Add your event handling logic here
        ()

