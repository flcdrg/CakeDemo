#tool nuget:?package=NUnit.ConsoleRunner

#r "C:\dev\git\CakeDemo\CakeDemoAddin\bin\Debug\CakeDemoAddin.dll"

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

Task("Logging")
.Does(() => {
    WriteArgumentsEvent("CakeDemo", "Starting build");
});

Task("Default")
    .IsDependentOn("Logging")
    .IsDependentOn("Build")
    .IsDependentOn("Tests");

RunTarget("Default");