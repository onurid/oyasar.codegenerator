@echo off

title OYASAR SLN ENVIRONMENT GENERATOR
echo "# <====== OYASAR SLN ENVIRONMENT GENERATOR ======>"
echo #
if "%1"=="" (
echo "Args is empty! So, run by args (Ex: GenerateSln.bat WebProjectName)"
pause
exit
)


mkdir %1
cd %1

mkdir %1.Core
cd %1.Core
dotnet new classlib
dotnet add package oyasar.framework.core
cd ..

mkdir %1.Business
cd %1.Business
dotnet new classlib
dotnet add reference ../%1.Core/%1.Core.csproj
cd ..

mkdir %1.Core.Repository
cd %1.Core.Repository
dotnet new classlib
dotnet add reference ../%1.Core/%1.Core.csproj
cd ..

mkdir %1.Repository
cd %1.Repository
dotnet new classlib
dotnet add reference ../%1.Core.Repository/%1.Core.Repository.csproj
cd ..

mkdir %1.Repository.Data
cd %1.Repository.Data
dotnet new classlib
dotnet add reference ../%1.Core.Repository/%1.Core.Repository.csproj
cd ..

mkdir %1.Api
cd %1.Api
dotnet new webapi
dotnet add reference ../%1.Core/%1.Core.csproj
dotnet add reference ../%1.Repository/%1.Repository.csproj
dotnet add reference ../%1.Business/%1.Business.csproj
dotnet add reference ../%1.Repository.Data/%1.Repository.Data.csproj
cd ..

dotnet new sln
dotnet sln add %1.Core/%1.Core.csproj
dotnet sln add %1.Core.Repository/%1.Core.Repository.csproj
dotnet sln add %1.Repository/%1.Repository.csproj
dotnet sln add %1.Repository.Data/%1.Repository.Data.csproj
dotnet sln add %1.Business/%1.Business.csproj
dotnet sln add %1.Api/%1.Api.csproj

dotnet restore
dotnet build

pause
