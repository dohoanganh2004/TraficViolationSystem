   M S B A M L   `   `   `  ����K  GTrafficViolation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:TrafficViolation.ReportControllTrafficViolation.ReportControll  5   	   0    *TrafficViolation.ReportControll.ReportView   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:TrafficViolation.ReportControll     5   	     � Title$  
ReportView��5   	   $	��500��6   $
��1100��6)   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	dgReports��5
         AutoGenerateColumns$ False��6&      HeadersVisibility$ Column=�6B   $��10,10,10,50q�5   /      
IsReadOnly$ False��5      ��5      �� *	Reports+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Report ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6U      
IsReadOnly$
 True��6`   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 68   �� *
ReportId+6`     5      $ Reporter ID��6%   $ 80 6Y   $
 True��6d   	 6:   �� *
ReporterId+6d     5      $ Violation Type��6%   $	 150 6l   	 6=   �� *ViolationType+
 �� Mode$
 TwoWay=�6l     5      $ Description��6%   $	 200 6g   	 6:   �� *Description+$
 TwoWay=�6g     5      $ Plate Number��6%   $	 100 6h   	 6;   �� *PlateNumber+$
 TwoWay=�6h     5      $ Location��6%   $	 150 6a   	 67   �� *
Location+$
 TwoWay=�6a     5      $ Report Date��6%   $	 120 6f   	 6:   �� *
ReportDate+$
 TwoWay=�6f     5      $ Status��6%   $	 100 6]   	 65   �� *Status+$
 TwoWay=�6]   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 Edit��6)   $ 80 67      CellTemplate 5      �� 5      .R�5      �� -   5        $
��Edit��5   %   $	��5,2q�64   ��5   !   �� 5      5         5#      $ Delete��6)   $ 80 69    5$      �� 5%      .R�5&      �� -   5        $��Delete��5&   %   $	��5,2q�66   ��5(   !   �� 5)      5+      5-      �� 50   
   -   5        $
��Back��50      $
��Left=�6    $��Bottom=�6;   $��	10,0,0,10q�51      $
��10,5q�6    6/   �� 54   
   -   5        $��Create Report��54      $��Right=�6)   $��Bottom=�6E   $��	0,0,10,10q�55      $
��10,5q�6    6/   56      58      