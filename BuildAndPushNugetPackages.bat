@rem enter this directory
cd /d %~dp0
set NUGET=ExternalProjects\nuget.exe

del CompiledNugetPackages\*.nupkg

%NUGET% pack Projects\Tools\FhirKhit.Tools\FhirKhit.Tools.csproj -Build -IncludeReferencedProjects -OutputDirectory CompiledNugetPackages
%NUGET% pack Projects\Tools\FhirKhit.Tools.R2\FhirKhit.Tools.R2.csproj -Build -IncludeReferencedProjects -OutputDirectory CompiledNugetPackages
%NUGET% pack Projects\Tools\FhirKhit.Tools.R3\FhirKhit.Tools.R3.csproj -Build -IncludeReferencedProjects -OutputDirectory CompiledNugetPackages
%NUGET% pack Projects\Tools\FhirKhit.Tools.R4\FhirKhit.Tools.R4.csproj -Build -IncludeReferencedProjects -OutputDirectory CompiledNugetPackages


%NUGET% push CompiledNugetPackages\*.nupkg 5b9d07da-eec7-47a2-9703-aa6acc56d058 -Source https://www.myget.org/F/applicadia/api/v2/package
prompt
