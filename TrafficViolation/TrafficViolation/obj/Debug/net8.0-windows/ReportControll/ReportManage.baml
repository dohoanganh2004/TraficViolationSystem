   M S B A M L   `   `   `  ����  TrafficViolation2    ,TrafficViolation.ReportControll.ReportManage   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Report Manage��5   	   $	��600��6   $	��900��6,   
����ح� � WindowStartupLocation$ CenterScreen=�5   	   .��5      � $��10q�6    � RowDefinitions 5	   
   �� 5
      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $/��)Quản Lý Phản Ánh Từ Người Dân��6   
���  ��$��24(�5   %   $
��Bold"�5      $��Center=�6&   $��	0,10,0,20q�5      �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $��0,0,0,10q�6X   .+�5      �� $��Tên người báo cáo:��6   $��Center=�61   �� 5      -   5         ��Name$ txtReporter��5      $	��120��6+   $
��10,0q�67   �� 5      $��Biển số xe:��6   $��Center=�6*   �� 5      -   5        $ txtPlateNumber��5      $	��120��6.   $
��10,0q�6:   �� 5       -   5        $��Tìm kiếm��5       $
��10,5q�6@   $��10,0,0,0q�6O   5!      �� 5#   
   $��2��6   $ 
Horizontal=�6"   $��Center=�6;   $��0,0,0,10q�6X   .+�5%      �� $��Trạng thái:��6   $��Center=�6*   $��75��6E   �� 5&      -   5         ��Name$ cbStatusFilter��5&      $	��120��6/   $
��10,0q�6;   .@�5'      �� $��
Tất cả��6    �� 
IsSelected$
 True��60   �� 5(      $��Chờ xử lý��6   �� 5)      $��Đã duyệt��6   �� 5*      $��Bị từ chối��6   5+      �� 5,      -   5        $��Lọc��5,      $
��10,5q�6;   $��10,0,0,0q�6J   �� 5/      $��Sắp xếp theo ngày:��6   $��Center=�61   �� 50      -   5        $ cbSortOrder��50      $	��115��6,   $
��10,0q�68   .@�51      �� $��Mới nhất��6   $
 True��62   �� 52      $��
Cũ nhất��6   53      �� 54      -   5        $��Sắp xếp��54      $
��10,5q�6=   $��10,0,0,0q�6L   55      &   System.Windows.Controls.DataGrid  59   
   -   5          Name$ 
gridReport��59      $��3��6'      AutoGenerateColumns$ False��64   	   
IsReadOnly$
	 True��6P   $��0,10,0,0q�6b   
   Columns
 5:      0  *System.Windows.Controls.DataGridTextColumn  5;      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Report ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *
ReportId+6U     5<      $ Người báo cáo��6%   $	 220 6b    6<   �� *Reporter.FullName+6b     5=      $ Loại vi phạm��6%   $	 150 6]    6;   �� *ViolationType+6]     5>      $ Biển số xe��6%   $	 100 6Y    69   �� *PlateNumber+6Y     5?      $ Ngày báo cáo��6%   $	 120 6s    6;   �� *
ReportDate+ �� StringFormat$ 
yyyy-MM-dd��6s     5@      $ Trạng thái��6%   $	 100 6T    69   �� *Status+6T     5A      $ Người xử lý��6%   $	 120 6m    6:   �� * ProcessedByNavigation.FullName+6m   5C      5D      5E      