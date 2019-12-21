call :push CompiledNugetPackages\FhirKhit.Tools.*.nupkg
exit

:push
	dir %1
	rem ExternalProjects\nuget.exe push %1 -Timeout 6000 -ApiKey oy2aradlztknz2nmzk7a6v4z76cn6teu7pkc73ol6ep2ju -Source https://api.nuget.org/v3/index.json -SkipDuplicate
	ExternalProjects\nuget.exe push %1 5b9d07da-eec7-47a2-9703-aa6acc56d058 -Source https://www.myget.org/F/applicadia/api/v2/package
	IF %errorlevel% NEQ 0 GOTO :error
	del CompiledNugetPackages\*.nupkg
	del CompiledNugetPackages\*.snupkg
	exit
	
:error
	echo "*"
	echo "* nuget push failed "
	echo "*"
	pause
	exit /b
	
	
