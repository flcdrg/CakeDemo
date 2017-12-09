Task("Build")
.Does(() => {
    var settings = new MSBuildSettings()
    {
        Verbosity = Verbosity.Minimal
    };

    MSBuild("CakeDemo.sln", settings);
});

Task("Tests")
.Does(() => {
    NUnit3(@"**/bin/*/*Tests.dll");
});

Task("Default")
    .IsDependentOn("Build");

RunTarget("Default");