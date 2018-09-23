FROM microsoft/dotnet:2.1-sdk as build  
WORKDIR /PatterAppProject
COPY PatterAppProject . 

RUN dotnet restore
RUN dotnet publish "PatterAppProject.csproj" -c Release -o /app

FROM microsoft/dotnet:2.1-runtime as deployment
WORKDIR /app 
COPY --from=build /app .
ENTRYPOINT [ "dotnet", "PatterAppProject.dll" ]