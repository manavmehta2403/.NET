   M S B A M L   `   `   `  ����F  BLoginModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:LoginModule.KeyboardLoginModule.Keyboard  5      )    #CardAccess.Mapping.Module.LoginView   5      \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    8x,http://schemas.microsoft.com/winfx/2006/xaml    5      .k"clr-namespace:LoginModule.Keyboard    5        � Title$   ��5   
   $	��250��6   $	��350��6     � ShowInTaskbar .  � Topmost .   � WindowStyle$ SingleBorderWindow=�6Q    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ 	CanResize=�6.    � 	Resources 5      ��%    5      .��5      ��  �� Orientation$ Vertical=�6   .+�5   
   �� $&�� Enter UserName A and Password A ��6   $��Tahoma)�6?   $��15(�6S   $
��Bold"�6a   $��Right=�6s   �� 5   
   $ 
Horizontal=�6   .+�5      �� $ Vertical=�6   .+�5      �� -   5         ��Name$ lblUserName��5      $��	User Name��6+   $��Tahoma)�6?   $��15(�6S   $
��Bold"�6a   $��Right=�6s   �� 5      -   5        $ lblPassword��5      $
��0,27q�6.   $��Password��6=   $��Tahoma)�6P   $��15(�6d   $
��Bold"�6r   $��Right=�6�   6�   5      �� 5      $ Vertical=�6   .+�5      �� -   5        	 ��Name$	 txtUserName��5   f   .   (LoginModule.Keyboard.TouchScreenKeyboard
   TouchScreenKeyboard
 . $	��0,5q�6K   $��20(�6X   $��40��6}   $	��230��6�   $��1��6�   G� 5      -   5         G�Name$ txtPassword��5   j   
 . $��20(�6O   $	��0,5q�6]   $��40��6�   $	��230��6�   $��2��6�   5      5      �� 5'      $ 
Horizontal=�6   .+�5)      �� -   5         ��Name$ btnLogin��5)      $��95,0,0,0q�6-   $��90��6?    �� 	IsDefault . $��50��6]   $��Login��6i   $��3��6y   �� 5*      -   5        $ 	btnCancel��5*      $��Cancel��6(   $��90��69   $��50��6F   $��4��6R   5+      5-      5.      