-- Thêm dữ liệu vào bảng Roles
INSERT INTO Roles (RoleName) VALUES 
(N'Quản trị viên'), 
(N'Cảnh sát giao thông'), 
(N'Người dân');

-- Thêm dữ liệu vào bảng Users
INSERT INTO Users (FullName, Email, Password, RoleID, Phone, Address, Image) VALUES 
(N'Nguyễn Văn A', N'nguyenvana@gmail.com', 'password123', 1, N'0987654321', N'123 Đường ABC, TP. Hồ Chí Minh', NULL),
(N'Lê Thị B', N'lethib@gmail.com', 'password456', 2, N'0971234567', N'456 Đường DEF, Hà Nội', NULL),
(N'Trần Văn C', N'tranvanc@gmail.com', 'password789', 3, N'0962345678', N'789 Đường XYZ, Đà Nẵng', NULL),
(N'Phạm Thị D', N'phamthid@gmail.com', 'password321', 3, N'0912345678', N'12 Đường LMN, TP. Hồ Chí Minh', NULL),
(N'Hoàng Văn E', N'hoangvane@gmail.com', 'password654', 2, N'0987651234', N'34 Đường PQR, Hà Nội', NULL),
(N'Ngô Thị F', N'ngothif@gmail.com', 'password987', 3, N'0923456789', N'567 Đường STU, Hải Phòng', NULL),
(N'Vũ Văn G', N'vuvang@gmail.com', 'password741', 2, N'0956784321', N'891 Đường VWX, Cần Thơ', NULL);

-- Thêm dữ liệu vào bảng Vehicles
INSERT INTO Vehicles (PlateNumber, OwnerID, Brand, Model, ManufactureYear) VALUES 
(N'51A-12345', 3, N'Toyota', N'Vios', 2018),
(N'30B-67890', 3, N'Honda', N'City', 2020),
(N'43C-24680', 3, N'Hyundai', N'Accent', 2019),
(N'60A-34567', 3, N'Ford', N'Everest', 2021),
(N'29C-98765', 3, N'Mazda', N'CX-5', 2017),
(N'79D-11223', 3, N'Kia', N'Cerato', 2016),
(N'65E-33445', 3, N'Nissan', N'Navara', 2015);

-- Thêm dữ liệu vào bảng Reports
INSERT INTO Reports (ReporterID, ViolationType, Description, PlateNumber, Location, Status) VALUES 
(2, N'Vượt đèn đỏ', N'Xe vượt đèn đỏ tại ngã tư ABC.', N'51A-12345', N'Ngã tư ABC, TP. Hồ Chí Minh', N'Chờ xử lý'),
(2, N'Đi ngược chiều', N'Xe đi sai làn đường và ngược chiều.', N'30B-67890', N'Đường XYZ, Hà Nội', N'Chờ xử lý'),
(2, N'Không đội mũ bảo hiểm', N'Người điều khiển không đội mũ bảo hiểm.', N'43C-24680', N'Đường LMN, Đà Nẵng', N'Đã xử lý'),
(2, N'Chạy quá tốc độ', N'Xe chạy quá tốc độ quy định.', N'60A-34567', N'Quốc lộ 1A, TP. Hồ Chí Minh', N'Chờ xử lý'),
(2, N'Dừng đỗ sai quy định', N'Xe dừng đỗ không đúng nơi quy định.', N'29C-98765', N'Đường DEF, Hà Nội', N'Chờ xử lý');

-- Thêm dữ liệu vào bảng Violations
INSERT INTO Violations (ReportID, PlateNumber, ViolatorID, FineAmount, PaidStatus) VALUES 
(1, N'51A-12345', 3, 500000, 0),
(2, N'30B-67890', 3, 700000, 0),
(3, N'43C-24680', 3, 300000, 1),
(4, N'60A-34567', 3, 900000, 0),
(5, N'29C-98765', 3, 400000, 1);

-- Thêm dữ liệu vào bảng Notifications
INSERT INTO Notifications (UserID, Message, PlateNumber) VALUES 
(3, N'Bạn có một biên bản vi phạm chưa thanh toán.', N'51A-12345'),
(3, N'Vui lòng kiểm tra báo cáo vi phạm của bạn.', N'30B-67890'),
(3, N'Vi phạm của bạn đã được xử lý thành công.', N'43C-24680'),
(3, N'Bạn có một vi phạm đang chờ xử lý.', N'60A-34567'),
(3, N'Xe của bạn bị báo dừng đỗ sai quy định.', N'29C-98765');

-- Thêm dữ liệu vào bảng Payments
INSERT INTO Payments (ViolationID, PaymentAmount, PaymentMethod, TransactionID, PaymentStatus) VALUES 
(1, 500000, N'Thẻ tín dụng', NEWID(), N'Hoàn tất'),
(2, 750000, N'Chuyển khoản ngân hàng', NEWID(), N'Hoàn tất'),
(3, 300000, N'Tiền mặt', NEWID(), N'Hoàn tất'),
(4, 900000, N'Momo', NEWID(), N'Chưa thanh toán'),
(5, 400000, N'Chuyển khoản ngân hàng', NEWID(), N'Hoàn tất');

-- Thêm dữ liệu vào bảng Complaints
INSERT INTO Complaints (UserID, ReportID, ViolationID, ComplaintText, Status) VALUES 
(3, 1, 1, N'Tôi không đồng ý với biên bản này, vì tôi không lái xe vào thời điểm đó.', N'Chờ xử lý'),
(3, 2, 2, N'Xe của tôi bị báo lỗi sai.', N'Đã xử lý'),
(3, 4, 4, N'Tôi muốn kháng nghị vì xe của tôi bị báo sai lỗi.', N'Chờ xử lý'),
(3, 5, 5, N'Biên bản phạt này có sai sót.', N'Đã xử lý');





