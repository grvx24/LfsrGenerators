   M S B A M L   `   `   `  ����H  DPZ_generatory, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:PZ_generatoryPZ_generatory  5   	       PZ_generatory.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:PZ_generatory     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          � Title$  	Generatix��5	   	   $	��600��6   $
��1080��6(    � 
ResizeMode$ NoResize=�65    � WindowStartupLocation$ CenterScreen=�6K    � ShowInTaskbar . 
������ 
������� � Icon$ Images/logo1.jpg��5
   5    � AllowsTransparency .  � WindowStyle$
 None=�6g    � 	Resources 5         	MenuClose �� TargetProperty	 �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame
 O� KeyTime O� Value  MenuOpen��%  &	        &	 z    �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $	 GridMenu��5   ,   .\�5        $
 0��6'   $	 200Q�63     5      $
 0:0:0.5��6'   $ 60Q�69   5      U� 5      $ (FrameworkElement.Width)�6,   $	 WrapMain��5   ,   .\�5        $
 0��6'   $	 880Q�63     5      $
 0:0:0.5��6'   $
 1020Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $	 GridMenu��5   ,   .\�5        $
 0��6'   $ 60Q�63     5      $
 0:0:0.5��6'   $	 200Q�69   5       U� 5!      $ (FrameworkElement.Width)�6,   $	 WrapMain��5"   ,   .\�5#        $
 0��6'   $
 1020Q�63     5$      $
 0:0:0.5��6'   $	 880Q�69   5%      5&      5'       � Triggers 5)      :� 5*   
    :� RoutedEvent$ ButtonBase.Click��6    :� 
SourceName$ ButtonCloseMenu��66   .[�5+      �� #��[  6   5,      :� 5-   
   $ ButtonBase.Click��6   $ ButtonOpenMenu��66   .[�5.      �� #��[ 6   5/      .��54      � 
�������.+�55   
   �� -   5         ��Name$ WrapMain��55      $��Right=�6'   $��Bottom=�6C   $	��547��56      $	��880��6   57      � 59   
   $��53��6   $	��Top=�6   ���	#FF224BB6.+�5:      �� $��0 2 0 2q�6   
�������._�5;      �� $��Center=�6    �� Orientation$ 
Horizontal=�68   $��Right=�5<      .+�5=      '  !MaterialDesignThemes.Wpf.PopupBox  $��10q�6/      PlacementMode$ BottomAndAlignRightEdges=�6;      	StaysOpen .     PopupContent. 5?      �� $	��160��6%   .+�5@      �� -   5         ��Name$ ButtonAbout��5@   %   .��5A   "   �� $ 
Horizontal=�6-   .+�5B   &   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]   Kind$ 
HelpCircle=�6>   $��20��6P   $��20��6[   $��Center=�6g   �� 5C   &   $��O programie��60   $��Center=�6C   $��10,0,0,0q�6^   5D   #   5E      �� 5F      -   5        $ ButtonAuthors��5F   %   .��5G   "   �� $ 
Horizontal=�6-   .+�5H   &     $	 Cow=�6?   $��20��6J   $��20��6U   $��Center=�6a   �� 5I   &   $��Autorzy��60   $��Center=�6?   $��10,0,0,0q�6Z   5J   #   5K      �� 5L      �� 5M      -   5        $ ButtonAdminPanel��5M   %   .��5N   "   �� $ 
Horizontal=�6-   .+�5O   &     $ Account=�6?   $��20��6N   $��20��6Y   $��Center=�6e   �� 5P   &   $��Panel Admina��60   $��Center=�6D   $��10,0,0,0q�6_   5Q   #   5R      5T      5U      �� 5V      -   5        $ ButtonLogout��5V      $��10q�6N   .��5W      �� $ 
Horizontal=�6%   .+�5X        $ Power=�67   $��20��6D   $��20��6O   $��Center=�6[   5Y      5Z      5[      5\      �� 5]      $'��!Generatory. Aplikacja edukacyjna.��6   $��Center=�6A   $��Center=�6^   $��22(�6y   5^      � 5`   
   -   5         �Name$ GridMenu��5`      $	��200��6!   $
��Left=�6-   ���	#FF224BB6$��0,53,0,0q�6_   .+�5a      �� .+�5b      � $��59��6   ���	#FF224BB6.+�5c      �� -   5        $ ButtonCloseMenu��5c      $��54��67   $��60��6C   $��0,0,5,0q�6N   $��Right=�5d      $	��Top=�5e       0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 5f      
���������5g      Z� ��5h      Z� .��5l        $ 	ArrowLeft=�62   $��25��6C   $��25��6N   5n      �� 5o      -	   5        $ ButtonOpenMenu��5o      $y�	Collapsed=�65   $��60��6L   $��60��6X   $��Right=�5p      $	��Top=�5q      #��[ 5r      
���������5s      Z� ��5t      Z� .��5x        $
 Menu=�62   $��25��6>   $��25��6I   5z      5{      �� 5|      -
   5         ��Name$ ListViewMenu��5|      $��Disabled=�61   
�������.@�5~      �� -   5         ��Name$ ItemStronaGłówna��5~   #   $��60��6=    �� 
IsSelected . .��5      �� $ 
Horizontal=�6%   .+�5�        $
 Home=�67   $��10q�6C   $��25��6O   $��25��6Z   $��Center=�5�   7   �� 5�      $��STRONA GŁÓWNA��6(   $
��Bold"�6=   $��Center=�6O   $��20 10q�5�   (   5�      5�      �� 5�      -   5        $ ItemGeneratory��5�   #   $��60��6<   .��5�      �� $ 
Horizontal=�6%   .+�5�        $	 Key=�67   $��10q�6C   $��25��6O   $��25��6Z   $��Center=�6f   �� 5�      $��
GENERATORY��6(   $
��Bold"�6:   $��Center=�6L   $��20 10q�6g   5�      5�      �� 5�      -   5        $ ItemSzyfrator��5�   #   $��60��6:   .��5�      �� $ 
Horizontal=�6%   .+�5�        $ 	LockReset=�67   $��10q�6I   $��25��6U   $��25��6`   $��Center=�6l   �� 5�      $��	SZYFRATOR��6(   $
��Bold"�69   $��Center=�6K   $��20 10q�6f   5�      5�      �� 5�      -   5        $ 	ItemTesty��5�   #   $��60��66   .��5�      �� $ 
Horizontal=�6%   .+�5�        $ 	ChartLine=�67   $��10q�6I   $��25��6U   $��25��6`   $��Center=�6l   �� 5�      $��TESTY��6(   $
��Bold"�65   $��Center=�6G   $��20 10q�6b   5�      5�      �� 5�      -   5        $ ItemQuizTematyczny��5�   #   $��60��6?   .��5�      �� $ 
Horizontal=�6%   .+�5�        $ GoogleController=�67   $��10q�6O   $��25��6[   $��25��6f   $��Center=�6r   �� 5�      $��QUIZ TEMATYCZNY��6(   $
��Bold"�6?   $��Center=�6Q   $��20 10q�6l   5�      5�      5�      5�      5�      5�      5�      