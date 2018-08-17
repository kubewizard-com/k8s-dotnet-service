FROM microsoft/dotnet:2.1-aspnetcore-runtime

WORKDIR /app
COPY ./Publish/. ./

ENTRYPOINT ["dotnet", "dotnetservice.dll"]