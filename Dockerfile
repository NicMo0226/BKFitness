FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["BKFitness/BKFitness.csproj", "BKFitness/"]
RUN dotnet restore "BKFitness/BKFitness.csproj"
COPY . .
WORKDIR "/src/BKFitness"
RUN dotnet build "BKFitness.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "BKFitness.csproj" -c Release -o /app

FROM base AS final
ENV DOTNET_USE_POLLING_FILE_WATCHER=true
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "BKFitness.dll"]