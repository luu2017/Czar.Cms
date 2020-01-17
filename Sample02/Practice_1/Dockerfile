FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Practice_1/Practice_1.csproj", "Practice_1/"]
RUN dotnet restore "Practice_1/Practice_1.csproj"
COPY . .
WORKDIR "/src/Practice_1"
RUN dotnet build "Practice_1.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Practice_1.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Practice_1.dll"]