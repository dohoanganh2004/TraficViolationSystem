   M S B A M L   `   `   `  ����K  GTrafficViolation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:TrafficViolation.UserControllTrafficViolation.UserControll  5   	   .    (TrafficViolation.UserControll.ManageUser   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:TrafficViolation.UserControll     5   	     � Title$  Manage User��5   	   $	��500��6   $	��800��6*    � WindowStartupLocation$ CenterScreen=�5	   	   .��5      � -   5        $��gridUser��5   "   
����ح�$��0,0,0,13q�62    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5"   
   �� $��0��6   $��0��6   $��User ID:��6-   �� 5#   
   -   5        $��	txtUserId��5#   C   $��0��6   $��1��6   $��
10,3,367,3q�6/    �� 
IsReadOnly$
 True��6T   �� 5%   
   $��1��6   $��0��6   $��
Full Name:��6-   �� 5&   
   -   5        $��txtFullName��5&   C   $��1��6   $��1��6   $��
10,3,367,3q�6/   6C   �� 5(   
   $��2��6   $��0��6   $��Email:��6-   �� 5)   
   -   5        $��txtEmail��5)   C   $��2��6   $��1��6   $��
10,3,367,3q�6/   6C   �� 5+   
   $��3��6   $��0��6   $��Phone:��6-   �� 5,   
   -   5        $��txtPhone��5,   C   $��3��6   $��1��6   $��
10,3,367,3q�6/   6C   �� 5.   
   $��4��6   $��0��6   $��	Password:��6-   G� 5/   
   -   5        $��txtPassword��5/   G   $��4��6   $��1��6#   $��
10,3,367,3q�63   6G   �� 51   
   $��5��6   $��0��6   $��Role:��6-   �� 52   
   -   5        $��cbRole��52   D   $��5��6   $��1��6    $��
10,3,367,3q�60   6D   �� 54   
   $��6��6   $��0��6   $��Address:��6-   �� 55   
   -   5        $��
txtAddress��55   C   $��6��6   $��1��6   $��
10,3,367,3q�6/   6C   �� 57   
   $��7��6   $��0��6   $��Image:��6-   �� 58   
   -	   5        $��txtImage��58   C   $��7��6   $��1��6   $��
10,3,367,3q�6/   6C   �� 5<   
   $��Search by Name:��6   $��8��6*   $��0��67   $��Center=�6G   �� 5=   
   -
   5        $��txtSearchName��5=      $��1��6'   $��8��67   $��
10,2,367,5q�6D   �� 5>   
   -   5        $��	btnSearch��5>   "   $��Search��6   $��1��63   $��8��6C   $��350,0,257,26q�6h   $��2��6~   �� 5A   
   $��Filter by Role:��6   $��9��6+   $��0��68   $��Center=�6H   $��10,0,0,0q�6c   �� 5B   
   -   5        $��cbFilterRole��5B   0   $��1��6   $��9��6#   $��10,0,367,26q�6D   $��2��6Y   �� 5C   
   -   5        $��	btnFilter��5C   "   $��Filter��6   $��1��63   $��9��6C   $��350,0,257,26q�6h   $��2��6~   �� 5I   
   $��10��6   $��1��6#    �� Orientation$ 
Horizontal=�63   .+�5J      �� -   5        $��
btnAddUser��5J   <   $��80��6   $��3q�6#   $	��Add��6.   6N   �� 5K      -   5        $��btnUpdateUser��5K   ?   $��80��6   $��3q�6#   $��Update��6.   6T   5L      &   System.Windows.Controls.DataGrid  5O   
   -   5        $��GridUser��5O   5   $��12��6   $��2��6!      AutoGenerateColumns$ False��6E      
IsReadOnly$
 True��6a   $��3,0,3,0q�5P      $��2��6Q      Columns 5Q      0  *System.Windows.Controls.DataGridTextColumn  5R      ,  &System.Windows.Controls.DataGridColumn	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6%   
   Header$
 User ID��6/   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *UserId+  5S      $	 * 6%   $
 	Full Name��6/    6B   �� *
FullName+  5T      $	 * 6%   $
 Email��6/    6>   �� *Email+  5U      $	 * 6%   $
 Phone��6/    6>   �� *Phone+  5V      $	 * 6%   $
 Password��6/    6A   �� *
Password+  5W      $	 * 6%   $

 Role��6/    6=   �� *Role.RoleName+  5X      $	 * 6%   $
 Address��6/    6@   �� *	Address+  5Y      $	 * 6%   $
 Image��6/    6>   �� *Image+5[      5\      5]      