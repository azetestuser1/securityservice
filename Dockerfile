From mcr.microsoft.com/dotnet/core/sdk:3.1
WORKDIR /app
Copy ./SecurityService .
RUN dotnet restore
RUN dotnet build
EXPOSE 5000
CMD ["dotnet", "run"]
