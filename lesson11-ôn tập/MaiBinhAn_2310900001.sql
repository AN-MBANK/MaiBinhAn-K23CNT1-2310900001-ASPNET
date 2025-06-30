-- Tạo database
CREATE DATABASE MaiBinhAn_2310900001;
GO

-- Sử dụng database vừa tạo
USE MaiBinhAn_2310900001;
GO

-- Tạo bảng MbaEmployee
CREATE TABLE MbaEmployee (
    mbaEmpId INT PRIMARY KEY,
    mbaEmpName NVARCHAR(100),
    mbaEmpLevel NVARCHAR(50),
    mbaEmpStartDate DATE,
    mbaEmpStatus BIT
);
GO

-- Thêm dữ liệu mẫu (ít nhất 3 bản ghi, 1 bản ghi là thông tin của bạn)
INSERT INTO MbaEmployee (mbaEmpId, mbaEmpName, mbaEmpLevel, mbaEmpStartDate, mbaEmpStatus)
VALUES
(1, N'Mai Bình An', N'Senior', '2022-09-01', 1),     -- Thông tin cá nhân
(2, N'Trần Thị Bích', N'Junior', '2023-05-10', 1),
(3, N'Nguyễn Văn An', N'Intern', '2024-01-15', 0);
GO
