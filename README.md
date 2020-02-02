# CancerInstituteTest



Instruction to run:

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
