# 🚀 Công Nghệ Phát Triển Ứng Dụng - Bài 3 (Application Development Technology)

Dự án ứng dụng Web áp dụng kiến trúc MVC (Model - View - Controller) được xây dựng trên nền tảng ASP.NET Core mạnh mẽ. 

**🧑‍💻 Nguồn code / Phát triển bởi:** QUÂN IT  
**📦 Link tải Full Code (Bản đầy đủ):** [Tải tại Gofile](https://gofile.io/d/4sqDlM)  
**🔗 Repository chính:** [GitHub - Cong-Nghe-Phat-Trien-Ung-Dung-Bai-3](https://github.com/azmedia2006/Cong-Nghe-Phat-Trien-Ung-Dung-Bai-3)

---

## 🇻🇳 HƯỚNG DẪN BẰNG TIẾNG VIỆT

### 🛠️ 1. Yêu cầu hệ thống (Môi trường Local)
Để mở và chạy được dự án này một cách trơn tru trên máy tính, bạn cần có:
- **[.NET SDK](https://dotnet.microsoft.com/en-us/download)** (Bắt buộc).
- **[Visual Studio 2022](https://visualstudio.microsoft.com/)** (Khuyên dùng) hoặc **Visual Studio Code**.
- Hệ quản trị cơ sở dữ liệu **SQL Server**.

### ⚙️ 2. Cách chạy dự án trên máy tính (How to run locally)

#### Cách A: Chạy bằng Visual Studio 2022 (Cách dễ nhất)
1. **Tải mã nguồn:** Nhấn nút **Code** trên GitHub -> Chọn **Download ZIP** và giải nén. Hoặc dùng lệnh: `git clone https://github.com/azmedia2006/Cong-Nghe-Phat-Trien-Ung-Dung-Bai-3.git`
2. **Mở dự án:** Click đúp chuột vào file `DMQuan.csproj` để mở bằng Visual Studio.
3. **Khôi phục thư viện:** Chờ một lát để Visual Studio tự động tải các gói thư viện (Restore NuGet Packages).
4. **Cấu hình Database:** Mở file `appsettings.json` để kiểm tra chuỗi kết nối (Connection String). Mở *Package Manager Console* và gõ lệnh `Update-Database` để tạo database.
5. **Chạy web:** Nhấn phím **F5** hoặc nút **Play** (hình tam giác màu xanh lá). Trình duyệt sẽ tự động bật lên hiển thị trang web.

#### Cách B: Chạy bằng Command Line (Terminal / CMD)
1. Tải code: `git clone https://github.com/azmedia2006/Cong-Nghe-Phat-Trien-Ung-Dung-Bai-3.git`
2. Di chuyển vào thư mục dự án: `cd Cong-Nghe-Phat-Trien-Ung-Dung-Bai-3`
3. Khôi phục thư viện: `dotnet restore`
4. Khởi chạy ứng dụng: `dotnet run`
5. Copy đường link hiển thị (Ví dụ: `http://localhost:xxxx`) và dán lên trình duyệt web.

### 🌐 3. Hướng dẫn Triển khai lên Website thực tế (Deployment)

Để đưa website lên Internet cho mọi người truy cập (sử dụng Domain riêng), bạn cần thực hiện bước **Publish** code và đẩy lên Server (VPS hoặc Hosting).

**Bước 3.1: Publish (Xuất bản) Code từ Visual Studio**
1. Mở project trong Visual Studio 2022.
2. Click chuột phải vào project `DMQuan` ở cột Solution Explorer -> Chọn **Publish**.
3. Chọn Target là **Folder** -> Chọn đường dẫn lưu file publish trên máy -> Nhấn nút **Publish**.
4. Bạn sẽ nhận được một thư mục chứa toàn bộ file đã được biên dịch (không còn mã nguồn C# thô). Nén thư mục này thành file `.zip`.

**Bước 3.2: Đưa lên Server**
Tùy thuộc vào hạ tầng bạn đang sử dụng:

* **Lựa chọn A: Triển khai trên Windows Server VPS (Sử dụng IIS)**
    1. Cài đặt **.NET Core Hosting Bundle** (phiên bản tương ứng với project) trên VPS.
    2. Cài đặt và bật tính năng **IIS (Internet Information Services)**.
    3. Copy file `.zip` đã publish lên VPS và giải nén vào thư mục `C:\inetpub\wwwroot\TenWebCuaBan`.
    4. Mở IIS Manager, tạo một website mới, trỏ Physical Path về thư mục vừa giải nén và liên kết với Domain của bạn.
    5. Import database `.sql` vào SQL Server trên VPS và sửa lại chuỗi kết nối trong file `appsettings.json` trên VPS.

* **Lựa chọn B: Triển khai trên Web Hosting (Plesk/cPanel)**
    1. *Lưu ý:* Hosting của bạn bắt buộc phải hỗ trợ **ASP.NET Core**. (Các gói hosting Windows hoặc Plesk thường hỗ trợ tốt).
    2. Đăng nhập vào trang quản trị Hosting, mở **File Manager**.
    3. Upload file `.zip` đã publish vào thư mục `httpdocs` (hoặc `public_html`) và giải nén.
    4. Cấu hình kết nối Database trong phần quản lý MS SQL Database của Hosting, sau đó cập nhật lại `appsettings.json`.

* **Lựa chọn C: Triển khai trên Linux VPS (Ubuntu/CentOS)**
    1. Cài đặt `.NET Runtime` trên Linux.
    2. Upload file publish lên thư mục `/var/www/TenWebCuaBan`.
    3. Cấu hình **Nginx** hoặc **Apache** làm Reverse Proxy để chuyển tiếp port 80/443 vào port mà Kestrel của ứng dụng .NET đang chạy (thường là 5000).
    4. Tạo một *systemd service* để giữ cho ứng dụng .NET luôn chạy ngầm.

---
---

## 🇬🇧 ENGLISH INSTRUCTIONS

### 🛠️ 1. Prerequisites (Local Environment)
To run this project locally, you will need:
- **[.NET SDK](https://dotnet.microsoft.com/en-us/download)** (Required).
- **[Visual Studio 2022](https://visualstudio.microsoft.com/)** (Highly recommended) or **Visual Studio Code**.
- **SQL Server**.

### ⚙️ 2. How to Run Locally

#### Method A: Using Visual Studio 2022 (Recommended)
1. **Download the source code:** Click **Code** -> **Download ZIP** and extract it. Or run: `git clone https://github.com/azmedia2006/Cong-Nghe-Phat-Trien-Ung-Dung-Bai-3.git`
2. **Open the project:** Double-click the `DMQuan.csproj` file to open it.
3. **Restore packages:** Wait for Visual Studio to restore NuGet packages.
4. **Database Configuration:** Check `appsettings.json` for the Connection String. Open *Package Manager Console* and run `Update-Database`.
5. **Run the app:** Press **F5** or click the green **Play** button. Your browser will open automatically.

#### Method B: Using Command Line
1. Clone the repository: `git clone https://github.com/azmedia2006/Cong-Nghe-Phat-Trien-Ung-Dung-Bai-3.git`
2. Navigate to directory: `cd Cong-Nghe-Phat-Trien-Ung-Dung-Bai-3`
3. Restore dependencies: `dotnet restore`
4. Run application: `dotnet run`
5. Copy the listening URL (e.g., `http://localhost:xxxx`) into your browser.

### 🌐 3. Deployment Guide (Live Website)

To host your application on the internet with a custom domain, you need to **Publish** the app and deploy it to a Server (VPS or Web Hosting).

**Step 3.1: Publish the Application**
1. Open the project in Visual Studio 2022.
2. Right-click the `DMQuan` project in Solution Explorer -> Select **Publish**.
3. Choose **Folder** as the target -> Select a local path -> Click **Publish**.
4. Zip the output folder containing the compiled files.

**Step 3.2: Deploy to Server**
Depending on your infrastructure:

* **Option A: Windows Server VPS (Using IIS)**
    1. Install the **.NET Core Hosting Bundle** on your VPS.
    2. Enable **IIS (Internet Information Services)**.
    3. Copy and extract your published `.zip` file to `C:\inetpub\wwwroot\YourWebName`.
    4. Open IIS Manager, add a new Website, bind your domain, and point the Physical Path to the extracted folder.
    5. Import your `.sql` database to the SQL Server on the VPS and update the `appsettings.json` connection string.

* **Option B: Web Hosting (Plesk/cPanel)**
    1. *Note:* Your hosting provider must support **ASP.NET Core**.
    2. Log in to your Hosting Control Panel and open the **File Manager**.
    3. Upload the published `.zip` file to `httpdocs` (or `public_html`) and extract it.
    4. Setup your MS SQL Database in the control panel and update `appsettings.json` accordingly.

* **Option C: Linux VPS (Ubuntu/CentOS)**
    1. Install the `.NET Runtime` on your Linux server.
    2. Upload the published files to `/var/www/YourWebName`.
    3. Configure **Nginx** or **Apache** as a Reverse Proxy to forward traffic from port 80/443 to your app's Kestrel port (usually 5000).
    4. Create a *systemd service* to keep the application running in the background.
