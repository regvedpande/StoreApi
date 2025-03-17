# Use the official .NET 8.0 SDK image to build and publish the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the .csproj file and restore dependencies
COPY StoreApi/StoreApi.csproj StoreApi/
RUN dotnet restore StoreApi/StoreApi.csproj

# Copy the entire solution and publish
COPY . .
WORKDIR /src/StoreApi
RUN dotnet publish StoreApi.csproj -c Release -o /app/publish

# Use the .NET 8.0 ASP.NET runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

# Copy the published output from the build stage
COPY --from=build /app/publish .

# Expose the port your app listens on
EXPOSE 8080

# Run the application
ENTRYPOINT ["dotnet", "StoreApi.dll"]
