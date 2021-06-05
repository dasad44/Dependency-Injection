# Dependency-Injection
Example for Dependency Injection in Console App (like Startup in .Net Core)

> Introduction:
1. Install Microsoft.Extensions.Hosting package in NuGet
2. `CreateHostBuilder` function is pretending Startup function in ASP.NET Core - we put there all dependencies
3. Lines
`
var host = CreateHostBuilder(args).Build();
host.Services.GetRequiredService<Program>().Run();
`are configuration for our dependency injection
