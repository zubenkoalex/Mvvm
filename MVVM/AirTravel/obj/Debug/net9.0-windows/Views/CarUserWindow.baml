   M S B A M L   `   `   `  ����?  ;Mvvm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Mvvm.Views
Mvvm.Views  5   	       Mvvm.Views.CarUserWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Mvvm.Views     5   	     � Title$
  User��5   	   $	��451��6   $
��1397��6#   .��5      � $��0,0,0,6q�6    � RowDefinitions 5   
   �� 5      �� 5      $��0 �6   .+�5   
   &   System.Windows.Controls.DataGrid     AutoGenerateColumns$ False��67      
IsReadOnly$
 True��6S   ��6   �� *CarEntities+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Автомобиль_ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *Id+6S     5      $ 
Марка��6%   $
 auto 6^    64   �� *MarkEntities.NameMark+6^     5      $ Модель��6%   $
 auto 6d    65   �� *ModelEntities.NameModelCar+6d     5      $ Поколение��6%   $
 auto 6n    68   �� *#!GenerationEntities.NameGeneration+6n     5      $ Тип топлива��6%   $
 auto 6f    6:   �� *PacageEntities.FuelType+6f     5      $# Объем двигателя��6%   $
 auto 6n    6>   �� *PacageEntities.EngineVolume+6n     5      $) #Мощность двигателя��6%   $
 auto 6p    6A   �� *PacageEntities.EnginePower+6p     5      $ Тип КПП��6%   $
 auto 6a    66   �� *PacageEntities.KPPType+6a     5      $ Тип привода��6%   $
 auto 6g    6:   �� *PacageEntities.DriveType+6g     5      $ Тип кузова��6%   $
 auto 6e    69   �� *PacageEntities.CallType+6e     5      $ Цвет кузова��6%   $
 auto 6g    6:   �� *PacageEntities.CallColor+6g     5      $ Руль��6%   $
 auto 6]    63   �� *PacageEntities.Rudder+6]     5      $/ )Название комплектации��6%   $
 auto 6r    6D   �� *PacageEntities.NamePacage+6r     5      $ Пробег��6%   $
 auto 6Q    65   �� *	Mileage+6Q     5       $ Цена��6%   $
 auto 6M    63   �� *Price+6M     5!      $ Год выпуска��6%   $
 auto 6Z    6:   �� *ReleaseYear+6Z   4  .System.Windows.Controls.DataGridTemplateColumn  5"      $ Картинка��6)      CellTemplate 5#      �� 5$      .R�5%      �� $��Uniform=�6?   $	��100��6Q   $	��100��6]   ��6$   �� *	Picture+6]   5&      5(      5*      5+      5,      