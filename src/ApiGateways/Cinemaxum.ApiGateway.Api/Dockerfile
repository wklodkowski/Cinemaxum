FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Cinemaxum.ApiGateway.Api/Cinemaxum.ApiGateway.Api.csproj", "Cinemaxum.ApiGateway.Api/"]
RUN dotnet restore "Cinemaxum.ApiGateway.Api/Cinemaxum.ApiGateway.Api.csproj"
COPY . .
WORKDIR "/src/Cinemaxum.ApiGateway.Api"
RUN dotnet build "Cinemaxum.ApiGateway.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cinemaxum.ApiGateway.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cinemaxum.ApiGateway.Api.dll"]