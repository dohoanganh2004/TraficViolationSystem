   M S B A M L   `   `   `  ����K  GTrafficViolation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:TrafficViolation.ControlTrafficViolation.Control  5   	   !    TrafficViolation.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   :control&clr-namespace:TrafficViolation.Control     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�5   	   ��5	      �� 5
   
    �� 
StartPoint$	 0,0&�6    �� EndPoint$	 1,1&�6/   .��5      �  � Color$ #003366��6    � Offset$	 0.0Q�6+   � 5      $ #00AEEF��6   $	 1.0Q�6+   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6   .+�5   
   )   #TrafficViolation.Control.LeftNavbar  )   #TrafficViolation.Control.LeftNavbar   Loaded$ LeftNavbar_Loaded��6-   $��0��6   6-   � 5   
   $��1��6   .+�5      �� $��Traffic Violation System��6   $��24(�5      $
��Bold"�6"   
�������$
��Left=�5!      $��	50,30,0,0q�6/   $	��Top=�5"      �� 5%      $��50��6   $��50��6    
�������$��2q�5&   )   $��Right=�5'      $��	0,20,20,0q�61   $	��Top=�5(       � Cursor$
 Hand��5)      ._�5+      �� -   5        $��
UserAvatar��5+      $��Images/avatar.jpg��5,      $
��Fill=�5-      $��50��6'   $��50��62   $
 Hand��5.      	 � ContextMenu	 5/      �� 50      $
|�True��6&   .@�51      m� -   5        $��Xem Thông Tin��51   '   6>   m� 52      -   5        $��Đổi Mật Khẩu��52   '   6=   �� 53      m� 54      -   5        $��Đăng Xuất��54   '   6:   55      57      58      �� 59      -   5        $��Quản Lý Người Dùng��59      $
��Left=�62   $��68��6M   $��	37,86,0,0q�6Y   $	��Top=�6l   $	��127��6�   6�   �� 5:      -   5        $��btReport��5:   �   $��Quản Lý Báo Cáo ��6   $
��Left=�60   $��65��6K   $��
200,89,0,0q�6W   $	��Top=�6k   $	��128��6�   6�   �� 5;      -   5        $��
btVolation��5;   �   $��Quản Lý Vi Phạm��6   $
��Left=�6/   $��65��6J   $��
360,89,0,0q�6V   $	��Top=�6j   $	��129��6�   6�   �� 5<      -   5        $��Quản Lý Khiếu Nại��5<      $
��Left=�61   $��
37,234,0,0q�6L   $	��Top=�6`   $	��129��6x   
 J� RenderTransformOrigin$
 0.5,0.5&�6�   $��60��6�   z�5=      V� 5>      .~�5?      �� �� 5@      �� 5A       �� Angle$ -0.641Q�6*   T� 5B      5C      5E      �� 5F      -	   5        $��Quản Lý Thông Báo��5F      $
��Left=�61   $��200,234,0,0q�6L   $	��Top=�6a   $��57��6y   $	��128��6�   6�   �� 5G      -
   5        $��Quan Lý Giao Dịch��5G      $
��Left=�61   $��57��6L   $��360,234,0,0q�6X   $	��Top=�6m   $	��129��6�   6�   5H      5J      5K      