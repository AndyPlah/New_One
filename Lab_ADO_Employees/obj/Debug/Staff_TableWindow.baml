   M S B A M L   `   `   `  ����L  HLab_ADO_Employees, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Lab_ADO_EmployeesLab_ADO_Employees  5   	   )    #Lab_ADO_Employees.Staff_TableWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Lab_ADO_Employees     5   	     � Title$  Staff_Table��5   	   $	��450��6   $	��800��6*    � 	Resources 5	       �� 
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
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6S      
Visibility$ Hidden=�6_   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   ��  �� Path$ IdPosFor�6_     5       $ Position��6%   $	 100 6\    67   �� $ PositionFor�6\     5!      $ 
Department��6%   $ 80 6Y    69   �� $ DepFor�6Y     5"      $ Quantity��6%   $	 150 6Y    67   �� $ Quantity�6Y     5#      $	 Now��6%   $	 150 6O    62   �� $	 Now�6O   5&      �� 5'   
   $��Center=�6   $��1��63    �� Orientation$ 
Horizontal=�6@   .+�5(      �� -   5         ��Name$ add_btn��5(      $	��Add��6&   
�������6K   �� 5)      -   5        $ del_btn��5)      $��Delete��6&   
�������6N   �� 5*      -   5        $ edit_btn��5*      $
��Edit��6'   
�������6M   5,      5-      5.      