   M S B A M L   `   `   `  ����c  _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  5   	   J FMovementEllipse, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:MovementEllipse.ViewMovementEllipse.View 5   	   (   "MovementEllipse.View.GraphicObject   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5   	   4local"clr-namespace:MovementEllipse.View     5   	     � Title$  GraphicObject��5	   	    � WindowStyle$
 None=�6    � WindowStartupLocation$ Manual=�62   
 � Top$ 80��6Q    � Left$	 135��6Z    � Topmost . $	��400��6t   $	��400��6�   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��5 �6   �� 5      �� 5      $��5 �6    � RowDefinitions 5   
   �� 5      $��5 �6   �� 5      �� 5      $��5 �6   .+�5   
   �� $��5q�6   
�������
�������$
��Left=�5      $	��Top=�6,   $	��330��6D   $	��330��6P   $��1��6]   $��1��6m   $��	22,10,0,0q�6z   ._�5      �� -   5         ��Name$ 
MoveCanvas��5      $��1��6)   $��1��69   .+�5      A� -   5        	 A�Name$	 
ElipseMove��5      $��20��6.   $��20��69   
���  ��
 �� Left
 5      �� *Left+ �� UpdateSourceTrigger$ PropertyChanged=�
 �� Top 5      �� *Top+$ PropertyChanged=�.   (System.Windows.Interactivity.Interaction   Triggers 5      /   )System.Windows.Interactivity.EventTrigger  5         	EventName$ 	MouseMove��6)   .   (System.Windows.Interactivity.TriggerBase   Actions. 5       6   0System.Windows.Interactivity.InvokeCommandAction     Command 64   �� *EllipseMove+5!      5#      5$      5%      5&      5'      