   M S B A M L   `   `   `  ����L  HLab_ADO_Employees, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Lab_ADO_EmployeesLab_ADO_Employees  5   	   (    "Lab_ADO_Employees.EditSalaryWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Lab_ADO_Employees     5   	     � Title$  EditSalaryWindow��5   	   $	��300��6"   $	��750��6/   .��5
      � 
������� � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��100* �6   �� 5      $
��100* �6   �� 5      $
��100* �6   .+�5   
   �� $
��Name��6   $��0��6    $��0��60   $��20(�6=    �� TextAlignment$ Center=�6K   $��Right=�6b   $��Center=�6~   $��34��6�   $	��110��6�   �� 5   
   $��HoursWorked��6   $��0��6'   $��1��67   $��20(�6D   $ Center=�6R   $��Right=�6i   $��Center=�6�   $��34��6�   $	��110��6�   �� 5   
   $��Award��6   $��0��6!   $��2��61   $��20(�6>   $ Center=�6L   $��Right=�6c   $��Center=�6   $��34��6�   $	��110��6�   �� 5   
   -   5         ��Name$ nameBox��5      $��1��6#   $��0��63   $��25(�6@   $	��200��6N    �� TextAlignment$ Center=�6Z   $��Center=�6q   $��Center=�6�   $��35��6�    �� 
IsReadOnly . 6�   �� 5   
   -   5        $ hoursBox��5      $��1��6$   $��1��64   $��25(�6A   $	��200��6O   $ Center=�6[   $��Center=�6r   $��Center=�6�   $��35��6�   �� 5   
   -   5        $ awardBox��5      $��1��6$   $��2��64   $��25(�6A   $	��200��6O   $ Center=�6[   $��Center=�6r   $��Center=�6�   $��35��6�   �� 5   
   -   5         ��Name$
 Edit��5      $��2��6   $��0��6/   
�������$��50��6S   $
��Edit��6_   $	��100��6n   $��Bottom=�6z   6�   �� 5    
   -   5        $ Cancel��5       $��2��6!   $��2��61    �� IsCancel . 
�������$	��100��6e   $��50��6q   $��Cancel��6}   $	��Top=�6�   6�   5"      5#      