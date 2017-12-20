# dotnet cli usage
It is not a big deal to learn dotnet cli, I just wanted to create this repository while I was practicing.

For .NET Core 2.x

```sh
mkdir dotnet-cli-usage 
cd dotnet-cli-usage
mkdir src
cd src
```

#### Create a new console
```sh
cd src
dotnet new console
```
Created a new console named "dotnet-cli-usage "

if you need to re-create with same name, you must give --force parameter
```sh
cd src
dotnet new console --force
/*output is the same.*/    
```

#### Create a new console given a name 
```sh
cd src
dotnet new console --force -n dotnet-cli-usage-console
```
Created a new folder named "dotnet-cli-usage-console" with .csproj and program.cs


#### Create a new console given a name & a language(Visual Basic or C#)
```sh
cd src
dotnet new console --force -lang C# -n dotnet-cli-usage-console-CSharp
```
Created a new folder named "dotnet-cli-usage-console-CSharp" with .csproj and program.cs

#### Create a new class library
```sh
cd src
dotnet new classlib -lang C# -n dotnet-cli-usage-class-lib
```
Created a new folder named "dotnet-cli-usage-class-lib" with .csproj and Class1.cs

#### Add library project as reference
```sh
cd src
dotnet add dotnet-cli-usage-console/dotnet-cli-usage-console.csproj reference dotnet-cli-usage-class-lib/dotnet-cli-usage-class-lib.csproj
```

#### Create a sln file
```sh
cd src
dotnet new sln -n dotnet-cli-usage-solution
dotnet sln dotnet-cli-usage-solution.sln add dotnet-cli-usage-console/dotnet-cli-usage-console.csproj
dotnet sln dotnet-cli-usage-solution.sln add dotnet-cli-usage-class-lib/dotnet-cli-usage-class-lib.csproj

```

### Build - configuration
Default option build is Debug.
#### -c (configuration)
```sh
dotnet build dotnet-cli-usage-solution.sln
cd src\dotnet-cli-usage-console
dotnet build
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
### Run
```sh
cd src\dotnet-cli-usage-console
dotnet run

/*
Output

Hello World!
Hello from class library 'Class1'!
*/
```
