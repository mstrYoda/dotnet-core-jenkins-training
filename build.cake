var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");
 
///    Build Variables
var projDir = "./WebApiCore/";
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

Task("Default")
    .IsDependentOn("Build");

RunTarget(target);
