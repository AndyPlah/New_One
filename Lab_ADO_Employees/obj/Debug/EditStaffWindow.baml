   M S B A M L   `   `   `  ����L  HLab_ADO_Employees, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Lab_ADO_EmployeesLab_ADO_Employees  5   	   '    !Lab_ADO_Employees.EditStaffWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Lab_ADO_Employees     5   	     � Title$  EditStaffWindow��5   	   $	��300��6!   $	��550��6.   .��5
      � 
������� � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��100* �6   �� 5      $
��100* �6   �� 5      $
��100* �6   .+�5   
   �� $��
PositionID��6   $��0��6&   $��0��66   $��20(�6C    �� TextAlignment$ Center=�6Q   $��Right=�6h   $��Center=�6�   $��34��6�   $	��110��6�   �� 5   
   $��Quantity��6   $��0��6$   $��1��64   $��20(�6A   $ Center=�6O   $��Right=�6f   $��Center=�6�   $��34��6�   $	��110��6�   �� 5   
   $	��Now��6   $��0��6   $��2��6/   $��20(�6<   $ Center=�6J   $��Right=�6a   $��Center=�6}   $��34��6�   $	��110��6�   �� 5   
   -   5         ��Name$ IdBox��5      $��1��6!   $��0��61   $��25(�6>   $	��200��6L    �� TextAlignment$ Center=�6X   $��Center=�6o   $��Center=�6�   $��35��6�    �� 
IsReadOnly . 6�   �� 5    
   -   5         ��Name$ quanBox��5       $��1��6$   $��1��64   $��25(�6A   $	��200��6O   $��Center=�6[   $��Center=�6x   $��35��6�   �� 5!   
   -   5        $ nowBox��5!      $��1��6#   $��2��63   $��25(�6@   $	��200��6N   $��Center=�6Z   $��Center=�6w   $��35��6�   �� 5%   
   -   5         ��Name$	 Add��5%      $��2��6   $��0��6.   
�������$��50��6R   $
��Edit��6^   $	��100��6m   $��Bottom=�6y   6�   �� 5&   
   -   5        $ Cancel��5&      $��2��6!   $��2��61   	 �� IsCancel	 . 
�������$	��100��6e   $��50��6q   $��Cancel��6}   $	��Top=�6�   6�   5(      5)      