   M S B A M L   `   `   `  ����K  GTrafficViolation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:TrafficViolation.NotificationControll%TrafficViolation.NotificationControll  5   	   >    8TrafficViolation.NotificationControll.NotificationManage   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:TrafficViolation.NotificationControll     5   	     � Title$  NotificationManage��5   	   $	��700��6$   $	��700��61   
����ح� � WindowStartupLocation$ CenterScreen=�5
   	   .��5      �  � RowDefinitions 5   
   �� 5      $
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
��Auto �6   �� 5      $��* �6   .+�5!   
   �� $��Quản Lý Thông Báo��6   $��0��5"      $��2��6   
���  ��$��24(�5$      $
��Bold"�5%       �� TextAlignment$
 Left=�5&      $
��Left=�5'      $��Center=�5(      $��20,0,0,0q�5)      �� 5+   
   $��2��6   $��Id��6   �� 5,   
   $��4��6   $��Người Nhận��6   �� 5-   
   $��6��6   $��Biển Số Xe��6   �� 5.   
   $��8��6   $��Nội Dung Tin Nhắn��6   �� 5/   
   $��10��6   $��Ngày Gửi��6   �� 50   
   $��12��6   $��Trạng Thái��6   �� 52   
   -   5        $��txtNotificationID��52   0   $��3��6   $��3,3,5,5q�6   60   �� 53   
   -   5        $��	txtUserId��53   0   $��3��6   $��3,3,5,5q�6   $y�Hidden=�6A   �� 55   
   -   5        $��txtUser��55   0   $��5��6   $��3,3,5,5q�6   60   �� 56   
   -   5        $��txtPlateNumber��56   0   $��7��6   $��3,3,5,5q�6   60   �� 57   
   -   5        $��
txtMassage��57   1   $��9��6   $��3,3,5,5q�6    61   (  "System.Windows.Controls.DatePicker  58   
   -   5        $��txtSendDate��58   4   $��11��6   $��3,3,5,5q�6#   64   �� 59   
   $��13��6    �� Orientation$ 
Horizontal=�6#   $��3,3,5,5q�6<   .+�5:      	� -   5         	�Name$ rbUnread��5:   E   $��Chưa đọc ��6    	� 	GroupName$ 
ReadStatus��6.   6E   	� 5;      -   5        $ rbRead��5;   T   $��Đã đọc��6   $ 
ReadStatus��6+   $��10,0,0,0q�6B   6T   5<      �� 5=   
   $��15��6   $ 
Horizontal=�6#   $��3,3,5,5q�6<   .+�5?      �� -	   5        $��
EditButton��5?   :   $
��Edit��6   $��60��6$   $��6q�6/   6L   �� 5@      -
   5        $��ResetButton��5@   ;   $��Reset��6   $��60��6%   $��6q�60   6N   5B      &   System.Windows.Controls.DataGrid  5C   
   -   5        $��dgNotifications��5C   -   $��16��6   $��10q�6!      AutoGenerateColumns$ False��6D      HeadersVisibility$ Column=�5D      	   CanUserAddRows$	 False��6&   
   
IsReadOnly$

 True��6=      Columns 5E      0  *System.Windows.Controls.DataGridTextColumn  5F      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *NotificationId+6T     5G      $ UserID��6%   $ 50 6P      
Visibility$ 	Collapsed=�6[    65   �� *UserId+6[     5J      $ Người Nhận��6%   $	 100 6[    69   �� *User.FullName+6[     5K      $ Biển Số Xe��6%   $ 90 6Y    69   �� *PlateNumber+6Y     5L      $ Nội Dung Tin Nhắn��6%   $	 250 6\    6@   �� *	Message+6\     5M      $ Ngày Gửi��6%   $ 95 6U    67   �� *
SentDate+6U     5N      $ Trạng Thái��6%   $ 90 6U    69   �� *IsRead+6U   5P      5T      5W      