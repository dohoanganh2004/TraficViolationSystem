Hệ thống báo cáo và quản lý vi phạm giao thông, cho phép người dân gửi báo cáo vi phạm kèm hình ảnh/video, cảnh sát/quản trị viên xử lý báo cáo và ra quyết định xử phạt, người vi phạm có thể khiếu nại và thanh toán tiền phạt trực tuyến.

Dự án gồm 2 ứng dụng độc lập giao tiếp qua REST API:

Project	Vai trò	Công nghệ
TrafficViolationReportingSystem	Backend – Web API	ASP.NET Core 8 Web API
TrafficViolationSystemClient	Frontend – giao diện người dùng	ASP.NET Core 8 MVC (Razor Views)
🎯 Mục tiêu dự án
Hỗ trợ người dân báo cáo vi phạm giao thông nhanh chóng, kèm bằng chứng hình ảnh/video
Giúp cơ quan chức năng (cảnh sát/admin) tiếp nhận, xác minh và xử lý báo cáo tập trung
Hỗ trợ khiếu nại (appeal) và thanh toán phạt trực tuyến, thông báo real-time
Áp dụng kiến trúc Backend .NET chuẩn: JWT, phân quyền theo permission, REST API
🛠️ Công nghệ sử dụng
Backend (TrafficViolationReportingSystem)

ASP.NET Core 8 Web API
Entity Framework Core 8 (SQL Server)
Xác thực: JWT Bearer (Microsoft.AspNetCore.Authentication.JwtBearer)
Phân quyền: policy-based theo permission (Authorization/)
AutoMapper cho DTO mapping
SignalR (với Redis backplane) cho thông báo real-time
Redis (StackExchangeRedis) cho distributed cache
Swagger / OpenAPI (Swashbuckle) cho API docs
Gửi email qua SMTP (Gmail) cho xác thực và quên mật khẩu
Frontend (TrafficViolationSystemClient)

ASP.NET Core 8 MVC (Razor Views)
Gọi API backend qua HttpClient
ClosedXML cho xuất báo cáo Excel
Lưu JWT token nhận từ API để gọi các endpoint được bảo vệ
Hạ tầng

SQL Server 2022 (Docker)
Redis 7 (Docker)
Docker Compose để chạy toàn bộ hệ thống (docker-compose.yml)
🏗️ Kiến trúc
Backend theo mô hình phân lớp:

Controller → Service → Repository → DTO (AutoMapper) → EF Core → SQL Server
Controllers/ – expose REST endpoint, xác thực JWT + [Authorize]
Services/ – nghiệp vụ (business logic)
Repositories/ – truy cập dữ liệu qua EF Core
DTO/ – Data Transfer Object, map bằng AutoMapper (Mapping/)
Models/ – entity EF Core + TrafficViolationDbContext
JWT/ – sinh & xác thực token
Authorization/ – permission-based authorization policy/handler
GlobalException/ – middleware xử lý exception tập trung, custom exception hierarchy
Hub/ – SignalR hub cho thông báo real-time (/hubs/notification)
Cache/ – wrapper cho Redis distributed cache
Frontend là ứng dụng MVC thuần Razor, gọi sang backend qua HTTP và giữ vai trò hiển thị/điều hướng.

📦 Chức năng chính
Xác thực & phân quyền: đăng ký, đăng nhập (JWT), quên/đổi mật khẩu (token-based, gửi qua email), phân quyền theo vai trò (Citizen, Police, Admin) và permission chi tiết
Báo cáo vi phạm (Report): người dân gửi báo cáo kèm media (ảnh/video), tra cứu trạng thái
Vi phạm (Violation): xử lý báo cáo thành vi phạm chính thức, tra cứu theo phương tiện/người vi phạm
Loại vi phạm (ViolationType): danh mục loại vi phạm và mức phạt
Phương tiện (Vehicle): quản lý thông tin phương tiện liên quan vi phạm
Khiếu nại (Appeal): người vi phạm gửi khiếu nại với vi phạm bị lập
Thanh toán (Payment): thanh toán tiền phạt trực tuyến
Thông báo (Notification): real-time qua SignalR
Audit log: ghi log các thao tác quan trọng trong hệ thống
Xuất báo cáo Excel (phía client, dùng ClosedXML)
