FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Services/Movie/Cinemaxum.Movie.Api/Cinemaxum.Movie.Api.csproj", "Services/Movie/Cinemaxum.Movie.Api/"]
COPY ["Services/Movie/Cinemaxum.Movie.Bll/Cinemaxum.Movie.Bll.csproj", "Services/Movie/Cinemaxum.Movie.Bll/"]
COPY ["Services/Movie/Cinemaxum.Movie.Dal/Cinemaxum.Movie.Dal.csproj", "Services/Movie/Cinemaxum.Movie.Dal/"]
RUN dotnet restore "Services/Movie/Cinemaxum.Movie.Api/Cinemaxum.Movie.Api.csproj"
COPY . .
WORKDIR "/src/Services/Movie/Cinemaxum.Movie.Api"
RUN dotnet build "Cinemaxum.Movie.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cinemaxum.Movie.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cinemaxum.Movie.Api.dll"]
