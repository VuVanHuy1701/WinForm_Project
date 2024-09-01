# WinForm_Project
Đồ án bán hàng trên Winform là một phần mềm được thiết kế để hỗ trợ các doanh nghiệp trong việc quản lý bán hàng một cách hiệu quả. Phần mềm này bao gồm các chức năng cơ bản như quản lý sản phẩm, quản lý khách hàng, quản lý đơn hàng, và quản lý kho hàng. Giao diện được thiết kế trực quan, dễ sử dụng, với các form nhập liệu và hiển thị thông tin rõ ràng, giúp người dùng dễ dàng thao tác và quản lý dữ liệu.

Chức năng quản lý sản phẩm cho phép thêm, sửa, xóa và tìm kiếm sản phẩm theo nhiều tiêu chí khác nhau như tên sản phẩm, mã sản phẩm, hoặc danh mục sản phẩm. Chức năng quản lý khách hàng lưu trữ thông tin chi tiết về khách hàng, hỗ trợ theo dõi lịch sử mua hàng và tạo ra các chương trình ưu đãi dành riêng cho từng nhóm khách hàng.

Phần mềm cũng tích hợp hệ thống quản lý đơn hàng, cho phép theo dõi trạng thái đơn hàng từ lúc tạo đơn đến khi giao hàng và thanh toán hoàn tất. Ngoài ra, tính năng quản lý kho giúp cập nhật số lượng hàng tồn kho, cảnh báo khi hàng sắp hết và hỗ trợ việc đặt hàng từ nhà cung cấp.

Với đồ án bán hàng trên Winform, người dùng không chỉ tiết kiệm thời gian trong việc quản lý công việc kinh doanh hàng ngày mà còn giảm thiểu sai sót trong quá trình nhập liệu và xử lý thông tin.

Giới thiệu
Phần Mềm Quản Lý Bán Hàng WinForms là một ứng dụng desktop được phát triển bằng C# và .NET Framework, giúp các doanh nghiệp vừa và nhỏ quản lý việc bán hàng, hàng tồn kho, và thông tin khách hàng một cách hiệu quả. Phần mềm cung cấp giao diện người dùng thân thiện, dễ sử dụng và có thể tùy chỉnh theo nhu cầu của từng doanh nghiệp.

Chức năng chính
  Quản lý sản phẩm: Thêm, sửa, xóa và xem chi tiết sản phẩm.
  Quản lý đơn hàng: Tạo mới, cập nhật, và theo dõi trạng thái đơn hàng.
  Quản lý khách hàng: Lưu trữ và quản lý thông tin khách hàng, bao gồm lịch sử mua hàng.
  Báo cáo bán hàng: Tạo báo cáo chi tiết về doanh thu, số lượng hàng bán ra, và các chỉ số kinh doanh khác.
  Quản lý tồn kho: Theo dõi số lượng hàng tồn kho, cảnh báo khi hàng sắp hết.
  In hóa đơn: Hỗ trợ in hóa đơn bán hàng với thiết kế tùy chỉnh.
Yêu cầu hệ thống
  Hệ điều hành: Windows 7 trở lên
  .NET Framework: 4.6.1 hoặc mới hơn
  Cơ sở dữ liệu: SQL Server 2012 trở lên
  Thư viện bổ sung: Entity Framework, Dapper

Cách cài đặt
  Clone repository:
  bash
  Sao chép mã
  git clone https://github.com/username/sales-management-winform.git

Cấu hình cơ sở dữ liệu:
  Tạo một cơ sở dữ liệu mới trên SQL Server.
  Cập nhật chuỗi kết nối trong file App.config với thông tin cơ sở dữ liệu của bạn.

Cài đặt các phụ thuộc:
  Đảm bảo đã cài đặt .NET Framework 4.6.1 hoặc mới hơn.
  Mở dự án bằng Visual Studio và phục hồi các gói NuGet nếu cần.

Chạy dự án:
  Xây dựng và chạy ứng dụng từ Visual Studio.
Cách sử dụng
  Đăng nhập: Sử dụng tài khoản quản trị mặc định để đăng nhập vào hệ thống. (Tài Khoản: Admin; Mật Khẩu: Admin)
  Quản lý sản phẩm: Vào mục "Quản lý sản phẩm" để thêm mới hoặc cập nhật thông tin sản phẩm.
  Tạo đơn hàng: Chọn sản phẩm và điền các thông tin cần thiết để hoàn tất quá trình bán hàng.
  Xem báo cáo: Truy cập "Báo cáo bán hàng" để xem các báo cáo chi tiết về doanh thu theo ngày, tuần, hoặc tháng.
