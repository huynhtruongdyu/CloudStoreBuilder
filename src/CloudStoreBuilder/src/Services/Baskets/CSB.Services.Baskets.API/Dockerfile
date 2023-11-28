#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Directory.Build.props", "."]
COPY ["src/Services/Baskets/CSB.Services.Baskets.API/CSB.Services.Baskets.API.csproj", "src/Services/Baskets/CSB.Services.Baskets.API/"]
RUN dotnet restore "./src/Services/Baskets/CSB.Services.Baskets.API/./CSB.Services.Baskets.API.csproj"
COPY . .
WORKDIR "/src/src/Services/Baskets/CSB.Services.Baskets.API"
RUN dotnet build "./CSB.Services.Baskets.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./CSB.Services.Baskets.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CSB.Services.Baskets.API.dll"]