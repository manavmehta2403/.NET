   M S B A M L   `   `   `  ����  CustomCaret$    CustomCaret.CustomCaretTextBox   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      � .+�5	   
   �� -   5          ��Name$  CustomTextBox��5	      $��Gesta)�5
      $��28(�5       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5       �� 
CaretBrush
 ���� $��0q�5      $��0q�5      �� 5   
   .+�5      �� -   5         ��Name$ Caret��5      $y�	Collapsed=�5       �� Left$ 0��5      
 �� Top$ 0��5      $��5��5      $��30��5      
���  �� � Triggers 5      :� 5       :� RoutedEvent$ Border.Loaded��6#   .[�5      �� .��5      �� -   5        	 ��Name$	 CaretStoryBoard��5   *   
 g� RepeatBehavior$
 Forever��5   *   .��5   "   ��  �� TargetProperty$ Background.Color�5   )    g� Duration$ 0:0:0:1D�5    )    g� FillBehavior$ HoldEnd=�5!   )   g�5#   *   p�  �� KeyTime$ 	0:0:0.750��6@    �� Value$ Transparent��6T   p� 5$   *   $ 	0:0:0.000��6@   $	 red��6T   5&   #   5'      5(      5)      5+      5,      5-      5.      