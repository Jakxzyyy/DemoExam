   M S B A M L   `   `   `  ����C  ?DemoExam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:DemoExam.Pages.EmployeePagesDemoExam.Pages.EmployeePages  5      1    +DemoExam.Pages.EmployeePages.AddRequestPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:DemoExam.Pages.EmployeePages     5        N� Title$  AddRequestPage��5	      .��5      � ���#202020 � RowDefinitions 5   
   �� 5      �� 5      $��7* �6   �� 5      .+�5   
   �� $��Center=�6   $��Center=�5      $'��!Добавление заявки��5      
�������$��24(�5      �� 5   
   $	��200��6   $��Center=�5      $��1q�5      
����p��$��1��5      ._�5      �� $��10q�6   .+�5      �� $��Техник:��6   
�������5       �� 5!      -   5         ��Name$ CBMaster��5!       �� SelectedValuePath$ MasterID��5"       �� DisplayMemberPath$
 Name��5#      �� 5%      $��Клиент:��6   
�������5&      �� 5'      -   5        $ CBClient��5'      $ ClientID��5(      $
 Name��5)       �� SelectedValue 5*      �� *
ClientID+�� 5,      $��Устройство:��6   
�������5-      �� 5.      -   5        $ 
CBTechType��5.      $ 
TechTypeID��5/      $ TechType��50       51      �� *
TechTypeID+�� 53      $#��Модель/Название��6   
�������54      �� 55      ��6   �� *	TechModel+�� 57      $��Описание:��6   
�������58      �� 59      $	��100��6   ��5:      �� *Description+5;      5<      �� 5>   
   -   5         ��Name$ BAddRequest��5>      $��Добавить��5?      $��2��5@      $	��100��5A      $��40��5B      5C      5D      5E      