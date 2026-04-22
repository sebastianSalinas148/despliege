tools para instalar
Microsoft.Data.SqlClient
Microsoft.EntityFrameworkCore.Tools

CREATE TABLE Caracteristicas (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100),
    Descripcion NVARCHAR(200)
);
INSERT INTO Caracteristicas (Nombre, Descripcion) VALUES
('Rápido', 'Sistema optimizado'),
('Seguro', 'Protección de datos'),
('Escalable', 'Crece con el negocio');

SELECT * FROM Caracteristicas;
