FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["OOPlaba1/OOPlaba1.csproj", "OOPlaba1/"]
RUN dotnet restore "OOPlaba1/OOPlaba1.csproj"
COPY . .
WORKDIR "/src/OOPlaba1"
RUN dotnet build "OOPlaba1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OOPlaba1.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OOPlaba1.dll"]
