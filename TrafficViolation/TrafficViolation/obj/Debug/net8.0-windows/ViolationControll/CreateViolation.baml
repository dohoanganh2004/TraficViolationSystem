   M S B A M L   `   `   `  ����  TrafficViolation8    2TrafficViolation.ViolationControll.CreateViolation   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Create Violation��5   	   $	��600��6"   $
��1000��6/    � WindowStartupLocation$ CenterScreen=�5   	   
����ح�.��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   ���#FFD700 �� Padding$ 10q�63   $��0,5,0,5q�6@   ._�5      �� $��BIÊN BẢN PHẠT��6   $��24(�6-   $
��Bold"�6;   $��Center=�6M   5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $��2* �6#   �� 5      $��1* �6#   �� 5      $��2* �6#   .+�5      �� $��0��6   $ 10q�6%   
�������$��2��6E   $��	0,0,118,0q�6Y   ._�5      �� $��10q�6   .+�5"      �� -   5        $��txtReportID��5"      $y�	Collapsed=�61   �� 5#      -   5        $��txtValidatorID��5#      $y�	Collapsed=�64   �� 5%      $��Lỗi vi phạm:��6    $
��Bold"�64   �� 5&      -   5        $��txtViolationType��5&      �� 5(      $��Người vi phạm:��6    $
��Bold"�66   �� 5)      -   5        $��txtViolator��5)      �� 5+      $��Biển số xe:��6    $
��Bold"�63   �� 5,      -   5        $��txtPlateNumber��5,      �� 5.      $��	Mô tả:��6    $
��Bold"�6.   �� 5/      -   5        $��txtDescription��5/      $��60��64    �� TextWrapping$
 Wrap=�6@    �� AcceptsReturn$
 True��6T   �� 51      $��Số tiền phạt:��6    $
��Bold"�65   �� 52      -   5        $��txtFineAmount��52      �� 54      $��Ngày phạt:��6    $
��Bold"�62   (  "System.Windows.Controls.DatePicker  55      -   5        $��
dpFineDate��55   !   �� 57      $ ��Trạng thái thanh toán:��6    $
��Bold"�6>   �� 58      -	   5        $��cbPaidStatus��58      .@�59      �� $��Chưa thanh toán��6'   �� 5:      $��Đã thanh toán��6'   5;      �� 5=      $��Địa điểm vi phạm:��6    $
��Bold"�69   �� 5>      -
   5        $��txtLocation��5>      5?      5@      �� 5C      $��1��6   $ 10q�6%   
�������$��2��6E   $��83,0,0,0q�6Y   ._�5D      �� $��10q�6   .+�5E      �� $��Hình ảnh:��6   $
��Bold"�60   �� 5F      -   5        $��imgViolation��5F      $	��150��60   $��Uniform=�6=   ��6O   �� *
ImageUrl+�� 5H      $��Video:��6   $
��Bold"�6-   r� 5I      -   5        $��videoViolation��5I   #   $	��150��69    r� Stretch$ Uniform=�6F    r� LoadedBehavior$ Manual=�6X   	 r� Source	 6p   �� *
VideoUrl+5J      5K      5L      �� 5O   
   $��2��6   
 �� Orientation$
 
Horizontal=�6"   $��Center=�6;   $��10q�6X   .+�5P      �� -   5        $��	btnCreate��5P      $��Tạo��6&   $	��100��64   $��40��6@   
��� � �
�������$
��Bold"�6r   $��10q�6�   6�   �� 5Q      -   5        $��btnClose��5Q      $��Đóng��6%   $	��100��64   $��40��6@   
���  ��
�������$
��Bold"�6p   $��10q�6�   6�   5R      5S      5T      