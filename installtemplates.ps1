git pull
Remove-Item -Recurse -Force obj
Remove-Item -Recurse -Force bin
dotnet new -u DPL.DotNetNew.Templates
dotnet pack
dotnet new -i bin/Debug/DPL.DotNetNew.Templates.*.nupkg