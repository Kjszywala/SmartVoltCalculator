﻿FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["SmartVoltCalculator.Api/SmartVoltCalculator.Api.csproj", "SmartVoltCalculator.Api/"]
RUN dotnet restore "SmartVoltCalculator.Api/SmartVoltCalculator.Api.csproj"
COPY . .
WORKDIR "/src/SmartVoltCalculator.Api"
RUN dotnet build "SmartVoltCalculator.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SmartVoltCalculator.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SmartVoltCalculator.Api.dll"]
