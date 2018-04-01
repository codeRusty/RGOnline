Install the .NET Core SDK. The .NET Core SDK includes the latest release of the .NET Core framework and runtime.

Install Visual Studio Code. During the course of this article, you also install Visual Studio Code extensions that improve the .NET Core development experience.

## check : dotnet --version

## List all the available projects templates : dotnet new [options]

## Create new Solution : dotnet new sln

## Class Library : dotnet new classlib -o library

## Add Lib to proj: dotnet sln add library/library.csproj

## Add package : dotnet add library package Newtonsoft.Json

## Restore package  : dotnet restore

## build :  dotnet build

## Add reference  : dotnet add RGonline.BService/RGonline.BService.csproj reference RGonline.DataModels/RGonline.DataModels.csproj

## Code First : Add-Migration [Name] + then + Update-database


## Add DB Frist : Scaffold-DbContext "Server=DESKTOP-FIUUHBV\SQLEXPRESS;Database=RGOnline;User Id=sa;Password=$ourabh@1;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

------------------------------------------------------------

Microsoft Windows [Version 6.1.7601]
Copyright (c) 2009 Microsoft Corporation.  All rights reserved.

E:\SourceCode\RGOnline>dotnet new
Usage: new [options]

Options:
  -h, --help          Displays help for this command.
  -l, --list          Lists templates containing the specified name. If no name is specified, lists all templates.
  -n, --name          The name for the output being created. If no name is specified, the name of the current directory is used.
  -o, --output        Location to place the generated output.
  -i, --install       Installs a source or a template pack.
  -u, --uninstall     Uninstalls a source or a template pack.
  --type              Filters templates based on available types. Predefined values are "project", "item" or "other".
  --force             Forces content to be generated even if it would change existing files.
  -lang, --language   Specifies the language of the template to create.


Templates                                         Short Name       Language          Tags
--------------------------------------------------------------------------------------------------------
Console Application                               console          [C#], F#, VB      Common/Console
Class library                                     classlib         [C#], F#, VB      Common/Library
Unit Test Project                                 mstest           [C#], F#, VB      Test/MSTest
xUnit Test Project                                xunit            [C#], F#, VB      Test/xUnit
ASP.NET Core Empty                                web              [C#], F#          Web/Empty
ASP.NET Core Web App (Model-View-Controller)      mvc              [C#], F#          Web/MVC
ASP.NET Core Web App                              razor            [C#]              Web/MVC/Razor Pages
ASP.NET Core with Angular                         angular          [C#]              Web/MVC/SPA
ASP.NET Core with React.js                        react            [C#]              Web/MVC/SPA
ASP.NET Core with React.js and Redux              reactredux       [C#]              Web/MVC/SPA
ASP.NET Core Web API                              webapi           [C#], F#          Web/WebAPI
global.json file                                  globaljson                         Config
Nuget Config                                      nugetconfig                        Config
Web Config                                        webconfig                          Config
Solution File                                     sln                                Solution
Razor Page                                        page                               Web/ASP.NET
MVC ViewImports                                   viewimports                        Web/ASP.NET
MVC ViewStart                                     viewstart                          Web/ASP.NET


Examples:
    dotnet new mvc --auth Individual
    dotnet new console
    dotnet new --help

E:\SourceCode\RGOnline>dotnet new sln
The template "Solution File" was created successfully.

E:\SourceCode\RGOnline>dotnet new classlib -o RGonline.Arch
The template "Class library" was created successfully.

Processing post-creation actions...
Running 'dotnet restore' on RGonline.Arch\RGonline.Arch.csproj...
  Restoring packages for E:\SourceCode\RGOnline\RGonline.Arch\RGonline.Arch.csproj...
  Generating MSBuild file E:\SourceCode\RGOnline\RGonline.Arch\obj\RGonline.Arch.csproj.nuget.g.props.
  Generating MSBuild file E:\SourceCode\RGOnline\RGonline.Arch\obj\RGonline.Arch.csproj.nuget.g.targets.
  Restore completed in 643.42 ms for E:\SourceCode\RGOnline\RGonline.Arch\RGonline.Arch.csproj.


Restore succeeded.


E:\SourceCode\RGOnline>
E:\SourceCode\RGOnline>dotnet sln add RGonline.Arch/RGonline.Arch.csproj
Project `RGonline.Arch\RGonline.Arch.csproj` added to the solution.

E:\SourceCode\RGOnline>dotnet new classlib -o RGonline.Framework
The template "Class library" was created successfully.

Processing post-creation actions...
Running 'dotnet restore' on RGonline.Framework\RGonline.Framework.csproj...
  Restoring packages for E:\SourceCode\RGOnline\RGonline.Framework\RGonline.Framework.csproj...
  Generating MSBuild file E:\SourceCode\RGOnline\RGonline.Framework\obj\RGonline.Framework.csproj.nuget.g.props.
  Generating MSBuild file E:\SourceCode\RGOnline\RGonline.Framework\obj\RGonline.Framework.csproj.nuget.g.targets.
  Restore completed in 354.81 ms for E:\SourceCode\RGOnline\RGonline.Framework\RGonline.Framework.csproj.


Restore succeeded.


E:\SourceCode\RGOnline>dotnet sln add RGonline.Framework/RGonline.Framework.csproj
Project `RGonline.Framework\RGonline.Framework.csproj` added to the solution.

E:\SourceCode\RGOnline>dotnet new webapi -o RGOnline.WebAPI
The template "ASP.NET Core Web API" was created successfully.
This template contains technologies from parties other than Microsoft, see https://aka.ms/template-3pn for details.

Processing post-creation actions...
Running 'dotnet restore' on RGOnline.WebAPI\RGOnline.WebAPI.csproj...
  Restore completed in 268.42 ms for E:\SourceCode\RGOnline\RGOnline.WebAPI\RGOnline.WebAPI.csproj.
  Restoring packages for E:\SourceCode\RGOnline\RGOnline.WebAPI\RGOnline.WebAPI.csproj...
  Generating MSBuild file E:\SourceCode\RGOnline\RGOnline.WebAPI\obj\RGOnline.WebAPI.csproj.nuget.g.props.
  Generating MSBuild file E:\SourceCode\RGOnline\RGOnline.WebAPI\obj\RGOnline.WebAPI.csproj.nuget.g.targets.
  Restore completed in 10.8 sec for E:\SourceCode\RGOnline\RGOnline.WebAPI\RGOnline.WebAPI.csproj.


Restore succeeded.


E:\SourceCode\RGOnline>dotnet new classlib -o RGonline.DataAccess
The template "Class library" was created successfully.

Processing post-creation actions...
Running 'dotnet restore' on RGonline.DataAccess\RGonline.DataAccess.csproj...
  Restoring packages for E:\SourceCode\RGOnline\RGonline.DataAccess\RGonline.DataAccess.csproj...
  Generating MSBuild file E:\SourceCode\RGOnline\RGonline.DataAccess\obj\RGonline.DataAccess.csproj.nuget.g.props.
  Generating MSBuild file E:\SourceCode\RGOnline\RGonline.DataAccess\obj\RGonline.DataAccess.csproj.nuget.g.targets.
  Restore completed in 229.19 ms for E:\SourceCode\RGOnline\RGonline.DataAccess\RGonline.DataAccess.csproj.


Restore succeeded.


E:\SourceCode\RGOnline>dotnet sln add RGonline.DataAccess/RGOnline.DataAccess.csproj
Project `RGonline.DataAccess\RGOnline.DataAccess.csproj` added to the solution.

E:\SourceCode\RGOnline>dotnet new classlib -o RGonline.DataModels
The template "Class library" was created successfully.

Processing post-creation actions...
Running 'dotnet restore' on RGonline.DataModels\RGonline.DataModels.csproj...
  Restoring packages for E:\SourceCode\RGOnline\RGonline.DataModels\RGonline.DataModels.csproj...
  Generating MSBuild file E:\SourceCode\RGOnline\RGonline.DataModels\obj\RGonline.DataModels.csproj.nuget.g.props.
  Generating MSBuild file E:\SourceCode\RGOnline\RGonline.DataModels\obj\RGonline.DataModels.csproj.nuget.g.targets.
  Restore completed in 252.48 ms for E:\SourceCode\RGOnline\RGonline.DataModels\RGonline.DataModels.csproj.


Restore succeeded.


E:\SourceCode\RGOnline>dotnet sln add RGonline.DataModels/RGOnline.DataModels.csproj
Project `RGonline.DataModels\RGOnline.DataModels.csproj` added to the solution.

E:\SourceCode\RGOnline>dotnet new classlib -o RGonline.DTOs
The template "Class library" was created successfully.

Processing post-creation actions...
Running 'dotnet restore' on RGonline.DTOs\RGonline.DTOs.csproj...
  Restoring packages for E:\SourceCode\RGOnline\RGonline.DTOs\RGonline.DTOs.csproj...
  Generating MSBuild file E:\SourceCode\RGOnline\RGonline.DTOs\obj\RGonline.DTOs.csproj.nuget.g.props.
  Generating MSBuild file E:\SourceCode\RGOnline\RGonline.DTOs\obj\RGonline.DTOs.csproj.nuget.g.targets.
  Restore completed in 270.7 ms for E:\SourceCode\RGOnline\RGonline.DTOs\RGonline.DTOs.csproj.


Restore succeeded.


E:\SourceCode\RGOnline>dotnet sln add RGonline.DTOs/RGOnline.DTOs.csproj
Project `RGonline.DTOs\RGOnline.DTOs.csproj` added to the solution.

E:\SourceCode\RGOnline>dotnet new classlib -o RGonline.BServices
The template "Class library" was created successfully.

Processing post-creation actions...
Running 'dotnet restore' on RGonline.BServices\RGonline.BServices.csproj...
  Restoring packages for E:\SourceCode\RGOnline\RGonline.BServices\RGonline.BServices.csproj...
  Generating MSBuild file E:\SourceCode\RGOnline\RGonline.BServices\obj\RGonline.BServices.csproj.nuget.g.props.
  Generating MSBuild file E:\SourceCode\RGOnline\RGonline.BServices\obj\RGonline.BServices.csproj.nuget.g.targets.
  Restore completed in 276.71 ms for E:\SourceCode\RGOnline\RGonline.BServices\RGonline.BServices.csproj.


Restore succeeded.


E:\SourceCode\RGOnline>dotnet sln add RGonline.BServices/RGOnline.BServices.csproj
Project `RGonline.BServices\RGOnline.BServices.csproj` added to the solution.
