   M S B A M L   `   `   `  ����@  <laba2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:laba2laba2  5   	       laba2.CarsWindow   5   	   _ [MaterialDesignThemes.Wpf, Version=4.7.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:laba2     5   	     � Title$  
CarsWindow��5	   	   $
��Auto��6   $
��Auto��6*   .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ CarsData��5         
IsReadOnly . $��0��67   �� 5   
   -   5         ��Name$ modelBox��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Модель��6$   $��1��6L   �� 5   
   -   5        $ 	numberBox��5      $ 
Номер��6%   $��2��6L   �� 5   
   -   5        $ colorBox��5      $ Цвет��6$   $��3��6J   �� 5   
   -   5         ��Name$ createButton��5      $��Добавить��6'   $��4��6:   $��10q�6G   5      �� 5   
   -   5        $ updateButton��5      $��Изменить��6'   $��5��6:   $��10q�6G   5      �� 5   
   -   5        $ deleteButton��5      $��Удалить��6'   $��6��69   $��10q�6F   5      5      5      