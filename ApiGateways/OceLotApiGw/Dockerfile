#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ApiGateways/OceLotApiGw/OceLotApiGw.csproj", "ApiGateways/OceLotApiGw/"]
RUN dotnet restore "ApiGateways/OceLotApiGw/OceLotApiGw.csproj"
COPY . .
WORKDIR "/src/ApiGateways/OceLotApiGw"
RUN dotnet build "OceLotApiGw.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OceLotApiGw.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OceLotApiGw.dll"]
