   M S B A M L   `   `   `  ����H  DbindingDoKlas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:bindingDoKlasbindingDoKlas  5          bindingDoKlas.WidokAlbumu   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -localclr-namespace:bindingDoKlas     5      $	��500��5
      $	��400��5      $��30(�5        � Title  5	      �� *Tytuł+.��5      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� .��6   Tytuł6   �� 5   
   $��1��5      ��5      �� *Tytuł+ �� UpdateSourceTrigger$ PropertyChanged=��� 5!   
   $��1��6   .��6   Autor6$   �� 5"   
   $��1��5#      $��1��5$      ��5%      �� *Autor+$ PropertyChanged=��� 5'   
   $��2��6   .��6   	Wydawca6&   �� 5(   
   $��1��5)      $��2��5*      ��5+      �� *	Wydawca+$ PropertyChanged=��� 5-   
   $��3��6   .��6   	Nośnik6%   �� 5.   
   $��1��5/      $��3��50       �� SelectedItem 51      �� *	Nośnik+$ PropertyChanged=�.@�52      �� .��6   VHS6    �� 53      .��6   DVD6    �� 54      .��6   	BlueRay6$   �� 55      .��6   Kaseta6#   �� 56      .��6   CD6   �� 57      .��6   
Pendrive6%   58      �� 5:   
   $��4��6   .��6   
Długość6&   �� 5;   
   $��1��5<      $��4��5=      ��5>      �� *
Długość+$ PropertyChanged=��� 5@   
   $��5��6   .��6   Data Wydania6+   (  "System.Windows.Controls.DatePicker  5A   
   $��1��5B      $��5��5C         SelectedDate 5D      �� *DataWydania+�� 5E   
   -   5        $��Dodaj��5E      $��Center=�6!   $��0,15,0,0q�6>   $��6��6P   $	��Top=�6]   6u   5F      5G      