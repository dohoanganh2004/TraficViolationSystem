   M S B A M L   `   `   `  ����  TrafficViolation8    2TrafficViolation.ComplaintControll.ComplaintDetail   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Chi Tiết Khiếu Nại��5   	   $	��750��6$   $	��900��61   
����ح� � WindowStartupLocation$ CenterScreen=�5   	   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       $
��Auto �6   �� 5!      $
��Auto �6   �� 5"      $
��Auto �6   �� 5#      $
��Auto �6   �� 5$      $
��Auto �6   �� 5%      $��* �6    � ColumnDefinitions 5'   
   �� 5(      $	��500 �6   �� 5)      $��* �6   .+�5,   
   �� $1��+Chi Tiết Khiếu Nại Từ Người Dân��6   
���  ��$��24(�6L   $
��Bold"�5-      $��Center=�6&   $��	0,10,0,10q�6C   �� 5/   
   $��1��6   $��0��6"   $��10,10,10,15q�62   $��22��6G   .+�50      �� $��Mã Khiếu Nại��6   �� 51      -   5        $��txtComplaintID��51       �� 
IsReadOnly$
 True��6V   ��6,   �� *ComplaintId+ �� Mode$ TwoWay=�6V   �� 53      $��Lỗi Vi Phạm��6   �� 54      -   5        $��txtViolationType��54      ��6.   �� *Report.ViolationType+$ TwoWay=��� 56      $��Ngày Vi Phạm��6   (  "System.Windows.Controls.DatePicker  57      -   5        $��dpReportDate��57         SelectedDate 6-   �� *Report.ReportDate+$ TwoWay=��� 59      $��Biển Số Xe��6   �� 5:      -   5        $��txtPlateNumber��5:      ��6,   �� *Report.PlateNumber+$ TwoWay=��� 5<      $��Vị Trí Vi Phạm��6   �� 5=      -   5        $��txtLocation��5=      ��6)   �� *Report.Location+$ TwoWay=��� 5?      $��Nội Dung Khiếu Nại��6   �� 5@      -   5        $��txtComplaintText��5@       �� AcceptsReturn$
 True��6Z   $	��100��6o   ��6.   �� *ComplaintText+$ TwoWay=�6o   �� 5B      $��Ngày Khiếu Nại��6     5C      -   5        $��dpComplaintDate��5C       60   �� *ComplaintDate+$ TwoWay=��� 5E      $��Trạng Thái��6   �� 5F      -   5        $��	txtStatus��5F      ��6'   �� *Status+$ TwoWay=��� 5H      $��Người Xử Lý��6   �� 5I      -	   5        $��txtProcessedBy��5I      ��6,   �� * ProcessedByNavigation.FullName+$ TwoWay=��� 5K      $��Người Khiếu Nại��6   �� 5L      -
   5        $��txtComplaintBy��5L      ��6,   �� *User.FullName+$ TwoWay=��� 5M      -   5        $��	txtUserID��5M   .   $y�Hidden=�6?   ��6   �� *UserId+6?   �� 5N      -   5        $��txtReportID��5N   0   $y�Hidden=�6C   ��6   �� *
ReportId+6C   �� 5O      -   5        $��txtViolationId��5O   3   $y�Hidden=�6I   ��6   �� *ViolationId+6I   �� 5Q      -   5        $��txtProcesserId��5Q   D   $y�Hidden=�6Z   ��6   �� *ProcessedByNavigation.UserId+6Z   5T      �� 5V   
   $��22��6   $��0��6#    �� Orientation$ 
Horizontal=�63   $��Center=�6L   $��0,10,0,0q�6i   .+�5W      �� -   5        $��Chấp Nhận��5W      $	��100��6)   $��5q�65   6@   �� 5X      -   5        $��Từ Chối��5X      $	��100��6'   $��5q�63   6?   5Y      5Z      5[      