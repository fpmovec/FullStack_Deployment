FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app/backend
EXPOSE 5018
EXPOSE 5019

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["BackendAPI/BackendAPI.csproj", "BackendAPI/"]
RUN dotnet restore "BackendAPI/BackendAPI.csproj"
COPY . .
WORKDIR "/src/BackendAPI"
RUN dotnet build "BackendAPI.csproj" -c Release -o /app/backend/build

FROM build AS publish
RUN dotnet publish "BackendAPI.csproj" -c Release -o /app/backend/publish


FROM mcr.microsoft.com/dotnet/sdk:8.0
WORKDIR /app/backend
COPY --from=publish /app/backend/publish .
RUN dotnet dev-certs https --trust
ENTRYPOINT [ "dotnet", "BackendAPI.dll" ]