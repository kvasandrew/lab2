#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["TaskConsoleApp/TaskConsoleApp.csproj", "TaskConsoleApp/"]
COPY ["Task.Core/Task.Core.csproj", "Task.Core/"]
RUN dotnet restore "TaskConsoleApp/TaskConsoleApp.csproj"
COPY . .
WORKDIR "/src/TaskConsoleApp"
RUN dotnet build "TaskConsoleApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TaskConsoleApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TaskConsoleApp.dll"]