FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Services/Catalog/Cinemaxum.Catalog.Api/Cinemaxum.Catalog.Api.csproj", "Services/Catalog/Cinemaxum.Catalog.Api/"]
COPY ["Services/Catalog/Cinemaxum.Catalog.Bll/Cinemaxum.Catalog.Bll.csproj", "Services/Catalog/Cinemaxum.Catalog.Bll/"]
COPY ["Services/Catalog/Cinemaxum.Catalog.Api/Cinemaxum.Catalog.Dal.csproj", "Services/Catalog/Cinemaxum.Catalog.Dal/"]
RUN dotnet restore "Cinemaxum.Catalog.Api/Cinemaxum.Catalog.Api.csproj"
COPY . .
WORKDIR "/src/Cinemaxum.Catalog.Api"
RUN dotnet build "Cinemaxum.Catalog.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cinemaxum.Catalog.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cinemaxum.Catalog.Api.dll"]