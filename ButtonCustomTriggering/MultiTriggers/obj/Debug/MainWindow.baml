   M S B A M L   `   `   `  ����H  DMultiTriggers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:MultiTriggersMultiTriggers  5   	       MultiTriggers.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:MultiTriggers     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��2* �6   .+�5   
   �� $��Center=�6   .+�5      �� $��Center=�6   $��Center=�61   $��Hover and focus here��6N   $	��150��6j   .��6v   ��5      �� 5       �� 
TargetType" ��6    �� Triggers 5      ]� 5       ]� 
Conditions 5      �� 5   "    �� Property �@J�IsKeyboardFocused �� Value . 6I   �� 5   "    �@J�IsMouseOver . 6C   /�5      �� 5   "    �� Property � �� �� Value
 ����6?   5      5      .��5      5      5       �� 5!   
   $��1��6   $��Center=�6"   $��Center=�6?   .+�5"      �� -   5        $��cbSampleYes��5"      $	��Yes��6*   �� 5#      -   5        $��cbSampleSure��5#      $��I'm sure��6+   �� 5$      $��Center=�6   $��0,20,0,0q�65   $��28(�6G   ��5%      �� 5&      " ��6   .�5'      ��  � ��$ 
Unverified��61   �� 5(       � ��
 �  ��67    5)      ^� 5*      	 ^� 
Conditions	 5+   "   �� 5,   &   
 �� Binding
 60   ��  �� ElementName$ cbSampleYes�� �� Path$ 	IsChecked� True6l   �� 5-   &   
 60   �� $ cbSampleSure��$ 	IsChecked� True6m   .0�5/   "   ��  � ��$ Verified��69   �� 50   "    � ��
 � � �6?   51      53      55      56      57      58      