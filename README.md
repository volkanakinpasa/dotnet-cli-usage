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

### Build - configuration
Default option build is Debug.
#### -c (configuration)
```sh
cd src\dotnet-cli-usage-console
dotnet build -c Release
```
#### -f (framework)
```sh
dotnet build -c Release -f netcoreapp2.0
```
#### -o (output directory)
```sh
dotnet build -c Release -o output
```
### Clean
```sh
dotnet clean -c Release
```

