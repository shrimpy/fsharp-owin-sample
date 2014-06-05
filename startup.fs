namespace Server

open Owin
open Microsoft.Owin

type Startup() =
    member x.Configuration(app: Owin.IAppBuilder) =
        app.Run(fun ctx ->
            ctx.Response.ContentType <- "text/plain"
            ctx.Response.WriteAsync("Owin Sample with F#")
        ) |> ignore

[<assembly: OwinStartup(typeof<Startup>)>]
do ()