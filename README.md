# EF Core 1
Primer ejemplo de uso de EF Core. Tras descargarse, habrá que realizar las migraciones con las órdenes:

- dotnet tool install --global dotnet-ef 
- dotnet add package Microsoft.EntityFrameworkCore.Design 
- dotnet ef migrations add Inicial 
- dotnet ef database update

Finalmente, se ejecutará el programa con la orden:
- dotnet run

