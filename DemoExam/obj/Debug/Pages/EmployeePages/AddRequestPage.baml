   M S B A M L   `   `   `  ����C  ?DemoExam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:DemoExam.Pages.EmployeePagesDemoExam.Pages.EmployeePages  5      1    +DemoExam.Pages.EmployeePages.AddRequestPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:DemoExam.Pages.EmployeePages     5      -   5          N� Title$  AddRequestPage��5	      .��5      � ���#202020 � RowDefinitions 5   
   �� 5      �� 5      $��7* �6   �� 5      .+�5   
   �� -   5         ��Name$ TBMainLabel��5      $��Center=�5      $��Center=�5      
�������$��24(�5      �� 5   
   -   5         ��Name$ BBack��5      $
��Left=�5      $	��Top=�5      $��
Назад��5      $��5q�5      $��20��5      $��50��5       
���  ��5"      �� 5$   
   $	��200��6   $��Center=�5%      $��1q�5&      
����p��$��1��5(      ._�5)      �� -   5         ��Name$ SPMain��5*      $��10q�5)      .+�5+      �� $��Техник:��6   
�������
 � Tag$ ForEdit��5-      �� 5.      -   5         ��Name$ CBMaster��5.       �� SelectedValuePath$ UserID��5/       �� DisplayMemberPath$
 Name��50      $ ForEdit��52      	 �� SelectedValue	 51      �� *
MasterID+52      �� 54      $��Клиент:��6   
�������55      �� 56      -   5        $ CBClient��56      $ UserID��57      $
 Name��58      	 59      �� *
ClientID+�� 5;      $��Устройство:��6   
�������5<      �� 5=      -   5        $ 
CBTechType��5=      $ 
TechTypeID��5>      $ TechType��5?      	 5@      �� *
TechTypeID+�� 5B      $$��Модель/Название:��6   
�������5C      �� 5D      -   5        
 ��Name$
 TBTechModel��5D      ��5E      �� *	TechModel+�� 5G      $+��%Дата начала ремонта:��6   
�������5H      (  "System.Windows.Controls.DatePicker  5I      -	   5          Name$ DPStartDate��5I         SelectedDate 5J      �� *	StartDate+�� 5L      $��Статуc заказа��6   
�������$ ForEdit��5N      �� 5O      -
   5        $ CBStatus��5O      $ RequestStatusID��5P      $ Status��5Q      $ ForEdit��5S      	 5R      �� *RequestStatusID+5S      �� 5U      $��Описание:��6   
�������$ ForEdit��5W      �� 5X      -   5        $
 TBDescription��5X      $��85��5Y      $ ForEdit��5[      ��5Z      �� *Description+5[      5\      5]      �� 5_   
   -   5        $ BAddRequest��5_      $��2��5`      $	��100��5a      $��40��5b      5c      5d      5e      