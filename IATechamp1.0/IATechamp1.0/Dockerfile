#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["IATechamp1.0/IATechamp1.0.csproj", "IATechamp1.0/"]
RUN dotnet restore "IATechamp1.0/IATechamp1.0.csproj"
COPY . .
WORKDIR "/src/IATechamp1.0"
RUN dotnet build "IATechamp1.0.csproj" -c Release -o /app/build
FROM build AS publish
RUN dotnet publish "IATechamp1.0.csproj" -c Release -o /app/publish
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "IATechamp1.0.dll"]