FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy necessary project files first, maintaining directory structure
COPY ["wms_android.api/wms_android.api.csproj", "wms_android.api/"]
COPY ["wms_android.shared/wms_android.shared.csproj", "wms_android.shared/"]
# Assuming wms_android.data exists and is needed:
# COPY ["wms_android.data/wms_android.data.csproj", "wms_android.data/"] 

# Set the working directory to the API project folder before restoring
WORKDIR /src/wms_android.api

# Restore dependencies for the API project (it will find related projects)
# Clear NuGet cache before restoring - Sometimes helps with build server issues
RUN dotnet nuget locals all --clear
# Add this line to install required workloads based on project files
RUN dotnet workload restore 
RUN dotnet restore "wms_android.api.csproj"

# Go back to the source root to copy all code
WORKDIR /src

# Copy all source code
COPY ["wms_android.api/", "wms_android.api/"]
COPY ["wms_android.shared/", "wms_android.shared/"]
# Assuming wms_android.data exists and is needed:
# COPY ["wms_android.data/", "wms_android.data/"]

# Build the application from the API project directory
WORKDIR /src/wms_android.api
RUN dotnet build "wms_android.api.csproj" -c Release -o /app/build

FROM build AS publish
# Publish from the API project directory
WORKDIR /src/wms_android.api
RUN dotnet publish "wms_android.api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "wms_android.api.dll"]