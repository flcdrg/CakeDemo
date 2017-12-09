Task("Build")
.Does(() => {
    var settings = new MSBuildSettings()
    {
        Verbosity = Verbosity.Minimal
    };

    MSBuild("CakeDemo.sln", settings);
});

Task("Default")
    .IsDependentOn("Build");

RunTarget("Default");