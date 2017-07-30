var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");
 
///    Build Variables
var projDir = "./WebApiCore/";
var testDir = "./WebApiCore.Tests/WebApiCore.Tests.csproj";
var binDir = String.Concat(projDir, "bin");
var projJson = String.Concat(projDir, "project.json");
var solutionFile = "WebApiCore.sln";
var outputDir = "./build/";
 
var buildSettings = new DotNetCoreBuildSettings
     {
         Framework = "netcoreapp1.1",
         Configuration = "Release",
         OutputDirectory = outputDir
     };

Task("Build").Does(() =>{
    DotNetCoreBuild(projDir, buildSettings);
});

Task("Test")
    .IsDependentOn("Build")
    .Does(() =>
    {
        DotNetCoreTest(testDir);
    });

Task("Default")
    .IsDependentOn("Test");

RunTarget(target);
