   M S B A M L   `   `   `  ����K  GTrafficViolation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:TrafficViolation.ViolationControll"TrafficViolation.ViolationControll  5   	   8    2TrafficViolation.ViolationControll.ViolationManage   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:TrafficViolation.ViolationControll     5   	     � Title$  ViolationManage��5   	   $	��450��6!   $	��800��6.   .��5	      � $��10q�6   .+�5
   
   � -   5        $��gridViolation��5
   &   
����ح�$��10q�6;    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $��* �6     � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��GridViolation��5   8   $��8��6   $��2��6$      AutoGenerateColumns$ False��6M      
IsReadOnly$
 True��6i   $��10,143,10,10q�6{      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6)      Header$ Violation ID��63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6I   �� *ViolationId+  5      $ * 6)   $ Violation Type��63    6K   �� *Report.ViolationType+  5      $ * 6)   $ Plate Number��63    6I   �� *PlateNumber+  5       $ * 6)   $ Violator��63    6E   �� *Violator.FullName+  5!      $ * 6)   $ Fine Amount��63    6H   �� *
FineAmount+  5"      $ * 6)   $ 	Fine Date��63    6F   �� *
FineDate+	 �� StringFormat$	 
dd/MM/yyyy��4  .System.Windows.Controls.DataGridCheckBoxColumn  5#      $ * 6-   $ Paid Status��67    6L   �� *
PaidStatus+5%      5&      5'      5(      