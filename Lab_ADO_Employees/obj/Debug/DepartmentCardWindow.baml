   M S B A M L   `   `   `  ����L  HLab_ADO_Employees, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Lab_ADO_EmployeesLab_ADO_Employees  5   	   ,    &Lab_ADO_Employees.DepartmentCardWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Lab_ADO_Employees     5   	     � Title$  DepartmentCardWindow��5   	   $	��400��6&   $	��800��63    � 	Resources 5	       �� 
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
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$	 180 6j   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   ��  �� Path$ CardDepName�6j   4  .System.Windows.Controls.DataGridTemplateColumn  5       $ Photo��6)      CellTemplate 5!      �� 5"      .R�5#      �� ��6$   �� $ CardDepPhoto�5$         CellEditingTemplate 5&      �� 5'      .R�5(      �� ��6&   �� $ CardDepPhoto�5)      5+        5,      $ Position��6%   $	 180 6`    67   �� $ CardDepPosition�6`   5/      �� 51   
   $��Center=�6   $��1��63    �� Orientation$ 
Horizontal=�6@   .+�52      �� -   5         ��Name$ vac_btn��52      $��	Vacancies��6&   
�������6Q   �� 53      -   5        $ 	staff_btn��53      $��
StaffTable��6(   
�������6T   55      56      57      