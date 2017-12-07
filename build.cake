Task("Default")
.Does(() => {

    MSBuild("CakeDemo.sln");
});

RunTarget("Default");