   M S B A M L   `   `   `  ����L  HLab_ADO_Employees, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Lab_ADO_EmployeesLab_ADO_Employees  5   	   $    Lab_ADO_Employees.SalaryWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Lab_ADO_Employees     5   	     � Title$  Salary��5   	   $	��450��6   $	��800��6%    � 	Resources 5	       �� 
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
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      
Visibility$ Hidden=�6S      Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6g   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   ��  �� Path$ SalEmpId�6g     5       $
 Name��6%   $	 200 6U    63   �� $ EmplName�6U     5!      $ Tariff��6%   $ 80 6X    65   �� $ 	TariffFor�6X     5"      $ Hours Worked��6%   $	 150 6Z    6;   �� $ Hours�6Z     5#      $ Award��6%   $	 150 6S    64   �� $ Award�6S     5$      $ Total��6%   $	 150 6S    64   �� $ Total�6S   5'      �� 5(   
   $��Center=�6   $��1��63    �� Orientation$ 
Horizontal=�6@   .+�5)      �� -   5         ��Name$ edit_btn��5)      $
��Edit��6'   $��20,8,20,8.4q�66   $
��Auto��6K   6Y   �� 5*      -   5        $ avg_btn��5*      $	��Avg��6&   $��20,8,20,8.4q�64   $
��Auto��6I   6W   �� 5+      -   5        $ fund_btn��5+      $��Payment Fund��6'   $��20,8,20,8.4q�6>   $
��Auto��6S   6a   5-      5.      5/      