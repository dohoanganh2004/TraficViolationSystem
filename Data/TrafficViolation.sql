--CREATE DATABASE TrafficViolation

-- 1. Tạo bảng Roles
CREATE TABLE Roles (
    RoleID INT IDENTITY(1,1) PRIMARY KEY,
    RoleName NVARCHAR(20) NOT NULL UNIQUE
);
GO

-- 2. Tạo bảng Users
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    Password NVARCHAR(255) NOT NULL,
    RoleID INT NOT NULL,
    Phone NVARCHAR(15) NOT NULL,
    Address NVARCHAR(MAX),
	Image NVARCHAR(MAX),
    FOREIGN KEY (RoleID) REFERENCES Roles(RoleID)
);
GO

-- 3. Tạo bảng Vehicles
CREATE TABLE Vehicles (
    VehicleID INT IDENTITY(1,1) PRIMARY KEY,
    PlateNumber NVARCHAR(15) NOT NULL UNIQUE,
    OwnerID INT NOT NULL,
    Brand NVARCHAR(50),
    Model NVARCHAR(50),
    ManufactureYear SMALLINT,
    FOREIGN KEY (OwnerID) REFERENCES Users(UserID)
);
GO

-- 4. Tạo bảng Reports
CREATE TABLE Reports (
    ReportID INT IDENTITY(1,1) PRIMARY KEY,
    ReporterID INT NOT NULL,
    ViolationType NVARCHAR(50) NOT NULL,
    Description NVARCHAR(MAX) NOT NULL,
    PlateNumber NVARCHAR(15) NOT NULL,
    ImageURL NVARCHAR(MAX),
    VideoURL NVARCHAR(MAX),
    Location NVARCHAR(255) NOT NULL,
    ReportDate DATETIME DEFAULT GETDATE(),
    Status NVARCHAR(20) DEFAULT N'Chờ xử lý' 
        CONSTRAINT CHK_Reports_Status CHECK (Status IN (N'Chờ xử lý', N'Đã duyệt', N'Bị từ chối')),
    ProcessedBy INT,
    FOREIGN KEY (ReporterID) REFERENCES Users(UserID),
    FOREIGN KEY (ProcessedBy) REFERENCES Users(UserID),
    FOREIGN KEY (PlateNumber) REFERENCES Vehicles(PlateNumber)
);
GO

-- 5. Tạo bảng Violations
CREATE TABLE Violations (
    ViolationID INT IDENTITY(1,1) PRIMARY KEY,
    ReportID INT NOT NULL,
    PlateNumber NVARCHAR(15) NOT NULL,
    ViolatorID INT,
    FineAmount DECIMAL(10,2) NOT NULL,
    FineDate DATETIME DEFAULT GETDATE(),
    PaidStatus BIT DEFAULT 0,  -- 0: chưa thanh toán, 1: đã thanh toán
    FOREIGN KEY (ReportID) REFERENCES Reports(ReportID),
    FOREIGN KEY (PlateNumber) REFERENCES Vehicles(PlateNumber),
    FOREIGN KEY (ViolatorID) REFERENCES Users(UserID)
);
GO

-- 6. Tạo bảng Notifications
CREATE TABLE Notifications (
    NotificationID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL,
    Message NVARCHAR(MAX) NOT NULL,
    PlateNumber NVARCHAR(15),
    SentDate DATETIME DEFAULT GETDATE(),
    IsRead BIT DEFAULT 0,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (PlateNumber) REFERENCES Vehicles(PlateNumber)
);
GO

-- 7. Tạo bảng Payments
CREATE TABLE Payments (
    PaymentID INT IDENTITY(1,1) PRIMARY KEY,
    ViolationID INT NOT NULL,
    PaymentAmount DECIMAL(10,2) NOT NULL,
    PaymentDate DATETIME DEFAULT GETDATE(),
    PaymentMethod NVARCHAR(50) NOT NULL 
        CONSTRAINT CHK_Payments_Method CHECK (PaymentMethod IN (N'Thẻ tín dụng', N'Thẻ ghi nợ', N'Chuyển khoản ngân hàng', N'Tiền mặt', N'Ví điện tử')),
    TransactionID NVARCHAR(50) UNIQUE,
    PaymentStatus NVARCHAR(20) DEFAULT N'Chờ xử lý'
        CONSTRAINT CHK_Payments_Status CHECK (PaymentStatus IN (N'Chờ xử lý', N'Hoàn tất', N'Thất bại')),
    FOREIGN KEY (ViolationID) REFERENCES Violations(ViolationID)
);
GO

-- 8. Tạo bảng Complaints
CREATE TABLE Complaints (
    ComplaintID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL,
    ReportID INT NULL,
    ViolationID INT NULL,
    ComplaintText NVARCHAR(MAX) NOT NULL,
    ComplaintDate DATETIME DEFAULT GETDATE(),
    Status NVARCHAR(20) DEFAULT N'Chờ xử lý'
        CONSTRAINT CHK_Complaints_Status CHECK (Status IN (N'Chờ xử lý', N'Đang xem xét', N'Đã giải quyết', N'Bị từ chối')),
    ProcessedBy INT,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (ReportID) REFERENCES Reports(ReportID),
    FOREIGN KEY (ViolationID) REFERENCES Violations(ViolationID),
    FOREIGN KEY (ProcessedBy) REFERENCES Users(UserID)
);
GO





