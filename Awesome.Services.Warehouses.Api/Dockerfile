FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Awesome.Services.Warehouses.Api/Awesome.Services.Warehouses.Api.csproj", "Awesome.Services.Warehouses.Api/"]
RUN dotnet restore "Awesome.Services.Warehouses.Api/Awesome.Services.Warehouses.Api.csproj"
COPY . .
WORKDIR "/src/Awesome.Services.Warehouses.Api"
RUN dotnet build "Awesome.Services.Warehouses.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Awesome.Services.Warehouses.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Awesome.Services.Warehouses.Api.dll"]
