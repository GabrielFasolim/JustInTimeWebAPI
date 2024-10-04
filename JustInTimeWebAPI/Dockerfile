# Base image for runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

# SDK image for building the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copy csproj files and restore dependencies
COPY ["JustInTimeWebAPI/JustInTimeWebAPI/JustInTimeWebAPI.csproj", "JustInTimeWebAPI/"]
RUN dotnet restore "JustInTimeWebAPI/JustInTimeWebAPI.csproj"

# Copy the rest of the code and build the application
COPY . .
WORKDIR "/src/JustInTimeWebAPI"
RUN dotnet build "JustInTimeWebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publish the application
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "JustInTimeWebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Final image with the app
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "JustInTimeWebAPI.dll"]
