   M S B A M L   `   `   `  ����C  ?Triggers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:TriggersTriggers  5   	       Triggers.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Triggers     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �� $��Center=�6   $��Center=�6.   .+�5
   
   �� -   5         ��Name$ chkbx��5
      $��	Check Me!��6"   �� 5   
   $��Hover Mouse��6   $��10,10,668.333,360q�6'   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value
 ��  �6B    �� Triggers 5      P� 5       P� Property �@J�IsMouseOver P� Value . . �5      ��  � ��
 �  ��6I   5      �� 5       �� Binding 6&   �� 	 �� ElementName$	 chkbx��
 �� Path$
 	IsChecked� �� Value True6]   .a�5      ��  � ��
 �   �6K   5      5      5      5      5      