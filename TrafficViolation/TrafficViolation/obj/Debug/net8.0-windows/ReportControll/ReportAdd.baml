   M S B A M L   `   `   `  ����K  GTrafficViolation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:TrafficViolation.ReportControllTrafficViolation.ReportControll  5   	   /    )TrafficViolation.ReportControll.ReportAdd   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:TrafficViolation.ReportControll     5   	     � Title$  	ReportAdd��5   	   $	��450��6   $	��800��6(   .��5
      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6   $��Biển số xe:��6-   �� 5   
   -   5        $��txtPlateNumber��5   /   $��0��6   $��1��6   $	��200��6E   �� 5   
   $��1��6   $��0��6   $��Loại vi phạm:��6-   �� 5   
   -   5        $��cbViolationType��5   0   $��1��6   $��1��6    $	��200��6G   .@�5      �� $��Vượt đèn đỏ��6   �� 5       $��Chạy quá tốc độ��6   �� 5!      $��Đi sai làn đường��6   5"      �� 5$   
   $��2��6   $��0��6   $��	Mô tả:��6-   �� 5%   
   -   5        $��txtDescription��5%   /   $��2��6   $��1��6   $	��200��6E   $��50��6Q    �� AcceptsReturn$
 True��6]   �� 5'   
   $��3��6   $��0��6   $��Hình ảnh (URL):��6-   �� 5(   
   -   5        $��txtImageUrl��5(   /   $��3��6   $��1��6   $	��200��6B   �� 5*   
   $��4��6   $��0��6   $��Video (URL):��6-   �� 5+   
   -   5        $��txtVideoUrl��5+   /   $��4��6   $��1��6   $	��200��6B   �� 5-   
   $��5��6   $��0��6   $��
Vị trí:��6-   �� 5.   
   -   5        $��txtLocation��5.   /   $��5��6   $��1��6   $	��200��6B   �� 50   
   $��6��6   $��2��6"    �� Orientation$ 
Horizontal=�66   $��Center=�6O   $��10q�6l   .+�51      �� -   5        $��btnSave��51      $
��Lưu��6$   $��80��62   $��5q�6=   6H   �� 52      -   5        $��	btnCancel��52      $��Hủy��6&   $��80��64   $��5q�6?   6J   53      54      55      