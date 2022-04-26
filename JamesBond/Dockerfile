FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["JamesBond/JamesBond.csproj", "JamesBond/"]
RUN dotnet restore "JamesBond/JamesBond.csproj"
COPY . .
WORKDIR "/src/JamesBond"
RUN dotnet build "JamesBond.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "JamesBond.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "JamesBond.dll"]
