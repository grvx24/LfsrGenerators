   M S B A M L   `   `   `  ����H  DPZ_generatory, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:PZ_generatory.Generators.Geffego PZ_generatory.Generators.Geffego  5      7    1PZ_generatory.Generators.Geffego.Settings_geffego   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:PZ_generatory.Generators.Geffego     5      V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $
��Auto��5	      $
��Auto��6   
�������.��5
      � -   5          �Name$  Settings��5
      .+�5   
   � $��
30,20,20,0q�6   .+�5      �� $��35(�6   ���	#FF224BB6$��Center=�69   .��6_   Ustawienia generator Geffego5      �� 5      .+�5      � .+�5      �� -   5        $
��Left��5   !   $	��280��6-   .+�5      �� $-��'Ustaw wartości początkowe rejestrów:��6    ���	#FF224BB6$
��Left=�6f   $��0,70,0,0q�6�   $	��Top=�6�   $
��auto��6�   �� 5       �� Orientation$ 
Horizontal=�6%   .+�5      �� ���	#FF224BB6.��6<   Liczba bitów rejestru6S   �� 5      -   5        $��RegisterLength_ComboBox��5   '    � ToolTip$* $Nadmiarowe bity zostaną pominięte.��6F   $��75��6s   $��10,0,0,0q�6�   6�   5      �� 5      $��LFSR 1: ��6    ���	#FF224BB6$
��Left=�6J   $��0,0,0,0q�6e   $	��Top=�6v   $
��auto��6�   �� 5      $ 
Horizontal=�6%   .+�5      �� -   5         ��Name$ lfsr1��5   &   $4 .Liczba z zakresu od 0 do 4 294 967 295 (uint).��65   $��18(�6n   $
��Left=�6|   $��25��6�   $��25��6�   $
��auto��6�    �� TextAlignment$ Center=�6�   $��6,0,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   �� 5      -   5        $��20��5   %   $��20��60   $��1,0,0,0q�6Q   
������ 
������ .��5   "   '  !MaterialDesignThemes.Wpf.PackIcon  $	��-16q�6:   ���	#FF224BB6�  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]   Kind$ CloseCircle=�6^   $��20��6q   $��20��6|   $��Center=�6�   5      5      �� 5      $��LFSR 2: ��6    ���	#FF224BB6$
��Left=�6J   $��0,0,0,0q�6e   $	��Top=�6v   $
��auto��6�   �� 5      $ 
Horizontal=�6%   .+�5       �� -   5        $ lfsr2��5    &   $4 .Liczba z zakresu od 0 do 4 294 967 295 (uint).��65   $��18(�6o   $
��Left=�6}   $��25��6�   $��25��6�   $
��auto��6�   $ Center=�6�   $��6,0,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   �� 5!      -   5        $��20��5!   %   $��20��60   $��1,0,0,0q�6Q   
������ 
������ .��5"   "     $	��-16q�6:   ���	#FF224BB6$ CloseCircle=�6^   $��20��6q   $��20��6|   $��Center=�6�   5#      5$      �� 5%      $��LFSR 3: ��6    ���	#FF224BB6$
��Left=�6J   $��0,0,0,0q�6e   $	��Top=�6v   $
��auto��6�   �� 5&      $ 
Horizontal=�6%   .+�5'      �� -   5        $ lfsr3��5'   &   $4 .Liczba z zakresu od 0 do 4 294 967 295 (uint).��65   $��18(�6o   $
��Left=�6}   $��25��6�   $��25��6�   $
��auto��6�   $ Center=�6�   $��6,0,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   �� 5(      -	   5        $��20��5(   %   $��20��60   $��1,0,0,0q�6Q   
������ 
������ .��5)   "     $	��-16q�6:   ���	#FF224BB6$ CloseCircle=�6^   $��20��6q   $��20��6|   $��Center=�6�   5*      5+      �� 5-      -
   5         ��Name$ 	Lfsr_list��5-   %   $��Visible=�68   $	��150��6l   �� 5.      $0��*Podaj długość ciągu do wygenerowania: ��6    ���	#FF224BB6$
��Left=�6h   $��0,0,0,0q�6�   $	��Top=�6�   $
��auto��6�   �� 5/      $ 
Horizontal=�6%   .+�50      �� -   5        $ series_length��50   &   $4 .Liczba z zakresu od 0 do 4 294 967 295 (uint).��6=   $��18(�6w   $
��Left=�6�   $��25��6�   $��25��6�   $
��auto��6�   $ Center=�6�   $��6,2,0,0q�6�   $
 Wrap=�6�   $	��Top=�6  �� 51      -   5        $��20��51   %   $��20��60   $��1,0,0,0q�6Y   
������ 
������ .��52   "     $	��-16q�6:   ���	#FF224BB6$ CloseCircle=�6^   $��20��6q   $��20��6|   $��Center=�6�   53      54      57      �� 58      -   5        $��Right��58   !   .+�59      �� $ 
Horizontal=�6%   .+�5:      �� $+��%Wybierz typ ciągu do wygenerowania: ��6$   ���	#FF224BB6$
��Left=�6j   $��	30,90,0,0q�6�   $	��Top=�6�   $
��auto��6�   �� 5;      $��Wyniki testów FIPS-140: ��6$   ���	#FF224BB6$
��Left=�6^   $��	50,90,0,0q�6y   $	��Top=�6�   $
��auto��6�   5<      �� 5>      $ 
Horizontal=�6%   .+�5?      �� -   5         ��Name$	 typ��5?   #   $��35,2,0,0q�60   $
��Left=�6B   $	��Top=�6]   $	��140��6u   $��30��6�   .@�5@      �� -   5        	 ��Name$	 	char_type��5@   +   $��Znaki (char)��6>   
 �� 
IsSelected
 . 6i   �� 5A      -   5        $	 	byte_type��5A   +   $��Szesnastkowo (byte)��6>   6^   �� 5B      -   5        $	 int_type��5B   +   $��Liczby (int)��6=   6V   5C        5D      -   5          Name$ 	SingleBit��5D   6   $ Test pojedynczych bitów.��6I   $��	120,0,0,0q�6l   ���	#FF2196F3$ CloseCircle=�6�   $��20��6�   $��20��6�   $��Center=�6�     5E      -   5        $ Series��5E   6   $ Test serii.��6F   $��20,0,0,0q�6\   ���	#FF2196F3$ CloseCircle=�6�   $��20��6�   $��20��6�   $��Center=�6�     5F      -   5        $ 
LongSeries��5F   6   $ Test długiej serii.��6J   $��20,0,0,0q�6h   ���	#FF2196F3$ CloseCircle=�6�   $��20��6�   $��20��6�   $��Center=�6�     5G      -   5        $ Poker��5G   6   $ Test pokerowy.��6E   $��20,0,0,0q�6^   ���	#FF2196F3$ CloseCircle=�6�   $��20��6�   $��20��6�   $��Center=�6�   5H      �� 5J      $��Wygenerowany ciąg:��6    ���	#FF224BB6$
��Left=�6T   $��30,0,0,0q�6o   $	��Top=�6�   �� 5K      -   5        $ wynik��5K   "   $
��Left=�61   $	��110��6L   $
��auto��6\   $	��200��6j   $��	30,2,30,0q�6z   $
 Wrap=�6�   $	��Top=�6�   $	��400��6�   6�   �� 5L      -   5         ��Name$ 	wynik_txt��5L   !   $��Zapisz (.txt)��64   $
��Left=�6L   $��	30,15,0,0q�6g   $	��Top=�6z   $	��115��6�   $��31��6�   6�   �� 5M      -   5        $ 	wynik_bin��5M   !   $��Zapisz (.bin)��64   $
��Left=�6L   $��160,-31,0,0q�6h   $	��Top=�6~   $	��115��6�   $��31��6�   6�   5N      5O      �� 5P      -   5        $��50��5P      $	��500��6%   $��Center=�61   $��Center=�6U   $
��0,10q�6p   .��5Q      ��  �� TextAlignment$ Center=�6    $��25(�67   $��Generuj ciąg��6E   $
��Wrap=�6Y   5R      5S      5T      5V      5W      