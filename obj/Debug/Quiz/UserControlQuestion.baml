   M S B A M L   `   `   `  ����H  DPZ_generatory, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:PZ_generatory.QuizPZ_generatory.Quiz  5      ,    &PZ_generatory.Quiz.UserControlQuestion   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:PZ_generatory.Quiz     5      $	��880��5      $	��450��5	      $
��auto��6   
�������.��5      � -   5          �Name$  MainPage��5      $��Center=�6   $	��880��6:   .+�5   
   ��  �� Orientation$ Vertical=�6   .+�5      � -   5        $  	TimerGrid��5   /   $��Right=�6   $��80��6B   $��80��6M   $��	0,10,10,0q�6Y   5      5      �� 5   
   $��Center=�6   $��Center=�65   $��100,30,100,249q�6W   $��25(�6o   ���	#FF224BB6$	��500��6�   .��5      �� -   5         ��Name$ QuestionContent��5       �� TextAlignment$
 Left=�61   $
��Wrap=�6F   5      5      � 5   
   $��50,180,50,25q�6    � RowDefinitions 5      �� 5      $
��173* �6    �� 5      $
��172* �6     � ColumnDefinitions 5      �� 5      �� 5      .+�5"      �� -   5         ��Name$ ButtonAnswear_0��5"      $��40,10q�6.   $��80��6>   $��0��6J   $��0��6Z   .��5#      �� -   5        $ 	question1��5#      $
��Wrap=�6/   5$      5%      �� 5&      -   5        $ ButtonAnswear_1��5&      $��40,10q�6.   $��80��6>   $��0��6J   $��1��6Z   .��5'      �� -   5        $ 	question2��5'      $
��Wrap=�6/   $ Center=�6C   5(      5)      �� 5*      -   5        $ ButtonAnswear_2��5*      $��40,10q�6.   $��80��6>   $��1��6J   $��0��6Z   .��5+      �� -	   5        $ 	question3��5+      $
��Wrap=�6/   $ Center=�6C   5-      5.      �� 5/      -
   5        $ ButtonAnswear_3��5/      $��40,10q�6.   $��80��6>   $��1��6J   $��1��6Z   .��50      �� -   5        $ 	question4��50      $
��Wrap=�6/   $ Center=�6C   52      53      54      56      57      