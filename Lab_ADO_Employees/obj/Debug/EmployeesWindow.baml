   M S B A M L   `   `   `  ����L  HLab_ADO_Employees, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Lab_ADO_EmployeesLab_ADO_Employees  5   	   '    !Lab_ADO_Employees.EmployeesWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Lab_ADO_Employees     5   	     � Title$  	Employees��5   	   $	��400��6   $	��800��6(    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�  '��       '�� �     '�� 0    �� 5
   
   " ��6   .�5      ��  � ��$ 	20 8 20 8q�6'   �� 5       � ��$	 100��6&   �� 5       � ��$ 30��6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 	20 8 20 8q�6'   �� 5       � ��$	 100��6&   �� 5       � ��$ 30��6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 	20 8 20 8q�6'   �� 5       � ��$	 100��6&   �� 5       � ��$ 30��6'   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5    
   &   System.Windows.Controls.DataGrid  -   5        $��	dataGrid1��5    :   $��
0, 0, 0, 0q�6   
�������   AutoGenerateColumns .     HorizontalGridLinesBrush
 �����   RowBackground
 �����	   AlternatingRowBackground
	 �����
   Columns
 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Header$ Personnel Number��6%      
IsReadOnly .    
Foreground
 ��  �1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   ��  �� Path$ 
EmployeeId�6u     5&      $
 Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 250 6Y    63   �� $ EmployeeName�6Y   5)      �� 5+   
   $��Center=�6   $��1��63    �� Orientation$ 
Horizontal=�6@   .+�5,      �� $��Personnel #��6    �� TextAlignment$ Right=�6+   $��Center=�6A   $��Center=�6\    �� Padding$ 5q�6y   $��20,8,20,8.4q�6�   $��81��6�   �� 5-      -   5         ��Name$ search_pers_n��5-      
�������6-   �� 5.      -   5         ��Name$ 
search_btn��5.      $��Search��6)   
�������6Q   �� 5/      -   5        $ add_btn��5/      $	��Add��6&   
�������6K   �� 50      -   5        $ del_btn��50      $��Delete��6&   
�������6N   52      53      54      