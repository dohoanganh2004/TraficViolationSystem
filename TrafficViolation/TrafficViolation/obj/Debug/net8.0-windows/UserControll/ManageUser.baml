   M S B A M L   `   `   `  ����K  GTrafficViolation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:TrafficViolation.UserControllTrafficViolation.UserControll  5   	   .    (TrafficViolation.UserControll.ManageUser   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:TrafficViolation.UserControll     5   	     � Title$  
ManageUser��5   	   $	��450��6   $	��800��6)   .��5	      � -   5        $��gridUser��5	   "   
����ح� � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6   $��
Full Name:��6-   �� 5   
   $��1��6   $��0��6   $��Email:��6-   �� 5   
   $��2��6   $��0��6   $��Phone:��6-   �� 5   
   $��3��6   $��0��6   $��	Password:��6-   �� 5   
   $��4��6   $��0��6   $��Role:��6-   �� 5   
   $��5��6   $��0��6   $��Address:��6-   �� 5    
   $��6��6   $��0��6   $��Image:��6-   �� 5"   
   -   5        $��txtFullName��5"   a   $��0��6   $��1��6   $��3q�6/   $	��300��6:   $
��Left=�6F   6a   �� 5#   
   -   5        $��txtEmail��5#   a   $��1��6   $��1��6   $��3q�6/   $	��300��6:   $
��Left=�6F   6a   �� 5$   
   -   5        $��txtPhone��5$   a   $��2��6   $��1��6   $��3q�6/   $	��300��6:   $
��Left=�6F   6a   G� 5%   
   -   5        $��txtPassword��5%   e   $��3��6   $��1��6#   $��3q�63   $	��300��6>   $
��Left=�6J   6e   �� 5&   
   -   5        $��cbRole��5&   b   $��4��6   $��1��6    $��3q�60   $	��300��6;   $
��Left=�6G   6b   �� 5'   
   -   5        $��
txtAddress��5'   a   $��5��6   $��1��6   $��3q�6/   $	��300��6:   $
��Left=�6F   6a   �� 5(   
   -   5        $��txtImage��5(   a   $��6��6   $��1��6   $��3q�6/   $	��300��6:   $
��Left=�6F   6a   �� 5*   
   $��7��6   $��1��6"    �� Orientation$ 
Horizontal=�62   .+�5+      �� -	   5        $��
btnAddUser��5+   <   $��80��6   $��3q�6#   $	��Add��6.   6N   �� 5,      -
   5        $��btnUpdateUser��5,   ?   $��80��6   $��3q�6#   $��Update��6.   6?   5-      &   System.Windows.Controls.DataGrid  5/   
   -   5        $��GridUser��5/   4   $��8��6   $��2��6       AutoGenerateColumns$ False��6D      
IsReadOnly$
 True��6`   $��-3,0,3,0q�6r      Columns 50      0  *System.Windows.Controls.DataGridTextColumn  51      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      Header$ UserID��6/   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6?   �� *UserId+  52      $ * 6%   $ 	Full Name��6/   	 6B   �� *
FullName+  53      $ * 6%   $ Email��6/   	 6>   �� *Email+  54      $ * 6%   $ Phone��6/   	 6>   �� *Phone+  55      $ * 6%   $ Password��6/   	 6A   �� *
Password+  56      $ * 6%   $
 Role��6/   	 6=   �� *Role.RoleName+  57      $ * 6%   $ Address��6/   	 6@   �� *	Address+  58      $ * 6%   $ Image��6/   	 6>   �� *Image+5:      5;      5<      