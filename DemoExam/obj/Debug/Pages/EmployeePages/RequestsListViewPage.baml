   M S B A M L   `   `   `  ����C  ?DemoExam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:DemoExam.Pages.EmployeePagesDemoExam.Pages.EmployeePages  5      7    1DemoExam.Pages.EmployeePages.RequestsListViewPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:DemoExam.Pages.EmployeePages     5        N� Title$  RequestsListViewPage��5	       � 	Resources 5      *  $System.Windows.Controls.DataGridCell �� 
TargetType   	CellStyle �� Property �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader  HeaderStyle��%�   &	        &	 t     �� 5   
   "  6   .�5      ��  � �� �#2020206+   �� 5       � ��
 �����6+   5      �� 5   
   "  6   .�5      ��  � �� �#2020206+   �� 5       � ��
 �����6+   5      5      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
DGRequests��5      ���#202020   AutoGenerateColumns .     	CellStyle# [  5         ColumnHeaderStyle# [ 5      	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 № заявки��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *	RequestID+  5      $!
 Вид устройства��6%    6=   �� *TechTypes.TechType+  5      $
 Название��6%    67   �� *	TechModel+  5       $
 Описание��6%    67   �� *Description+  5!      $
 Статус��6%    65   �� *RequestStatuses.Status+  5"      $ 
 Закреплено за:��6%    6=   �� *Users1.Surname+  5#      $%
 Дата закрепления��6%      	CellStyle# [  6]    6?   �� *	StartDate+6]     5$      $#
 Дата завершения��6%   # [  6a    6>   �� *ComplitionDate+6a     5%      $
 Клиент��6%   # [  6W    65   �� *Users.Surname+6W   5'      55      56      