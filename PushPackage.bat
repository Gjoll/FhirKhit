@rem enter this directory
cd /d %~dp0
set NUGET=..\..\ExternalProjects\nuget.exe
%NUGET% push CompiledNugetPackages\*.nupkg 5b9d07da-eec7-47a2-9703-aa6acc56d058 -Source https://www.myget.org/F/applicadia/api/v2/package

del CompiledNugetPackages\*.nupkg
