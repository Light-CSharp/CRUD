#Подгружаем .Net SDK
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

#Копируем .csproj и подгружаем зависимости
COPY CRUD/*.csproj ./
RUN dotnet restore

#Копируем весь код и билдим проект в app
COPY . ./
RUN dotnet publish -c Release -o /app/out

#Берем образ .Net 9.0, копирование результата сборки app
FROM mcr.microsoft.com/dotnet/runtime:9.0
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "CRUD.dll"]