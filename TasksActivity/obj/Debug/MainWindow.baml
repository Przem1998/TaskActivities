   M S B A M L   `   `   `  ����H  DTasksActivity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:TasksActivityTasksActivity  5   	       TasksActivity.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:TasksActivity     5   	     � Title$  
MainWindow��5   	   $	��250��6   $	��500��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��0.4* �6   �� 5      $
��0.6* �6   .+�5   
   �� $��0��6   $��0,10,0,0q�6"   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $3��-Wprowadź zakres poszukiwanych liczb od 2 do ��6   �� 5      -   5         ��Name$ range��5   S   $
��Left=�6   $��23��65   $��10,0,0,0q�6A   $	��Top=�6b   $	��120��6z   �� 5      -   5        $��Szukaj��5      $��50��6*   $��20��65   $��10,2,0,0q�6A   $	��Top=�6S   6k   5      �� 5      $ 
Horizontal=�6   .+�5      �� $ ��Wprowadź ilość tasków ��6   $��	120,0,0,0q�69   �� 5      -   5        $ amount��5   S   $
��Left=�6   $��23��65   $��15,0,0,0q�6A   $	��Top=�6c   $��30��6{   5      �� 5      -   5         ��Name$ comments��5      5      �� 5   
   $��1��6   $
��Auto=�6$   .��5      �� -   5         ��Name$ firstNumbers��5      $	��500��61   $	��100��6=   6J   5      5$      5%      