# dotnet cli usage
It is not a big deal to learn dotnet cli, I just wanted to create this repository while I was practicing.

For .NET Core 2.x

```sh
$ mkdir dotnet-cli-usage 
$ cd dotnet-cli-usage
```

#### Create a new console
```sh
$ dotnet new console
```
output files
```
dotnet-cli-usage.csproj
Program.cs
``` 
if you need to re-create with same name, you must give --force parameter
```sh
$ dotnet new console --force
/*output is the same.*/    
```

#### Create a new console given a name 
```sh
$ dotnet new console --force -n dotnet-cli-usage-console
```
Created a new folder named "dotnet-cli-usage-console" with .csproj and program.cs


#### Create a new console given a name & a language(Visual Basic)
```sh
$ dotnet new console --force -lang VB -n dotnet-cli-usage-console-VB
```
Created a new folder named "dotnet-cli-usage-console-VB.vbproj" with .vbproj and program.vb

#### I will skip path "-o"

#### Install a template pack from the PATH or NUGET_ID
```sh
$ dotnet new --install "Microsoft.AspNetCore.SpaTemplates"
```
more info click [this](https://docs.microsoft.com/en-us/dotnet/core/tools/custom-templates) and [this](https://blogs.msdn.microsoft.com/dotnet/2017/04/02/how-to-create-your-own-templates-for-dotnet-new/)
