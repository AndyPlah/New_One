   M S B A M L   `   `   `  ����L  HLab_ADO_Employees, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Lab_ADO_EmployeesLab_ADO_Employees  5   	   "    Lab_ADO_Employees.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Lab_ADO_Employees     5   	     � Title$  Lab_Employees��5   	   $	��300��6   $	��450��6,    � 
ResizeMode$ NoResize=�68   .��5	      � 
������� � RowDefinitions 5
   
   �� 5      $
��100* �6   �� 5      $
��100* �6   �� 5      $
��100* �6    � ColumnDefinitions 5   
   �� 5      $
��200* �6   �� 5      $
��243* �6   .+�5   
   �� $��Login��6   $��0��6!   $��0��61   $��25(�6>    �� TextAlignment$ Center=�6L   $��Right=�6c   $��Center=�6   $��34��6�   $��61��6�   �� 5   
   -   5         ��Name$ loginBox��5      $��1��6$   $��0��64   $��25(�6A   $	��200��6O    �� TextAlignment$
 Left=�6[   $��Center=�6p   $��Center=�6�   $��35��6�   �� 5   
   $��Password��6   $��0��6$   $��1��64   $��25(�6A   $ Center=�6O   $��Right=�6f   $��Center=�6�   $��33��6�   $	��103��6�   G� 5   
   -   5        $��passwordBox��5      $��1��6)   $��1��69   $��25(�6F   $	��200��6T   $��Center=�6`   $��Center=�6}   $��35��6�   �� 5   
   -   5        $��Ok��5      
�������$��0��64   $��2��6D   $��Right=�6Q   $��Center=�6m   $	��121��6�   $��51��6�   $��25(�6�   6�   �� 5   
   -   5         �� IsCancel . $��Cancel��5   !   
�������$��Center=�6H   $��Center=�6e   $	��121��6�   $��51��6�   $��1��6�   $��2��6�   $��25(�6�   6�   5      5      