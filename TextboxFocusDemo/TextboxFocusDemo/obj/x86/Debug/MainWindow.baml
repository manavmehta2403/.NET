   M S B A M L   `   `   `  ����  TextboxFocusDemo!    TextboxFocusDemo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ MainSkin.xaml?�6%   %    5
      .��5      �    
LayoutRoot#��[  6
    � RowDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $��0��6   $��Center=�6!   $��Center=�6>   $&�� Enter your passcode to continue.��6Y   �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $��Center=�6X   .+�5      �� -   5        $��
CodeDigit1��5   9     	CodeDigit#��[ 6   69   �� 5      -   5        $��
CodeDigit2��5   9   #��[ 6   69   �� 5      -   5        $��
CodeDigit3��5   9   #��[ 6   69   �� 5      -   5        $��
CodeDigit4��5   9   #��[ 6   $��	0,12,0,12q�6K   5      �� 5   
   -   5        $��ConnectButton��5      $��2��6&   $��Center=�63   $��Center=�6P   $��20,10,20,10q�6k   $��Connect��6�   5      5      