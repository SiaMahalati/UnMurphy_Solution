var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.UM_BL_Estimate>("um-bl-estimate");

builder.Build().Run();
