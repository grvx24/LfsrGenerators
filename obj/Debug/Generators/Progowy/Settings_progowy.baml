   M S B A M L   `   `   `  ����H  DPZ_generatory, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:PZ_generatory.Generators.Progowy PZ_generatory.Generators.Progowy  5      7    1PZ_generatory.Generators.Progowy.Settings_progowy   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      :local.clr-namespace:PZ_generatory.Generators.Progowy  5      $
��Auto��5	      $
��Auto��6   
�������.��5
      � -   5          �Name$  Settings��5
      .+�5   
   � $��
30,20,20,0q�6   .+�5      �� $��35(�6   ���	#FF224BB6$��Center=�69   .��6_   Ustawienia generator progowy5      �� 5      .+�5      � .+�5      �� -   5        $
��Left��5   !   $	��280��6-   .+�5      �� $%��Podaj liczbę rejestrów LFSR: ��6    ���	#FF224BB6$
��Left=�6_   $��0,70,0,0q�6z   $	��Top=�6�   $	��188��6�   �� 5       �� Orientation$ 
Horizontal=�6%   .+�5      �� -   5         ��Name$ lfsr_amount��5   &    � ToolTip$@ :Nieparzysta liczba z zakresu od 0 do 4 294 967 295 (uint).��6<   $��18(�6�   $
��Left=�6�   $��25��6�   $��40��6�   $
��auto��6�    �� TextAlignment$ Center=�6�   $��5,0,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6  �� 5      -   5         ��Name$ OK��5   %   $��OK��61   $
��Left=�6>   $��5,0,0,0q�6Y   $	��Top=�6j   $��50��6�   $��25��6�   6�   5      �� 5      $.��(Ustaw wartości początkowe rejestrów: ��6    ���	#FF224BB6$
��Left=�6g   $��0,10,0,0q�6�   $	��Top=�6�   $
��auto��6�   �� 5      $ 
Horizontal=�6%   .+�5      �� ���	#FF224BB6.��6;   Liczba bitów rejestru6R   �� 5      -   5        $��RegisterLength_ComboBox��5   '   $* $Nadmiarowe bity zostaną pominięte.��6F   $��75��6s   $��10,0,0,0q�6�   6�   5      �� 5      ��. $��Visible=�6?   .��5      �� -   5         ��Name$ 	Lfsr_list��5   )   $��Visible=�6<   $	��150��6p   5      5      �� 5       $0��*Podaj długość ciągu do wygenerowania: ��6    ���	#FF224BB6$
��Left=�6h   $��0,0,0,0q�6�   $	��Top=�6�   $
��auto��6�   �� 5!      $ 
Horizontal=�6%   .+�5"      �� -   5        $ series_length��5"   &   $4 .Liczba z zakresu od 0 do 4 294 967 295 (uint).��6=   $��18(�6w   $
��Left=�6�   $��25��6�   $��25��6�   $
��auto��6�   $ Center=�6�   $��5,2,0,0q�6�   $
 Wrap=�6�   $	��Top=�6  �� 5#      -   5        $��20��5#   %   $��20��60   $��1,0,0,0q�6Y   
������ 
������ .��5$   "   '  !MaterialDesignThemes.Wpf.PackIcon  $	��-16q�6:   ���	#FF224BB6�  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]   Kind$ CloseCircle=�6^   $��20��6q   $��20��6|   $��Center=�6�   5%      5&      5'      �� 5(      -	   5        $��Right��5(   !   .+�5)      �� $ 
Horizontal=�6%   .+�5*      �� $+��%Wybierz typ ciągu do wygenerowania: ��6$   ���	#FF224BB6$
��Left=�6j   $��	30,90,0,0q�6�   $	��Top=�6�   $
��auto��6�   �� 5+      $��Wyniki testów FIPS-140: ��6$   ���	#FF224BB6$
��Left=�6^   $��	50,90,0,0q�6y   $	��Top=�6�   $
��auto��6�   5,      �� 5.      $ 
Horizontal=�6%   .+�5/      �� -
   5        	 ��Name$		 typ��5/   '   $��35,2,0,0q�64   $
��Left=�6F   $	��Top=�6a   $	��140��6y   $��30��6�   .@�50   "   �� $��Znaki (char)��6/   
 �� 
IsSelected
 . 6Z   �� 51   "   $��Szesnastkowo (byte)��6/   6O   �� 52   "   $��Liczby (int)��6/   6H   53        54      -   5          Name$ 	SingleBit��54   6   $ Test pojedynczych bitów.��6I   $��	120,0,0,0q�6l   
���  ��$ CloseCircle=�6�   $��20��6�   $��20��6�   $��Center=�6�     55      -   5        $ Series��55   6   $ Test serii.��6F   $��20,0,0,0q�6\   
���  ��$ CloseCircle=�6   $��20��6�   $��20��6�   $��Center=�6�     56      -   5        $ 
LongSeries��56   6   $ Test długiej serii.��6J   $��20,0,0,0q�6h   
���  ��$ CloseCircle=�6�   $��20��6�   $��20��6�   $��Center=�6�     57      -   5        $ Poker��57   6   $ Test pokerowy.��6E   $��20,0,0,0q�6^   
���  ��$ CloseCircle=�6�   $��20��6�   $��20��6�   $��Center=�6�   58      �� 59      $��Wygenerowany ciąg:��6    ���	#FF224BB6$
��Left=�6T   $��30,0,0,0q�6o   $	��Top=�6�   �� 5:      -   5        $ wynik��5:   "   $
��Left=�61   $	��110��6L   $
��auto��6\   $	��200��6j   $��	30,2,30,0q�6z   $
 Wrap=�6�   $	��Top=�6�   $	��400��6�   �� 5;      -   5        $ 	wynik_txt��5;   !   $��Zapisz (.txt)��64   $
��Left=�6L   $��	30,15,0,0q�6g   $	��Top=�6z   $	��115��6�   $��31��6�   6�   �� 5<      -   5        $ 	wynik_bin��5<   !   $��Zapisz (.bin)��64   $
��Left=�6L   $��160,-31,0,0q�6h   $	��Top=�6~   $	��115��6�   $��31��6�   6�   5=      5>      �� 5?      -   5        $ Generuj��5?      {�.  $��50��6<   $	��500��6H   $��Center=�6T   $��Center=�6x   $
��0,10q�6�   .��5@      ��  �� TextAlignment$ Center=�6    $��25(�67   $��Generuj ciąg��6E   $
��Wrap=�6Y   5A      5B      5C      5D      5E      