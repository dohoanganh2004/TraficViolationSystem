   M S B A M L   `   `   `  ����K  GTrafficViolation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:TrafficViolation.ViolationControll"TrafficViolation.ViolationControll  5   	   8    2TrafficViolation.ViolationControll.ViolationManage   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:TrafficViolation.ViolationControll     5   	     � Title$  Quản Lý Vi Phạm��5   	   $	��500��6!   $	��900��6.   
����ح� � WindowStartupLocation$ CenterScreen=�5
   	   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Quản Lý Vi Phạm��6   
���  ��$��24(�5      $
��Bold"�5      $��Center=�5      $��	0,10,0,10q�5      �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $
��Left=�6;   $��0,5,0,5q�6V   .+�5      �� $��Biển số xe:��6   $��Center=�6*   �� 5      -   5        $��txtSearchPlate��5      $	��200��6,   $	��5,0q�68   �� 5       $��Tên người vi phạm:��6   $��Center=�61   $��10,0,0,0q�6L   �� 5!      -   5        $��txtSearchName��5!      $	��200��6+   $	��5,0q�67   �� 5"      -   5        $��Tìm Kiếm��5"      $	��100��6(   $
��10,0q�64   6B   5#      �� 5&   
   $��2��6   $ 
Horizontal=�6"   $
��Left=�6;   $��0,5,0,5q�6V   .+�5'      �� $$��Sắp xếp theo ngày phạt:��6   $��Center=�66   �� 5(      -   5        $��cbSortByDate��5(      $	��150��6+   $	��5,0q�67   .@�5)      �� $��Mới nhất��6    �� 
IsSelected$
 True��62   �� 5*      $��
Cũ nhất��6   5+      �� 5,      -   5        $��Sắp Xếp��5,      $	��100��6'   $
��10,0q�63   6A   5-      &   System.Windows.Controls.DataGrid  50   
   -   5        $��GridViolation��50       $��3��6      AutoGenerateColumns$ False��65      
IsReadOnly$
 True��6Q   $��0,10,0,0q�51         Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6%   	   Header$	 ID��60   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6<   �� *ViolationId+  54      $	 200 6%   $	 Lỗi Vi Phạm��61   
 6F   �� *Report.ViolationType+  55      $ * 6%   $	 Biển Số Xe��6/   
 6C   �� *PlateNumber+  56      $ * 6%   $	 Người Vi Phạm��6/   
 6F   �� *Violator.FullName+  57      $ * 6%   $	 Tiền Phạt��6/   
 6B   �� *
FineAmount+  58      $	 100 6%   $	 Ngày Phạt��61   
 6D   �� *
FineDate+ �� StringFormat$ 
dd/MM/yyyy��4  .System.Windows.Controls.DataGridCheckBoxColumn  59      $ 70 6)   $	 Đóng Phạt��64   
 6G   �� *
PaidStatus+5;      5<      5=      