FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy project files first
COPY ["*.csproj", "./"]
COPY ["../wms_android.shared/*.csproj", "../wms_android.shared/"]
COPY ["../wms_android.data/*.csproj", "../wms_android.data/"]

# Restore dependencies
RUN dotnet restore "wms_android.api.csproj"

# Copy everything else
COPY . ./
COPY ["../wms_android.shared/", "../wms_android.shared/"]
COPY ["../wms_android.data/", "../wms_android.data/"]

# Build the application
RUN dotnet build "wms_android.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "wms_android.api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "wms_android.api.dll"]