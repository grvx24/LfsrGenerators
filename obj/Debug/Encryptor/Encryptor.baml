   M S B A M L   `   `   `  ����H  DPZ_generatory, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:PZ_generatoryPZ_generatory  5          PZ_generatory.Encryptor   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      'localclr-namespace:PZ_generatory  5      $
��Auto��5	      $
��Auto��6   
�������  � 	Resources  5
      '  !MaterialDesignThemes.Wpf.PackIcon   	ArrowLeft�  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]   Kind��%T   &	          5   
   $ 	ArrowLeft=�64   
�������$��40��6X   $��40��6c   5      .��5      � -   5         �Name$ Encrypt��5      .+�5   
   � $��
20,20,20,0q�6   .+�5      �� $��35(�6   ���	#FF224BB6$��Center=�69   .��6_   Szyfrator strumieniowy5      5      �� 5   
   .+�5      � .+�5      �� -   5        $
��Left��5      .+�5      �� $��Ciąg pseudolosowy ��6   ���	#FF224BB6$
��Left=�6P   $��	30,90,0,0q�6k   $	��Top=�6~   $	��188��6�   � 5      .+�5      �� -   5         ��Name$ wczytaj_ciag��5   !   $��Wczytaj��67   $
��Left=�6I   $��38,2,0,0q�6d   $	��Top=�6v   $	��101��6�   $��39��6�   6�   �� 5      $��10,0,0,0q�6%   .+�5      �� -   5         ��Name$	 txt��5   '   ���	#FF224BB6$��z pliku tekstowego (.txt)��6K   $
��Left=�6o   $��0,1,0,0q�6�   $	��Top=�6�   6�   �� 5      -   5        $	 bin��5   '   ���	#FF224BB6$��z pliku binarnego (.bin)��6K   $
��Left=�6n   $��0,5,0,0q�6�   $	��Top=�6�   6�   5      5      �� 5      $��Tekst do zaszyfrowania��6   ���	#FF224BB6$
��Left=�6T   $��	30,20,0,0q�6o   $	��Top=�6�   $	��173��6�   �� 5       -   5         ��Name$ tekst��5       $
��Left=�6-   $	��215��6H   $
��auto��6X   $��30,2,0,0q�6f    �� TextWrapping$
 Wrap=�6x   $	��Top=�6�   $	��380��6�   �� 5!      -   5        $ wczytaj_tekst��5!      $��Wczytaj��64   $
��Left=�6F   $��	30,15,0,0q�6a   $	��Top=�6t   $��97��6�   $��31��6�   6�   �� 5"      -   5        $ zapisz_tekst��5"      $��Zapisz��63   $
��Left=�6D   $��142,-31,0,0q�6_   $	��Top=�6t   $��97��6�   $��31��6�   6�   5#      �� 5%      -	   5        $��Right��5%      .+�5&      �� $��Wygenerowany szyfrogram:��6   ���	#FF224BB6$
��Left=�6V   $��	30,90,0,0q�6q   $	��Top=�6�   �� 5'      -
   5        $ wynik��5'      $
��Left=�6-   $	��110��6H   $
��auto��6X   $	��270��6f   $��	30,2,30,0q�6v   $
 Wrap=�6�   $	��Top=�6�   $	��380��6�   �� 5(      -   5        $ 	wynik_txt��5(      $��Zapisz (.txt)��60   $
��Left=�6H   $��	30,15,0,0q�6c   $	��Top=�6v   $	��115��6�   $��31��6�   6�   �� 5)      -   5        $ 	wynik_bin��5)      $��Zapisz (.bin)��60   $
��Left=�6H   $��160,-31,0,0q�6d   $	��Top=�6z   $	��115��6�   $��31��6�   6�   5*      5+      � 5,      $
��0,20q�6   .+�5-      �� $
��Left=�6   $
��50,0q�68   .+�5.      �� -   5        $  buttonBackToCAtegoryChoice��5.      $��50��6A   $��Center=�6c   .��5/      C�  C� ResourceKey$ 	ArrowLeft��6*   50      51      �� 52      $��Center=�6   $
��50,0q�6:   .+�53      �� -   5        $��50��53      $	��500��6)   $��Center=�65   $��Center=�6Y   .��54      ��  �� TextAlignment$ Center=�6$   $��25(�6;   $��Szyfruj��6I   $
��Wrap=�6X   55      56      57      5:      5;      5<      