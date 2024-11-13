FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY /Src/*.csproj .
RUN dotnet restore

COPY /Src/. .
RUN dotnet publish -c Release -o /publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /publish
COPY --from=build /publish .

EXPOSE 8080

ENTRYPOINT ["dotnet", "Api.dll"]
