   M S B A M L   `   `   `  ����J  FMovementEllipse, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MovementEllipseMovementEllipse  5   	        MovementEllipse.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:MovementEllipse     5   	     � Title$  	SliderBar��5   	    � Topmost .   � WindowStartupLocation$ Manual=�6+   
 � Top$ 40��6J    � Left$ 80��6S   $	��490��6]   $	��470��6j   .��5	      �  � ColumnDefinitions 5   
   �� 5      $��10 �6   �� 5      $��40 �6   �� 5      �� 5      $��10 �6    � RowDefinitions 5   
   �� 5      $��5 �6   �� 5      �� 5      $��40 �6   �� 5      $��5 �6   .+�5   
   �� $��4q�6   
���   �$��2��69   $��1��6I   �� 5   
   -   5        $��xSlider��5      $��1��6    $��1��60   $��5q�6=    �� Orientation$ Vertical=�6H    � Minimum$ 0Q�6�   	 � Maximum$		 300Q�6�   
 � Value
 6_   �� *Y+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�6�   �� 5   
   -   5        $��ySlider��5      $��2��6    $��2��60   $��5q�6=   $ 0Q�6�   $		 300Q�6�   
 6H   �� *X+$ PropertyChanged=�$ TwoWay=�6�   5      5      