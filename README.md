# CancerInstituteTest
This application is using MSSQl Local DB as database. 
You need to have .net core 3.1 installed on your machine in order to run the application.
You can clone the application and use Visual Studio to run the application or use the following instrauction to compile without Visual Studio. 

Language, Tools & tehnologies:
C# 
.Net Core 3.1
Angular
NUnit
Dependency Injection







Instruction to run using command line:

1. API
```
cd CancerInstApi
dotnet restore 
dotnet tool install --global dotnet-ef
dotnet ef migrations Add Initial
dotnet ef database update
dotnet run
```

2. Front-end
```
cd CancerInstFrontend
npm install -g @angular/cli
npm install

ng serve
```
