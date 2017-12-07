Task("Default")
.Does(() => {
    var settings = new MSBuildSettings()
    {
        Verbosity = Verbosity.Minimal
    };

    MSBuild("CakeDemo.sln", settings);
});

RunTarget("Default");