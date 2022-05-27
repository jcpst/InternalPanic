FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["InternalPanic/InternalPanic.fsproj", "InternalPanic/"]
RUN dotnet restore "InternalPanic/InternalPanic.fsproj"
COPY . .
WORKDIR "/src/InternalPanic"
RUN dotnet build "InternalPanic.fsproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "InternalPanic.fsproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "InternalPanic.dll"]
