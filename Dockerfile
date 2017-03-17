FROM microsoft/aspnetcore:1.1.0
WORKDIR /app
EXPOSE 80
COPY . .
ENTRYPOINT ["dotnet", "Hypertextor.dll"]
