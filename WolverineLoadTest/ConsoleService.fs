namespace WolverineLoadTest

open System
open System.Threading
open System.Threading.Tasks
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Hosting
open Wolverine
open WolverineLoadTest.MyEvent

type ConsoleService(serviceProvider: IServiceProvider) =
    interface IHostedService with
        member this.StartAsync(cancellationToken: CancellationToken) : Task =
            task {

                let scope = serviceProvider.CreateScope()
                let bus = scope.ServiceProvider.GetService<IMessageBus>()
                let command: MyEvent =
                    {
                        Id = 1
                        Name = "Test Event"
                    }
                do! bus.PublishAsync(command)

            }

        member this.StopAsync(cancellationToken) = Task.CompletedTask