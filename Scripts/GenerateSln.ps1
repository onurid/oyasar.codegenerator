Param ($slnName)

mkdir $slnName
cd $slnName

mkdir $slnName.Core
cd $slnName.Core
dotnet new classlib
dotnet add package oyasar.framework.core
cd ..

mkdir $slnName.Business
cd $slnName.Business
dotnet new classlib
dotnet add reference ../$slnName.Core/$slnName.Core.csproj
cd ..

mkdir $slnName.Core.Repository
cd $slnName.Core.Repository
dotnet new classlib
dotnet add reference ../$slnName.Core/$slnName.Core.csproj
cd ..

mkdir $slnName.Repository
cd $slnName.Repository
dotnet new classlib
dotnet add reference ../$slnName.Core.Repository/$slnName.Core.Repository.csproj
cd ..

mkdir $slnName.Repository.Data
cd $slnName.Repository.Data
dotnet new classlib
dotnet add reference ../$slnName.Core.Repository/$slnName.Core.Repository.csproj
cd ..

mkdir $slnName.Api
cd $slnName.Api
dotnet new webapi
dotnet add reference ../$slnName.Core/$slnName.Core.csproj
dotnet add reference ../$slnName.Repository/$slnName.Repository.csproj
dotnet add reference ../$slnName.Business/$slnName.Business.csproj
dotnet add reference ../$slnName.Repository.Data/$slnName.Repository.Data.csproj
cd ..

dotnet new sln
dotnet sln add $slnName.Core/$slnName.Core.csproj
dotnet sln add $slnName.Core.Repository/$slnName.Core.Repository.csproj
dotnet sln add $slnName.Repository/$slnName.Repository.csproj
dotnet sln add $slnName.Repository.Data/$slnName.Repository.Data.csproj
dotnet sln add $slnName.Business/$slnName.Business.csproj
dotnet sln add $slnName.Api/$slnName.Api.csproj

dotnet restore
dotnet build

pause
