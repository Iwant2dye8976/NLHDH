# Minh họa thuật toán FCFS(First-Come, First-Served) qua winform C#
**First-Come, First-Served (FCFS)** là một trong những thuật toán lập lịch CPU đơn giản nhất. Trong thuật toán này, các tiến trình được thực thi theo thứ tự chúng đến trước, không quan tâm đến thời gian thực thi (Burst Time) của chúng. Tiến trình đến trước sẽ được xử lý trước, tiến trình đến sau sẽ phải chờ cho đến khi tất cả các tiến trình đến trước đó được thực hiện xong.

**Ưu điểm:**
  •Dễ hiểu và dễ triển khai.
  •Thích hợp cho các hệ thống với các yêu cầu đơn giản hoặc các tác vụ có thứ tự rõ ràng.
**Nhược điểm:**
  • Convoy Effect: Nếu một tiến trình có thời gian thực thi lớn, các tiến trình có thời gian thực thi nhỏ phải chờ lâu, gây ra sự thiếu hiệu quả.
  • Thời gian chờ đợi trung bình có thể cao: Khi nhiều tiến trình đến sau một tiến trình có thời gian thực thi dài.

# Hình ảnh về chương trình
![image](https://github.com/user-attachments/assets/845d6786-e45f-48dc-b31b-396bf83fb718)


Chương trình cho người dùng nhập **số tiến trình** và nhập **Thời gian thực thi(Burst Time)**
**Thời gian chờ(Waiting Time) trung bình** và **Thời gian quay vòng trung bình** được tự động tính sau khi nhấn nút _"Hoàn tất"_
![image](https://github.com/user-attachments/assets/a8900aad-aa3a-4c32-bd9c-f6126fe1f47e)


**Chức năng Random**: 
Với một số lượng tiến trình lớn thì việc nhập tay tốn rất nhiều thời gian. Vì vậy, nhóm đã thêm chức năng **Random** để hỗ trợ việc tính toán với nhiều tiến trình.
Người dùng chỉ cần nhập số lượng tiến trình và nhấn nút _"Random"_.
![image](https://github.com/user-attachments/assets/43ed286a-1a42-450b-a1b7-fc04f06dd2a7)



