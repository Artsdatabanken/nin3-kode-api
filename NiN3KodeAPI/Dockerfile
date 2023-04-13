#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["NiN3KodeAPI/NiN3KodeAPI.csproj", "NiN3KodeAPI/"]
RUN dotnet restore "NiN3KodeAPI/NiN3KodeAPI.csproj"
COPY . .
WORKDIR "/src/NiN3KodeAPI"
RUN dotnet build "NiN3KodeAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NiN3KodeAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NiN3KodeAPI.dll"]