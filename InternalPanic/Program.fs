open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Hosting
open Microsoft.Extensions.Logging
open Giraffe
open Westwind.AspNetCore.LiveReload
open InternalPanic.App

let configureApp (app: IApplicationBuilder) =
    app
        .UseStaticFiles()
        .UseResponseCaching()
        .UseGiraffe webApp

let configureServices (services: IServiceCollection) =
    services
        .AddLiveReload()
        .AddResponseCaching()
        .AddGiraffe()
    |> ignore

let configureLogging (loggerBuilder: ILoggingBuilder) =
    loggerBuilder
        .AddFilter(fun lvl -> lvl.Equals LogLevel.Error)
        .AddConsole()
        .AddDebug()
    |> ignore

[<EntryPoint>]
let main _ =
    Host
        .CreateDefaultBuilder()
        .ConfigureWebHostDefaults(fun webHostBuilder ->
            webHostBuilder
                .Configure(configureApp)
                .ConfigureServices(configureServices)
                .ConfigureLogging(configureLogging)
            |> ignore)
        .Build()
        .Run()

    0
