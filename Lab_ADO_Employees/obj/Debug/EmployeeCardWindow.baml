   M S B A M L   `   `   `  ����L  HLab_ADO_Employees, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Lab_ADO_EmployeesLab_ADO_Employees  5   	   *    $Lab_ADO_Employees.EmployeeCardWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Lab_ADO_Employees     5   	     � Title$  EmployeeCard��5   	   $	��400��6   $	��800��6+    � 	Resources 5	       �� 
TargetType �� Property �� Value��%D  '��       '�� �     �� 5
   
   " ��6   .�5      ��  � ��$ 	20 8 20 8q�6'   �� 5       � ��$	 100��6&   �� 5       � ��$ 30��6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 	20 8 20 8q�6'   �� 5       � ��$	 100��6&   �� 5       � ��$ 30��6'   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��	dataGrid1��5   :   $��
0, 0, 0, 0q�6   
�������   AutoGenerateColumns .     HorizontalGridLinesBrush
 �����   RowBackground
 �����	   AlternatingRowBackground
	 �����
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$	 180 6o   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   ��  �� Path$ CardEmployeeName�6o   4  .System.Windows.Controls.DataGridTemplateColumn  5       $ Photo��6)      CellTemplate 5!      �� 5"      .R�5#      �� ��6$   �� $ 	CardPhoto�5$         CellEditingTemplate 5&      �� 5'      .R�5(      �� ��6&   �� $ 	CardPhoto�5)      5+        5,      $	 Age��6%   $ 50 6O    62   �� $	 Age�6O     5-      $ 
Department��6%   $	 120 6a    69   �� $ CardDepartment�6a     5.      $ Position��6%   $	 120 6]    67   �� $ CardPosition�6]     5/      $ Phone��6%   $	 100 6W    64   �� $ 	CardPhone�6W   52      �� 54   
   $��Center=�6   $��1��63    �� Orientation$ 
Horizontal=�6@   .+�55      �� -   5         ��Name$ edit_btn��55      $
��Edit��6'   
�������$��20,0,20,8.4q�6M   $��30��6b   $��Bottom=�6n   6�   57      58      59      