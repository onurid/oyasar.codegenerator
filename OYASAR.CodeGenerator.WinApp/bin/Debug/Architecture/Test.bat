



@echo off

title OYASAR SLN ENVIRONMENT GENERATOR
echo "# <====== OYASAR SLN ENVIRONMENT GENERATOR ======>"

mkdir Projects
cd Projects

mkdir OYASAR.Test
cd OYASAR.Test

mkdir OYASAR.Test.Core
cd OYASAR.Test.Core
dotnet new classlib
dotnet add package oyasar.framework.core
del Class1.cs 
mkdir Base
mkdir Dto
mkdir Model
mkdir Service
cd ..

mkdir OYASAR.Test.Business
cd OYASAR.Test.Business
dotnet new classlib
dotnet add reference ../OYASAR.Test.Core/OYASAR.Test.Core.csproj
del Class1.cs
cd ..

mkdir OYASAR.Test.Core.Repository
cd OYASAR.Test.Core.Repository
dotnet new classlib
dotnet add reference ../OYASAR.Test.Core/OYASAR.Test.Core.csproj
del Class1.cs
mkdir Base
mkdir DbContext
mkdir Model
cd ..

mkdir OYASAR.Test.Repository
cd OYASAR.Test.Repository
dotnet new classlib
dotnet add reference ../OYASAR.Test.Core.Repository/OYASAR.Test.Core.Repository.csproj
dotnet add package oyasar.framework.utils
del Class1.cs
mkdir Base
mkdir Mapping
cd ..

mkdir OYASAR.Test.Repository.EF
cd OYASAR.Test.Repository.EF
dotnet new classlib
dotnet add reference ../OYASAR.Test.Core.Repository/OYASAR.Test.Core.Repository.csproj
dotnet add package Microsoft.EntityFrameworkCore -v 2.0.1
dotnet add package Microsoft.EntityFrameworkCore.SqlServer -v 1.1.5
del Class1.cs
mkdir DbContext
cd ..

mkdir OYASAR.Test.Api
cd OYASAR.Test.Api
dotnet new webapi
dotnet add reference ../OYASAR.Test.Core/OYASAR.Test.Core.csproj
dotnet add reference ../OYASAR.Test.Repository/OYASAR.Test.Repository.csproj
dotnet add reference ../OYASAR.Test.Business/OYASAR.Test.Business.csproj
dotnet add reference ../OYASAR.Test.Repository.EF/OYASAR.Test.Repository.EF.csproj
dotnet add package OYASAR.Framework.NetcoreIoc
dotnet add package Microsoft.AspNetCore.All -v 2.0.3
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design -v 2.0.1
dotnet add package oyasar.framework.DefaultAutoMapper
dotnet add package oyasar.framework.EF
cd ..

dotnet new sln
dotnet sln add OYASAR.Test.Core/OYASAR.Test.Core.csproj
dotnet sln add OYASAR.Test.Core.Repository/OYASAR.Test.Core.Repository.csproj
dotnet sln add OYASAR.Test.Repository/OYASAR.Test.Repository.csproj
dotnet sln add OYASAR.Test.Repository.EF/OYASAR.Test.Repository.EF.csproj
dotnet sln add OYASAR.Test.Business/OYASAR.Test.Business.csproj
dotnet sln add OYASAR.Test.Api/OYASAR.Test.Api.csproj

dotnet restore
dotnet build

pause
