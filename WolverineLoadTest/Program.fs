// For more information see https://aka.ms/fsharp-console-apps
open JasperFx
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Hosting
open Wolverine
open Wolverine.FluentValidation
open WolverineLoadTest

module Program =
    let createHostBuilder args =
        let builder = Host.CreateDefaultBuilder(args)


        builder.ConfigureServices(fun context services ->

            services.AddWolverine(fun opts ->
                opts.UseFluentValidation() |> ignore
                (*
                opts.MultipleHandlerBehavior <- MultipleHandlerBehavior.Separated
                *)
                ) |> ignore
            services.AddHostedService<ConsoleService>() |> ignore )

    [<EntryPoint>]
    let main args =
        let host = createHostBuilder(args).Build()
        host.RunJasperFxCommandsSynchronously(args) |> ignore
        0
