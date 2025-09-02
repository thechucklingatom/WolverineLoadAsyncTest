// For more information see https://aka.ms/fsharp-console-apps
open JasperFx
open Microsoft.Extensions.Hosting
open Wolverine
open Wolverine.FluentValidation

module Program =
    let createHostBuilder args =
        let builder = Host.CreateDefaultBuilder(args)


        builder.ConfigureServices(fun context services ->

            services.AddWolverine(fun opts ->
                opts.UseFluentValidation() |> ignore )
            |> ignore)

    [<EntryPoint>]
    let main args =
        let host = createHostBuilder(args).Build()
        host.RunJasperFxCommandsSynchronously(args)
