BEGIN TRANSACTION;
GO

EXEC sp_rename N'[students].[StudentName]', N'LastName', N'COLUMN';
GO

EXEC sp_rename N'[students].[StudentCourse]', N'Department', N'COLUMN';
GO

ALTER TABLE [students] ADD [Age] int NOT NULL DEFAULT 0;
GO

ALTER TABLE [students] ADD [DateOfBirth] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

ALTER TABLE [students] ADD [FirstName] nvarchar(20) NOT NULL DEFAULT N'';
GO

ALTER TABLE [students] ADD [Gender] int NOT NULL DEFAULT 0;
GO

ALTER TABLE [students] ADD [IsGraduated] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240318165213_updated-StudentModel', N'7.0.10');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240318165725_removed-Max-attribute', N'7.0.10');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[students]') AND [c].[name] = N'DateOfBirth');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [students] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [students] ALTER COLUMN [DateOfBirth] Date NOT NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240325192053_column=Date-Added', N'7.0.10');
GO

COMMIT;
GO

