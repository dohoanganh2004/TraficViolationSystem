   M S B A M L   `   `   `  ����  TrafficViolation2    ,TrafficViolation.ReportControll.ReportManage   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Report Manage��5   	   $	��450��6   $	��900��6,   ��5      �� 5   
    �� 
StartPoint$	 0,0&�6    �� EndPoint$	 1,1&�6/   .��5      �  � Color$ #003366��6    � Offset$	 0.0Q�6+   � 5      $ #00AEEF��6   $	 1.0Q�6+   5	      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
gridReport��5      $��Stretch=�5      $	��310��61   $��10,114,10,0q�6>   $	��Top=�5         AutoGenerateColumns$ False��5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Report ID��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6U   
   MinWidth$
 80Q�6_   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *
ReportId+6_     5      $ Reporter��6%   $	 * 6]   $
 80Q�6g    67   �� *Reporter.FullName+6g     5      $ Violation Type��6%   $	 2* 6_   $	
 150Q�6j    6=   �� *ViolationType+6j     5      $ Plate Number��6%   $	 * 6[   $	
 100Q�6e    6;   �� *PlateNumber+6e     5      $ Report Date��6%   $	 * 6r   $	
 120Q�6|    6:   �� *
ReportDate+ �� StringFormat$ 
yyyy-MM-dd��6|     5      $ Status��6%   $	 * 6P   $	
 100Q�6Z    65   �� *Status+6Z   5      5      5      