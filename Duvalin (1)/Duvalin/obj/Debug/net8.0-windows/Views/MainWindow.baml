   M S B A M L   `   `   `  ����B  >Duvalin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Duvalin.ViewsDuvalin.Views  5   	   7 clr-namespace:Duvalin.ViewModelsDuvalin.ViewModels  5   	       Duvalin.Views.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Duvalin.Views     5   	   /vm clr-namespace:Duvalin.ViewModels     5   	   -   5        $
��root��5	   	     � Title$  
MainWindow��5
   	   $	��450��6   $
��1303��6)   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��50 �6   �� 5      $
��0.1* �6   .+�5   
   �� $��2��6   ��6    �� *CarsId+&   System.Windows.Controls.DataGrid  5D   
      AutoGenerateColumns$ False��60      
IsReadOnly$
 True��6L   $��0��6^   ��6   �� *Cars+   Columns 5E      0  *System.Windows.Controls.DataGridTextColumn  5F      ,  &System.Windows.Controls.DataGridColumn   Header$ Автомобиль_ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *Id+6S     5G      $ 
Марка��6%   $
 auto 6M    64   �� *Mark+6M     5H      $ Модель��6%   $
 auto 6O    65   �� *Model+6O   5J      �� 5K   
   $��1��6   $��Right=�6   $��Добавить��6Y   $	��Top=�6l   ��6:   �� *
AddCommand+6l   5M      5N      