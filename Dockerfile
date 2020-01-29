From mcr.microsoft.com/dotnet/core/sdk:3.1
WORKDIR /app
Copy . .
RUN dotnet restore
RUN dotnet build
EXPOSE 5000
WORKDIR /app/SecurityService
ENTRYPOINT ["dotnet", "run"]
