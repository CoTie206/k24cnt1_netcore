

USE [master];
GO

IF DB_ID(N'HctLesson10EFDb') IS NULL
BEGIN
    EXEC(N'CREATE DATABASE [HctLesson10EFDb]');
END;
GO

USE [HctLesson10EFDb];
GO

IF OBJECT_ID(N'dbo.HctMember', N'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[HctMember]
    (
        [Id] BIGINT IDENTITY(1,1) NOT NULL,
        [HctUserName] VARCHAR(20) NULL,
        [HctPassword] VARCHAR(50) NULL,
        [HctFullName] NVARCHAR(50) NULL,
        [HctEmail] VARCHAR(50) NULL,
        [HctPhone] CHAR(12) NULL,
        [HctStatus] BIT NULL,
        CONSTRAINT [PK_HctMember] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (SELECT 1 FROM [dbo].[HctMember] WHERE [HctUserName] = 'hctien')
BEGIN
    INSERT INTO [dbo].[HctMember]
        ([HctUserName], [HctPassword], [HctFullName], [HctEmail], [HctPhone], [HctStatus])
    VALUES
        ('hctien', NULL, N'Hoàng Công Tiến', 'hctien@example.com', NULL, 1);
END;
GO
