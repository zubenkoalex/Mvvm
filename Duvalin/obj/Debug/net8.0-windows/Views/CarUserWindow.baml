   M S B A M L   `   `   `  ����B  >Duvalin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Duvalin.ViewsDuvalin.Views  5   	   7 clr-namespace:Duvalin.ViewModelsDuvalin.ViewModels  5   	   /clr-namespace:Duvalin.ModelsDuvalin.Models  5   	   !    Duvalin.Views.CarUserWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Duvalin.Views     5   	   /vm clr-namespace:Duvalin.ViewModels     5   	   ,vm1clr-namespace:Duvalin.Models     5   	     � Title$  CarUserWindow��5
   	   $	��450��6   $	��800��6,    � DataContext 5      &    Duvalin.ViewModels.MainViewModel  5   
   .��5      � $��0,0,0,6q�6    � RowDefinitions 5   
   �� 5      �� 5      $��0 �6   .+�5   
   &   System.Windows.Controls.DataGrid     AutoGenerateColumns$ False��60      
IsReadOnly$
 True��6L   ��6   �� *Cars+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Автомобиль_ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6W   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *Car.Id+6W     5      $ 
Марка��6%   $
 auto 6Q    64   �� *
Car.Mark+6Q     5      $ Модель��6%   $
 auto 6V    65   �� *Car.ModelCar+6V     5      $ Поколение��6%   $
 auto 6[    68   �� *Car.Generation+6[     5      $ Тип топлива��6%   $
 auto 6^    6:   �� *Pacage.FuelType+6^     5      $# Объем двигателя��6%   $
 auto 6f    6>   �� *Pacage.EngineVolume+6f     5      $) #Мощность двигателя��6%   $
 auto 6h    6A   �� *Pacage.EnginePower+6h     5      $ Тип КПП��6%   $
 auto 6Y    66   �� *Pacage.KPPType+6Y     5      $ Тип привода��6%   $
 auto 6_    6:   �� *Pacage.DriveType+6_     5      $ Тип кузова��6%   $
 auto 6]    69   �� *Pacage.CallType+6]     5       $ Цвет кузова��6%   $
 auto 6_    6:   �� *Pacage.CallColor+6_     5!      $ Руль��6%   $
 auto 6U    63   �� *Pacage.Rudder+6U     5"      $/ )Название комплектации��6%   $
 auto 6j    6D   �� *Pacage.NamePacage+6j     5#      $ Пробег��6%   $
 auto 6U    65   �� *Car.Mileage+6U     5$      $ Цена��6%   $
 auto 6Q    63   �� *	Car.Price+6Q     5%      $ Год выпуска��6%   $
 auto 6^    6:   �� *Car.ReleaseYear+6^   4  .System.Windows.Controls.DataGridTemplateColumn  5&      $ Картинка��6)   	   CellTemplate	 5'      �� 5(      .R�5)      �� $��Uniform=�6C   $	��100��6U   $	��100��6a   ��6$   �� *Car.Picture+6a   5*      5,      5.      5/      50      