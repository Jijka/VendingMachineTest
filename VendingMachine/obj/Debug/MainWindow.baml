   M S B A M L   `   `   `  ����I  EVendingMachine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:VendingMachine.ConvertersVendingMachine.Converters  5   	   K*clr-namespace:VendingMachine.Models.DrinksVendingMachine.Models.Drinks  5   	   C&clr-namespace:VendingMachine.ViewModelVendingMachine.ViewModel  5	   	       VendingMachine.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >
converters'clr-namespace:VendingMachine.Converters     5   	   =drinks*clr-namespace:VendingMachine.Models.Drinks     5   	   =
viewModel1&clr-namespace:VendingMachine.ViewModel     5	   	   -   5          �Name$  Window��5   	    � Title$ VendingMachine��5   	   $	��432��6    $��795.5��6-    � 	Resources 5      5   /VendingMachine.Converters.GreaterMultiConverter   GreaterMultiConverter��%   &	          5   
   6+   5      .��5      � .+�5   
   �� -   5         ��Name$ CoinsListBox��5       �� DisplayMemberPath$ Rating��5      $
��Left=�5      $	��120��5      
���  ��$	��Top=�5      $	��313��5      $��	10,10,0,0q�5      $��Disabled=�5      ��5      �� *Coins+ �� SelectedItem 5      �� *SelectedCoin+��5      �� 5      .R�5      A�  A� Rows$ 2��6"   5      ��5       �� 5!      .�5"      ��  �� Property � �� �� Value$	 100��66   �� 5#       � ��$ 5q�67   �� 5$       � ��
 �  ��6<   �� 5%       � ��
 � � �6;   	 �� Triggers	 5&      �� 5'      
 �� Binding
 6&   ��  �� Path$ 	IsBlocked� �� Mode$ OneWay=� �� Value True6W   .a�5(      ��  � ��
 �  ��6C   5)      5+      5-      �� 5.   
   -   5         ��Name$ 	AddButton��5.      $��Пополнить��6$   
���  ��$
��Left=�51      $��
334,10,0,0q�6,   $	��Top=�6@   $	��120��6X   $	��120��6d   ��50      �� *AddToBalanceCommand+51   d   �� 52   
   -   5        $ DrinksListBox��52      $
��Left=�55      $	��142��56      $	��Top=�57      $	��444��58      $��
10,250,0,0q�59      $
��Auto=�5:      ��53      �� *Drinks+ 54      �� *SelectedDrink+��5;      �� 5<      .R�5=      A� $ 1��6"   5>      ��5@      �� 5A      .R�5B      �� .+�5C      �� ��6$   �� $ (drinks:Drink.Name)��� 5D      ��6$   �� $ (drinks:Drink.Price)�5E      5F      ��5H      �� 5I      .�5J      ��  � ��$	 100��66   �� 5K       � ��$ 5q�67   �� 5L       � ��
 ��  �6<   �� 5M       � ��
 �����6;   �� 5N       � ��
 �  ��6;   	 5O      �� 5P      
 5Q      `� 5R   "    `� 	Converter# [  6/    `� ConverterParameter$ Drinks��6b   .1�5S   &   �� $  �6.   �� 5T   &    �� ElementName$ Window��6.   $> 8DataContext.(viewModel1:VendingMachineViewModel.Balance)�6C   5U   #    True5W   H   .a�5X      ��  � ��
 � � �6C   5Y      5[      5]      �� 5^   
   -   5         ��Name$ Balance��5^      $
��Left=�5_      $	��Top=�5`      
����  �$	��262��5b      $��45��6   $��
520,10,0,0q�5c       �� TextWrapping$
 Wrap=�6&   ��5d      �� *	Balance+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors .  �� NotifyOnValidationError . .��5e   X   ��5f      �� 5g      .�5h      ��  � ��
 � � �6;   	 5i      �� 5j      
 6&   �� *	Balance+ 06B   .a�5k      ��  � ��
 �  ��6C   5l      5n      .��5o      5p      �� 5q   
   -   5        $ ChangeButton��5q      
����  �$��
Сдача��5r   $   $
��Left=�64   $��
666,60,0,0q�5s      $	��Top=�6%   $	��116��5t      $��43��6   ��5q   '   �� *ChangeCommand+5t      �� 5u   
   -   5        $ BuyCommandButton��5u      $#��Купить (команда)��6+   $
��Left=�5w      $��477,253,0,0q�6,   $	��Top=�5x      $	��142��6)   $	��142��65   ��5v      �� *
BuyCommand+5x   5   �� 5y   
   -   5        $ BuyEventButton��5y      $#��Купить (событие)��5{      $
��Left=�5|      $��636,253,0,0q�6,   $	��Top=�5}      $	��142��6)   $	��142��65   ��5~      �� 5       �� 
TargetType" ��6   .�5�      ��  � {� .  62   	 5�      �� 5�      
 5�      `� 5�   "   # [  6/   $	 Buy��6b   .1�5�   &   �� $8 2(viewModel1:VendingMachineViewModel.SelectedDrink)�6.   �� 5�   &   $2 ,(viewModel1:VendingMachineViewModel.Balance)�6.   5�   #    True5�   H   .a�5�      ��  � {� . 6:   5�      5�      5�      5�      5�      