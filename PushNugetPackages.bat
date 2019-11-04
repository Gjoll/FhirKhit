@rem enter this directory
cd /d %~dp0
set NUGET=ExternalProjects\nuget.exe

%NUGET% push Projects\Tools\FhirKhit.Tools\bin\Debug\*.nupkg 5b9d07da-eec7-47a2-9703-aa6acc56d058 -Source https://www.myget.org/F/applicadia/api/v2/package

%NUGET% push Projects\Tools\FhirKhit.Tools.R2\bin\Debug\*.nupkg 5b9d07da-eec7-47a2-9703-aa6acc56d058 -Source https://www.myget.org/F/applicadia/api/v2/package


%NUGET% push Projects\Tools\FhirKhit.Tools.R3\bin\Debug\*.nupkg 5b9d07da-eec7-47a2-9703-aa6acc56d058 -Source https://www.myget.org/F/applicadia/api/v2/package


%NUGET% push Projects\Tools\FhirKhit.Tools.R4\bin\Debug\*.nupkg 5b9d07da-eec7-47a2-9703-aa6acc56d058 -Source https://www.myget.org/F/applicadia/api/v2/package

del Projects\Tools\FhirKhit.Tools\bin\Debug\*.nupkg
del Projects\Tools\FhirKhit.Tools.R2\bin\Debug\*.nupkg
del Projects\Tools\FhirKhit.Tools.R3\bin\Debug\*.nupkg
del Projects\Tools\FhirKhit.Tools.R4\bin\Debug\*.nupkg

prompt
