   M S B A M L   `   `   `  ����H  DPZ_generatory, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:PZ_generatoryPZ_generatory  5      (    "PZ_generatory.FipsTestsUserControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      'localclr-namespace:PZ_generatory  5      $
��Auto��5	      $
��Auto��6   
�������  � 	Resources  5      '  !MaterialDesignThemes.Wpf.PackIcon   	ArrowLeft�  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]   Kind��%T   &	          5   
   $ 	ArrowLeft=�64   
�������$��40��6X   $��40��6c   5      .��5      � $	��585��6   $	��999��6   .+�5   
   �� $��30(�6   $��27,183,580,343q�6   .��66   Wybór formatu wejściowego5      �� 5   
   $
��Bold"�6   $��Center=�6"   $��50(�6?   $��92,29,662,477q�6M   $��
Testy FIPS��6d   �� 5   
   -   5        $��LoadFileButton��5      $��26(�6'   $��27,340,580,168q�65   $
��Auto��6M   .��6x   Wczytaj ciąg5      �� 5   
   -   5        $��FormatTypeComboBox��5      $��Center=�6-   $��Center=�6O    �� SelectedIndex$ 0��6s   $��30(�6�   $��Center=�6�   $��27,242,580,279q�6�   $	��392��6�   .@�5      �� -   5        $��	TxtFormat��5      .��6-   Plik tekstowy5      �� 5      -   5        $��	BinFormat��5      .��6,   Plik binarny5      5!      �� 5"   
   $��	451,0,0,0q�6    �� Orientation$ Vertical=�6(   .+�5#      �� 
�������$ Vertical=�6/   $	��131��6F   .+�5$      �� $
��Bold"�6   $
��Wrap=�6.   $��30(�6B   $��45��6P   $��10,0,0,0q�6\   Test pojedynczych bitów5&      �� 5'      -   5        $��SingletestInfo��5'   4   $��Liczba jedynek: ��6   $
��Wrap=�6J   $��28(�6^   $��41��6l   $��10,0,0,0q�6x   5)      �� 5*      -   5        $��SingleTestResult��5*   +   $��Wynik: ��6   $
��Wrap=�6C   $��28(�6W   $��41��6e   $��10,0,0,0q�6q   5,      5-      �� 5.      $
��Auto=�6   ��. .��5/      �� 
�������$ Vertical=�6/   $	��160��6F   .+�50      �� $
��Bold"�6    $
��Wrap=�62   $��30(�6F   $��
Test serii��6T   $��10,0,0,0q�6f   �� 51      -   5         ��Name$ SeriesOnesText��51       $
��Wrap=�68   $��28(�6L   $��
10,0,180,0q�6Z   �� 6o   $�Seria jedynek: ��6s   �� 6�   $� ��6�   6�   �� 52      -   5        $��SeriesZerosText��52       $
��Wrap=�67   $��28(�6K   $��Seria zer: ��6Y   $��
10,0,180,0q�6l   �� 53      -	   5        $��SeriesResultText��53   !   $
��Wrap=�69   $��28(�6M   $��Wynik: ��6[   $��10,0,0,0q�6j   54      55      �� 57      
�������$ Vertical=�6/   $	��117��6F   .+�58      �� $
��Bold"�6   $
��Wrap=�6.   $��30(�6B   $��Test długiej serii��6P   $��10,0,0,0q�6j   �� 59      -
   5        $��LongSeriesInfoText��59      $
��Wrap=�66   $��28(�6J   $��10,0,0,0q�6X   $��Najdłuższa seria: ��6j   6�   �� 5:      -   5        $��LongSeriesResultText��5:      $
��Wrap=�68   $��28(�6L   $��10,0,0,0q�6Z   $��Wynik: ��6l   6}   5;      �� 5<      
�������$ Vertical=�6+   $	��170��6B   $	��554��6O   $��0,0,-6,0q�6[   .+�5=      �� $
��Bold"�6   $
��Wrap=�6.   $��30(�6B   $��Test pokerowy��6P   $��10,0,0,0q�6e   �� 5>      -   5        $��PokerTestXText��5>      $
��Wrap=�62   $��28(�6F   $��Wartość X: ��6T   $��10,0,0,0q�6g   �� 5?      -   5        $��PokerTestResultText��5?      $
��Wrap=�67   $��28(�6K   $��Wynik: ��6Y   $��10,0,0,0q�6h   5A      5D      5E      5F      