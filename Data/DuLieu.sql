-- Chen thong tin role
INSERT INTO Roles (RoleName) VALUES 
(N'Quản trị viên'), 
(N'Cảnh sát giao thông'), 
(N'Người dân');
--
INSERT INTO Users (FullName, Email, Password, RoleID, Phone, Address,Image) VALUES 
(N'Nguyễn Văn A', N'nguyenvana@gmail.com', 'password123', 1, N'0987654321', N'123 Đường ABC, TP. Hồ Chí Minh',NULL),
(N'Lê Thị B', N'lethib@gmail.com', 'password456', 2, N'0971234567', N'456 Đường DEF, Hà Nội',NULL),
(N'Trần Văn C', N'tranvanc@gmail.com', 'password789', 3, N'0962345678', N'789 Đường XYZ, Đà Nẵng',NULL);
--
INSERT INTO Vehicles (PlateNumber, OwnerID, Brand, Model, ManufactureYear) VALUES 
(N'51A-12345', 3, N'Toyota', N'Vios', 2018),
(N'30B-67890', 3, N'Honda', N'City', 2020),
(N'43C-24680', 3, N'Hyundai', N'Accent', 2019);
--
INSERT INTO Reports (ReporterID, ViolationType, Description, PlateNumber, Location, Status) VALUES 
(2, N'Vượt đèn đỏ', N'Xe vượt đèn đỏ tại ngã tư ABC.', N'51A-12345', N'Ngã tư ABC, TP. Hồ Chí Minh', N'Chờ xử lý'),
(2, N'Đi ngược chiều', N'Xe đi sai làn đường và ngược chiều.', N'30B-67890', N'Đường XYZ, Hà Nội', N'Chờ xử lý');
--
INSERT INTO Violations (ReportID, PlateNumber, ViolatorID, FineAmount, PaidStatus) VALUES 
(1, N'51A-12345', 3, 500000, 0),
(2, N'30B-67890', 3, 700000, 0);
--
INSERT INTO Notifications (UserID, Message, PlateNumber) VALUES 
(3, N'Bạn có một biên bản vi phạm chưa thanh toán.', N'51A-12345'),
(3, N'Vui lòng kiểm tra báo cáo vi phạm của bạn.', N'30B-67890');
--
INSERT INTO Payments (ViolationID, PaymentAmount, PaymentMethod, TransactionID, PaymentStatus) VALUES 
(1, 500000, N'Thẻ tín dụng', NEWID(), N'Hoàn tất'),
(2, 750000, N'Chuyển khoản ngân hàng', NEWID(), N'Hoàn tất');


--
INSERT INTO Complaints (UserID, ReportID, ViolationID, ComplaintText, Status) VALUES 
(3, 1, 1, N'Tôi không đồng ý với biên bản này, vì tôi không lái xe vào thời điểm đó.', N'Chờ xử lý');
--

