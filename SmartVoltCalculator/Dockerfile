FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["SmartVoltCalculator.csproj", "SmartVoltCalculator/"]
RUN dotnet restore "SmartVoltCalculator/SmartVoltCalculator.csproj"
WORKDIR "/src/SmartVoltCalculator"
COPY . .
RUN dotnet build "SmartVoltCalculator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SmartVoltCalculator.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SmartVoltCalculator.dll"]
