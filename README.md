# CRUD Console App (C#)

Простой консольный CRUD-проект на C#, предназначенный для демонстрации работы с Docker, Terraform и CI/CD.

📂 Структура проекта

Program.cs — исходный код CRUD-приложения.

Dockerfile — инструкция для сборки контейнера.

main.tf — описание инфраструктуры в Terraform.

variables.tf — переменные для Terraform.

.github/workflows/ci.yml — конфигурация CI/CD (GitHub Actions).

# Запуск локально

Требования:

.NET SDK 6/7/8

В терминале:
dotnet build
dotnet run

# Запуск в Docker

Собрать образ:
docker build -t crud-app .

Запустить контейнер
docker run --rm -it crud-app

# Деплой с Terraform

Перед использованием убедитесь, что у вас установлен Terraform

Инициализация:
terraform init

Проверка плана
terraform plan

Применение конфигурации:
terraform apply

Все переменные настраиваются через variables.tf или с помощью -var при запуске
