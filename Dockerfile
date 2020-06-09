FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster
WORKDIR /src
COPY . .
ENTRYPOINT ["dotnet", "run"]