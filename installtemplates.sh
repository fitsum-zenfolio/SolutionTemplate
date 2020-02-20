git pull
rm -rf obj
rm -rf bin
dotnet new -u DPL.DotNetNew.Templates
dotnet pack
dotnet new -i bin/Debug/DPL.DotNetNew.Templates.*.nupkg