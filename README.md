# Minh họa thuật toán FCFS(First-Come, First-Served) qua winform C#
**First-Come, First-Served (FCFS)** là một trong những thuật toán lập lịch CPU đơn giản nhất. Trong thuật toán này, các tiến trình được thực thi theo thứ tự chúng đến trước, không quan tâm đến thời gian thực thi (Burst Time) của chúng. Tiến trình đến trước sẽ được xử lý trước, tiến trình đến sau sẽ phải chờ cho đến khi tất cả các tiến trình đến trước đó được thực hiện xong.

**Ưu điểm:**
  •Dễ hiểu và dễ triển khai.
  •Thích hợp cho các hệ thống với các yêu cầu đơn giản hoặc các tác vụ có thứ tự rõ ràng.
**Nhược điểm:**
  • Convoy Effect: Nếu một tiến trình có thời gian thực thi lớn, các tiến trình có thời gian thực thi nhỏ phải chờ lâu, gây ra sự thiếu hiệu quả.
  • Thời gian chờ đợi trung bình có thể cao: Khi nhiều tiến trình đến sau một tiến trình có thời gian thực thi dài.

# Hình ảnh về chương trình
![image](https://github.com/user-attachments/assets/48cbc2c1-1d21-4449-b1ea-8cbd9bc3314a)

Chương trình cho người dùng nhập **số tiến trình** và nhập **Thời gian thực thi(Burst Time)**
**Thời gian chờ(Waiting Time) trung bình** và **Thời gian quay vòng trung bình** được tự động tính sau khi nhấn nút _"Hoàn tất"_
![image](https://github.com/user-attachments/assets/b3b63895-0a81-4219-a136-76d891795d1f)

**Chức năng Random**: 
Với một số lượng tiến trình lớn thì việc nhập tay tốn rất nhiều thời gian. Vì vậy, nhóm đã thêm chức năng **Random** để hỗ trợ việc tính toán với nhiều tiến trình.
Người dùng chỉ cần nhập số lượng tiến trình và nhấn nút _"Random"_.
![image](https://github.com/user-attachments/assets/40d66d87-f7d1-4344-b780-448f0c46fe69)


