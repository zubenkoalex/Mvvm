   M S B A M L   `   `   `  ����B  >Duvalin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Duvalin.ViewsDuvalin.Views  5   	   7 clr-namespace:Duvalin.ViewModelsDuvalin.ViewModels  5   	       Duvalin.Views.Login   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Duvalin.Views     5   	   /vm clr-namespace:Duvalin.ViewModels     5   	     � Title$  Login��5	   	   $	��450��6   $	��800��6$   ��5
      �� 5   
    �� ImageSource$F @/Views/MV5BMTcyMzk4NTI0N15BMl5BanBnXkFtZTgwODA3MTcxOTE@._V1_.jpg��6    � DataContext 5      '   !Duvalin.ViewModels.LoginViewModel  5   
   .��5      � $��	50,50,0,0q�6   ��5   
   �� 5       � ColumnDefinitions 5   
   �� 5      $��50 �6   �� 5      $	��270 �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   .+�5"   
   �� $<��6ДОБРО ПОЖАЛОВАТЬ в ЧертолетNSK��6   $��1��6:   $��Bahnschrift Condensed)�6J   $��20(�6m   
�������$	��253��6�   $��	10,-7,0,0q�6�   $	��Top=�6�   �� 5#   
   $��
Логин��6   $��1��6!   $��0��6.   
�������6>   �� 5$   
   $��Пароль��6   $��2��6"   $��0��6/   
�������6?   �� 5&   
   $��1��6+   $��1��68   $	��250��6H   $
��Left=�6U   ��6   �� *Login+6U   �� 5'   
   $��2��6.   $��1��6;   $	��250��6K   $
��Left=�6X   ��6   �� *
Password+6X   �� 5)   
   $��
Войти��6   $��3��6!   $��1��6.   $��Center=�6_   
���  ����6>   �� *LoginCommand+6�   5*      5+      