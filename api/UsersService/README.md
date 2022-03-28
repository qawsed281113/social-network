# Сервіс для авторизація і автентифікації користувачів
- [x] Налаштування проекта (установка залежностей, налаштування конфігурації, бд тощо) 
- [x] Моделі
- [ ] Контролер(логіка)
- [x] Налаштувати JWT (генерація токена)
- [x] Упакувати в Docker

# Перед запуском (установка make)
```pwsh
Set-ExecutionPolicy Bypass -Scope Process -Force; [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.ServicePointManager]::SecurityProtocol -bor 3072; iex ((New-Object System.Net.WebClient).DownloadString('https://community.chocolatey.org/install.ps1'))
```
```pwsh
choco install make
```

# Запуск сервіса (потрібен Docker)
```pwsh
make
```

# Звільнення ресурсів
```pwsh
make stop
```

# Якщо немає make
```pwsh
docker-compose up -d
```

```pwsh
docker-compose down --rmi local
```