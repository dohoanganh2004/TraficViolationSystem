   M S B A M L   `   `   `  ����K  GTrafficViolation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TrafficViolationTrafficViolation  5   	   "    TrafficViolation.MainWindow3   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TrafficViolation     5   	     � Title$  MainWindow3��5   	   $	��450��6   $	��800��6*   ��5	      �� 5
   
    �� 
StartPoint$	 0,0&�6    �� EndPoint$	 1,1&�6/   .��5      �  � Color$ #003366��6    � Offset$	 0.0Q�6+   � 5      $ #00AEEF��6   $	 1.0Q�6+   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6   .+�5   
   � $��1��6   .+�5      �� $��Traffic Violation System��6   $��24(�5      $
��Bold"�6   
�������$
��Left=�5!      $��	50,30,0,0q�6+   $	��Top=�5"      �� 5%      -   5        $��50��5%      $��50��6    
�������$��2q�5&      $��Right=�5'      $��	0,20,20,0q�6!   $	��Top=�5(       � Cursor$
 Hand��5)      ._�5+      �� -   5        $��
UserAvatar��5+      $��Images/avatar.jpg��5,   	   $
��Fill=�5-   	   $��50��6   $��50��6#    � ContextMenu 5.      �� 5/      -   5         ��Name$ 
AvatarMenu��5/   "   $
|�True��66   .@�50      m� -   5        $��Xem Thông Tin��50   #   6:   m� 51      -   5        $��Đổi Mật Khẩu��51   #   69   �� 52      m� 53      -   5        $��Đăng Xuất��53   #   66   54      56      �� 59      -   5        $��Quản Lý Người Dùng��59      $
��Left=�62   $��68��6M   $��	37,86,0,0q�6Y   $	��Top=�6l   $	��127��6�   6�   �� 5:      -   5        $��btReport��5:   �   $��Báo Cáo Vi Phạm��6   $
��Left=�6/   $��65��6J   $��
200,89,0,0q�6V   $	��Top=�6j   $	��128��6�   6�   �� 5;      -	   5        $	��bt2��5;   �   $��Báo Cáo Vi Phạm��6   $
��Left=�6/   $��65��6J   $��
350,89,0,0q�6V   $	��Top=�6j   $	��128��6�   6�   �� 5<      -
   5        $��Vi phạm báo cáo��5<      $
��Left=�6/   $��
37,234,0,0q�6J   $	��Top=�6^   $	��129��6v   	 J� RenderTransformOrigin$	 0.5,0.5&�6�   $��60��6�   6�   �� 5=      -   5        $��Thông Báo��5=      $
��Left=�6)   $��200,234,0,0q�6D   $	��Top=�6Y   $��57��6q   $	��128��6}   6�   �� 5>      -   5        $��LogOut��5>      $
��Left=�6&   $��350,234,0,0q�6A   $	��Top=�6V   $��57��6n   $	��128��6z   6�   5?      5A      5B      