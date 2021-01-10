FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /source

COPY ./*.csproj ./

RUN dotnet restore PokemonApi.csproj

COPY ./ ./
WORKDIR /source/
RUN dotnet build -c release

FROM build AS publish
RUN dotnet publish -c release --no-build -o /app

FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /app
COPY --from=publish /app .

ENTRYPOINT ["dotnet", "PokemonApi.dll"]