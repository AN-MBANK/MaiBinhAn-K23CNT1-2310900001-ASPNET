var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.mbalab03>("mbalab03");

builder.Build().Run();
