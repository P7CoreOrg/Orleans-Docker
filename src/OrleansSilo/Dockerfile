FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
 

FROM dotnetcore/orleans-dockerbuild AS build
WORKDIR /src
RUN dotnet publish OrleansSilo -c Release -o out --no-restore --no-build

FROM base AS final
WORKDIR /app
COPY --from=build /src/OrleansSilo/out .
ENTRYPOINT ["dotnet", "OrleansSilo.dll"]
