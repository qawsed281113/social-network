FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env

WORKDIR /app

COPY *.csproj ./

RUN dotnet restore

COPY ./ ./ 

RUN dotnet publish -c Release -o build

FROM mcr.microsoft.com/dotnet/aspnet:6.0

WORKDIR /app

COPY --from=build-env /app/build .

ENTRYPOINT ["dotnet", "UsersService.dll"]