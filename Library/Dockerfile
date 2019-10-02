FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Library/Library.csproj", "Library/"]
RUN dotnet restore "Library/Library.csproj"
COPY . .
WORKDIR "/src/Library"
RUN dotnet build "Library.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Library.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Library.dll"]