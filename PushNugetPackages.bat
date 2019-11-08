call :push CompiledNugetPackages\FhirKhit.Tools.*.nupkg
exit

:push
	dir %1
	ExternalProjects\nuget.exe push %1 -ApiKey oy2aradlztknz2nmzk7a6v4z76cn6teu7pkc73ol6ep2ju -Source https://api.nuget.org/v3/index.json -SkipDuplicate
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
	
	
