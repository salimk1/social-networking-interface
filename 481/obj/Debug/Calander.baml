   M S B A M L   `   `   `  ����>  :481, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:_481_481  5          _481.Calander   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $localclr-namespace:_481     5      $	��470��5	      $	��820��6     N� Title$  Calander��5
       N� 
Background �#4D4D4D N� 
Foreground
 �����.��5      � .+�5   
   �� -   5         ��Name$ 	btnExpand��5      $��28��6$   $��82��60   $��>��6;   $
��Left=�6G   $	��Top=�6b   ���#6D6D6D
�������$��15(�5   Q   �� 5   
   -   5         ��Name$ 
ClubsPanel��5      $
��Left=�6)   $	��419��6D   $	��Top=�6Q   $��82��6i   $��0,28,0,0q�6t   $��5��6�   .+�5      �� $��Clubs��6   $��
0,0,39.4,0q�6$   
�������68   �� 5      $	��CBS��6   $��28��6#   $��0,0,0,0q�60   ���#6D6D6D
�������6V   �� 5      -   5        $��InfoSec��5      $��28��6'   $��0,0,0,0q�63   ���#6D6D6D
�������6l   5      �� 5   
   -   5        $��Club Center��5      $
��Left=�6'   $��82,0,0,0q�6B   $	��Top=�6T   $	��185��5      $��28��6   ���#6D6D6D
�������6Q   �� 5   
   -   5        $��Calendar��5      $
��Left=�6$   $��	267,0,0,0q�6?   $	��Top=�6R   $	��185��5      $��28��6   ���#6D6D6D
�������6Q   �� 5   
   -   5        $��Event Finder��5      $
��Left=�6(   $��	452,0,0,0q�6C   $	��Top=�6V   $	��185��5      $��28��6   ���#6D6D6D
�������6Q   �� 5   
   -   5        $��Settings��5      $
��Left=�6$   $��	637,0,0,0q�6?   $	��Top=�6R   $	��185��5      $��28��6   ���#6D6D6D
�������6Q   � 5"   
   -   5         �Name$
 Grid��5"      $��	82,27,0,0q�6   $	��718��61   $	��410��6=   $
��Left=�6J   $	��Top=�6e    � ColumnDefinitions 5#      �� 5$      $��5 �6#   �� 5%      $
��auto �6#   �� 5&      $
��auto �6#   �� 5'      $
��auto �6#   �� 5(      $
��auto �6#   �� 5)      $
��auto �6#   �� 5*      $
��auto �6#   �� 5+      $
��auto �6#   �� 5,      $
��auto �6#   �� 5-      $
��auto �6#   �� 5.      $��5 �6#    � RowDefinitions 50      �� 51      $��5 �6    �� 52      $
��auto �6    �� 53      $
��auto �6    �� 54      $
��auto �6    �� 55      $
��auto �6    �� 56      $
��auto �6    �� 57      $
��auto �6    �� 58      $��3 �6    .+�5<      �� -	   5        $ btnUp��5<      $��1��6$   $��1��64   $��30��6A   $��30��6L   $��	35,8,0,10q�6X   $
��🠕��5=       � Cursor$
 Hand��6"   ���#4D4D4D
�������$��20(�6l   �� 5>      -
   5        $ btnDown��5>      $��2��6&   $��1��66   $��30��6C   $��30��6N   $��	0,8,40,10q�6Z   $
��🠗��5?      $
 Hand��6"   ���#4D4D4D
�������$��20(�6n   �� 5@      -   5        	 ��Name$	 tbMonth��5@      $��2��6)   $��1��69   $��25(�6F   $��2��6T   $��
April 2021��5A      $��40,2,0,0q�6&   $��35��68   
 �� TextAlignment$
 Center=�6D   �� 5D      -   5        $ btnToday��5D      $��7��6'   $��1��67   $��60��6D   $��26��6O   $��0,0,0,0q�6[   $��Today��5E      
����ح�$
 Hand��6S   $
��Bold"�5F      $��15(�6'   �� 5H      -   5         ��Name$ Filters��5H      $��8��6)   $��1��69   $��2��6F   $	��131��6Z   $��26��6f   $��0,0,0,0q�6r    �� 
IsEditable .  �� 
IsReadOnly .  �� Text$ View Options��5I   9   $��15(�6M   $��SemiBold"�6[   $
 Hand��6q   .@�5J      �� .��5K      �� -   5         ��Name$ ShadeMonths��5K       d� 	IsChecked$ FalseY�65   .��6a   Shade Months6o   5L      �� 5M      .��5N      �� -   5        $ ViewRegEvents��5N      $ FalseY�66   .��6d   Hide Joined Events6x   5O      �� 5P      .��5Q      �� -   5        $ ViewNonRegEvents��5Q      $ FalseY�69   .��6j   Hide Non-Joined Events6�   5R      �� 5S      .��5T      �� -   5        $ CollapseEmpty��5T      $ FalseY�66   .��6d   Collapse Empty Weeks6z   5U      5V      �� 5Z      $��1��6   $��2��6(   $��15(�65   $��Sunday��5[      $��0,0,0,0q�6"   $��82��63   $��22��6>   $
 Center=�6J   �� 5\      $��2��6   $��2��6(   $��15(�65   $��Monday��5]      $��0,0,0,0q�6"   $��82��63   $��22��6>   $
 Center=�6J   �� 5^      $��3��6   $��2��6(   $��15(�65   $��Tuesday��5_      $��0,0,0,0q�6#   $��82��64   $��22��6?   $
 Center=�6K   �� 5`      $��4��6   $��2��6(   $��15(�65   $��	Wednesday��5a      $��0,0,0,0q�6%   $��82��66   $��22��6A   $
 Center=�6M   �� 5b      $��5��6   $��2��6(   $��15(�65   $��Thursday��5c      $��0,0,0,0q�6$   $��82��65   $��22��6@   $
 Center=�6L   �� 5d      $��6��6   $��2��6(   $��15(�65   $��Friday��5e      $��0,0,0,0q�6"   $��82��63   $��22��6>   $
 Center=�6J   �� 5f      $��7��6   $��2��6(   $��15(�65   $��Saturday��5g      $��0,0,0,0q�6$   $��82��65   $��22��6@   $
 Center=�6L   �� 5h      $��8��6   $��2��6(   $��15(�65   $��2��6C   $��SemiBold"�6W   $��Event Details��5i      $��0,0,0,0q�6)   $	��136��6:   $��22��6F   $
 Center=�6R   �� 5l      $��1��6   $��3��6)   $��82��66   $��82��6A   .+�5m      �� 
�������$��1q�6,   �� 5n      
�������$��1q�6,   $��0,1,0,0q�6@   $y�Hidden=�6Q   �� 5o      -   5        $	 
tbDateW1D1��5o      $��12(�60   $��April-11��6>   $��5,0,0,0q�6N   �� 5p      -   5        $	 w1d1_Event1��5p      $��9(�61   $'��!2pm CareerLink - How to Get Hired��6>   $��1,3,0,0q�5q      
���  �� � ToolTip$' !2pm CareerLink - How to Get Hired��6>   5s      �� 5t      $��2��6   $��3��6)   $��82��66   $��82��6A   .+�5u      �� 
�������$��1q�6,   �� 5v      
�������$��1q�6,   $��0,1,0,0q�6@   $y�Hidden=�6Q   �� 5w      -   5        $	 
tbDateW1D2��5w      $��12(�60   $��12��6>   $��5,0,0,0q�6H   �� 5x      -   5        $	 w1d2_Event1��5x      $��9(�61   $;��510am Mental Health Session: What We Offer to Help You��5y      $��1,3,0,0q�5z      
���  ��$; 510am Mental Health Session: What We Offer to Help You��5{      �� 5|      -   5        $	 w1d2_Event2��5|      $��9(�61   $,��&12pm Coffee Chat with Industry Experts��5}      $��1,3,0,0q�5~      
���  ��$, &12pm Coffee Chat with Industry Experts��5      5�      �� 5�      $��3��6   $��3��6)   $��82��66   $��82��6A   .+�5�      �� -   5         ��Name$ 	brdW1D3_1��5�      
����  �$��2q�6?   �� 5�      
�������$��1q�6,   $��0,1,0,0q�6@   $y�Hidden=�6Q   �� 5�      -   5        $	 
tbDateW1D3��5�      $��12(�60   $��13��6>   $��5,0,0,0q�6H   �� 5�      -   5        $	 w1d3_Event1��5�      $��9(�61   $��11am CSUS GitHub Event��5�   
   $��1,3,0,0q�6(   
����  �$ 11am CSUS GitHub Event��5�      5�      5�      �� 5�      $��4��6   $��3��6)   $��82��66   $��82��6A   .+�5�      �� 
�������$��1q�6,   �� 5�      
�������$��1q�6,   $��0,1,0,0q�6@   $y�Hidden=�6Q   �� 5�      -   5        $	 
tbDateW1D4��5�      $��13(�60   $��14��6>   $��5,0,0,0q�6H   �� 5�      -   5        $	 tbW1D4_Event1��5�      $��9(�63   $�� ��5�   
   $��1,3,0,0q�6   5�      �� 5�      $��5��6   $��3��6)   $��82��66   $��82��6A   .+�5�      �� 
�������$��1q�6,   �� 5�      
�������$��1q�6,   $��0,1,0,0q�6@   $y�Hidden=�6Q   �� 5�      -   5        $	 
tbDateW1D5��5�      $��12(�60   $��15��6>   $��5,0,0,0q�6H   5�      �� 5�      $��6��6   $��3��6)   $��82��66   $��82��6A   .+�5�      �� 
�������$��1q�6,   �� 5�      
�������$��1q�6,   $��0,1,0,0q�6@   $y�Hidden=�6Q   �� 5�      -   5        $	 
tbDateW1D6��5�      $��12(�60   $��16��6>   $��5,0,0,0q�6H   5�      �� 5�      $��7��6   $��3��6)   $��82��66   $��82��6A   .+�5�      �� 
�������$��1q�6,   �� 5�      
�������$��1q�6,   $��0,1,0,0q�6@   $y�Hidden=�6Q   �� 5�      -   5        $	 
tbDateW1D7��5�      $��12(�60   $��17��6>   $��5,0,0,0q�6H   5�      �� 5�      $��2q�6   
�������$��8��6<   $��3��6L   $��4��6Y   $��2��6j   $��0,0,3,0q�5�      ._�5�      �� -   5        $ EventDetails��5�      $	��130��63   .+�5�      �� -    5        $	 tbEvent1��5�       $��3,3,3,0q�62   $��13(�6C   $
��Wrap=�6Q   $y�Visible=�6e   �� 5�      .�6   Event:6'    CSUS GitHub Event�� 5�      �� 5�      .�6   	Status:6(    Registered�� 5�      �� 5�      .�6   Date:6&    Tue, April 13, 2021 @ 11am�� 5�      �� 5�      .�6   	Location:6*   	 Online�� 5�      �� 5�      .�6   	Duration:6*   	 1 hour�� 5�      �� 5�      .�6   
Details:6)   �� This event will teach you the basics of using GitHub. We will show you how to create a new repository on GitHub and the process of development. Join us today!5�      �� 5�      -!   5        $	 tbEvent2��5�       $��3,3,3,0q�62   $��13(�6C   $
��Wrap=�6Q   $y�	Collapsed=�6e   �� 5�      .�6   Event:6'    Virtual Board Game Cafe�� 5�      �� 5�      .�6   	Status:6(    Not Registered�� 5�      �� 5�      .�6   Date:6&    Sun, May 02, 2021 @ 1pm�� 5�      �� 5�      .�6   	Location:6*   	 Online�� 5�      �� 5�      .�6   	Duration:6*   	 1 hour�� 5�      �� 5�      .�6   
Details:6)   vt Join us for our last coffee of the year and hang out. You will have the chance to take a break and meet new people!5�      �� 5�      -"   5        $	 tbEvent3��5�       $��3,3,3,0q�62   $��13(�6C   $
��Wrap=�6Q   $y�	Collapsed=�6e   �� 5�      .�6   Event:6'    Virtual Board Game Cafe�� 5�      �� 5�      .�6   	Status:6(    Registered�� 5�      �� 5�      .�6   Date:6&    Sun, May 02, 2021 @ 1pm�� 5�      �� 5�      .�6   	Location:6*   	 Online�� 5�      �� 5�      .�6   	Duration:6*   	 1 hour�� 5�      �� 5�      .�6   
Details:6)   vt Join us for our last coffee of the year and hang out. You will have the chance to take a break and meet new people!5�      �� 5�      -#   5        $ btnJoin��5�      $��75��6.   $��25��69   $��45,0,0,0q�6E   $��Joined!��6W   
�������$
 Hand��5�   F   $
��Bold"�6T   5�      5�      �� 5�      $��1��6   $��4��6)   $��82��66   $��82��6A   .+�5�      �� 
�������$��1q�6,   �� 5�      
�������$��1q�6,   $��0,1,0,0q�6@   $y�Hidden=�6Q   �� 5�      -$   5        $	 
tbDateW2D1��5�      $��12(�60   $��18��6>   $��5,0,0,0q�6H   �� 5�      -%   5        $	 w2d1_Event1��5�      $��9(�61   $-��'3pm UCalgaryTogether: Exercise Together��5�   
   $��1,3,0,0q�69   
����  �$- '3pm UCalgaryTogether: Exercise Together��5�      5�      �� 5�      $��2��6   $��4��6)   $��82��66   $��82��6A   .+�5�      �� 
�������$��1q�6,   �� 5�      
�������$��1q�6,   $��0,1,0,0q�6@   $y�Hidden=�6Q   �� 5�      -&   5        $	 
tbDateW2D2��5�      $��12(�60   $��19��6>   $��5,0,0,0q�6H   �� 5�      -'   5        $	 w2d2_Event1��5�      $��9(�61   $,��&11am Information Session: Data Science��5�   
   $��1,3,0,0q�68   
���  ��$, &11am Information Session: Data Science��5�      �� 5�      -(   5        $	 w2d2_Event2��5�      $��9(�61   $�� ��6>   $��1,3,0,0q�5�      
���  ��6-   5�      �� 5�      $��3��6   $��4��6)   $��82��66   $��82��6A   .+�5�      �� -)   5        $ 	brdW2D3_1��5�      
�������$��1q�6?   �� 5�      
�������$��1q�6,   $��0,1,0,0q�6@   $y�Hidden=�6Q   �� 5�      -*   5        $	 
tbDateW2D3��5�      $��12(�60   $��20��6>   $��5,0,0,0q�6H   �� 5�      -+   5        $	 w2d3_Event1��5�      $��10(�61   $�� ��5�   
   $��1,3,0,0q�6   
����  �6#   5�      �� 5�      $��4��6   $��4��6)   $��82��66   $��82��6A   .+�5�      �� 
�������$��1q�6,   �� 5�      
�������$��1q�6,   $��0,1,0,0q�6@   $y�Hidden=�6Q   �� 5�      -,   5        $	 
tbDateW2D4��5�      $��12(�60   $��21��6>   $��5,0,0,0q�6H   �� 5�      --   5        $	 tbW2D4_Event1��5�      $��10(�63   $�� ��5�   
   $��1,3,0,0q�6   
���  ��6$   5�      �� 5�      $��5��6   $��4��6)   $��82��66   $��82��6A   .+�5�      �� 
�������$��1q�6,   �� 5�      
�������$��1q�6,   $��0,1,0,0q�6@   $y�Hidden=�6Q   �� 5�      -.   5        $	 
tbDateW2D5��5�      $��12(�60   $��22��6>   $��5,0,0,0q�6H   5�      �� 5�      $��6��6   $��4��6)   $��82��66   $��82��6A   .+�5�      �� 
�������$��1q�6,   �� 5      
�������$��1q�6,   $��0,1,0,0q�6@   $y�Hidden=�6Q   �� 5     -/   5        $	 
tbDateW2D6��5     $��12(�60   $��23��6>   $��5,0,0,0q�6H   �� 5     -0   5        $	 w2d6_Event1��5     
���  ��$��1,3,0,0q�6B   $��9(�6S   $�� ��5  
   5     �� 5     $��7��6   $��4��6)   $��82��66   $��82��6A   .+�5     �� 
�������$��1q�6,   �� 5     
�������$��1q�6,   $��0,1,0,0q�6@   $y�Hidden=�6Q   �� 5     -1   5        $	 
tbDateW2D7��5     $��12(�60   $��24��6>   $��5,0,0,0q�6H   5	     �� 5     -2   5        $ stpW3D1��5     $��1��6*   $��5��6:   $��82��6G   $��82��6R   .+�5     �� 
�������$��1q�6,   �� 5     -3   5        $ brdW3D1��5     
�������$��1q�6=   $��0,2,0,0q�6Q   $y�Hidden=�6b   �� 5     -4   5        $	 
tbDateW3D1��5     $��12(�60   $��25��6>   $��5,0,0,0q�6H   �� 5     -5   5        $	 w3d1_Event1��5     $��10(�61   $�� ��5  
   $��1,3,0,0q�6   
���  ��$! 1pm Virtual Board Game Cafe��5     5     5     �� 5     -6   5        $ stpW3D2��5     $��2��6*   $��5��6:   $��82��6G   $��82��6R   .+�5     �� 
�������$��1q�6,   �� 5     -7   5        $ brdW3D2��5     
�������$��1q�6=   $��0,2,0,0q�6Q   $y�Hidden=�6b   �� 5     -8   5        $	 
tbDateW3D2��5     $��12(�60   $��26��6>   $��5,0,0,0q�6H   �� 5     -9   5        $	 w3d2_Event1��5     $��10(�61   $�� ��5  
   $��1,3,0,0q�6   
���  ��6$   �� 5     -:   5        $	 w3d2_Event2��5     $��9(�61   $�� ��6>   $��1,3,0,0q�5     
���  ��6-   5     �� 5     -;   5        $ stpW3D3��5     $��3��6*   $��5��6:   $��82��6G   $��82��6R   .+�5     �� -<   5        $ 	brdW3D3_1��5     
�������$��1q�6?   �� 5      -=   5        $ brdW3D3��5      
�������$��1q�6=   $��0,2,0,0q�6Q   $y�Hidden=�6b   �� 5!     ->   5        $	 
tbDateW3D3��5!     $��12(�60   $��27��6>   $��5,0,0,0q�6H   �� 5"     -?   5        $	 w3d3_Event1��5"     $��10(�61   $�� ��5#  
   $��1,3,0,0q�6   
���  ��6#   5$     �� 5%     -@   5        $ stpW3D4��5%     $��4��6*   $��5��6:   $��82��6G   $��82��6R   .+�5&     �� 
�������$��1q�6,   �� 5'     -A   5        $ brdW3D4��5'     
�������$��1q�6=   $��0,2,0,0q�6Q   $y�Hidden=�6b   �� 5(     -B   5        $	 
tbDateW3D4��5(     $��12(�60   $��28��6>   $��5,0,0,0q�6H   �� 5)     -C   5        $	 w3d4_Event1��5)     $��10(�61   $�� ��5*  
   $��1,3,0,0q�6   5+     �� 5,     -D   5        $ stpW3D5��5,     $��5��6*   $��5��6:   $��82��6G   $��82��6R   .+�5-     �� 
�������$��1q�6,   �� 5.     -E   5        $ brdW3D5��5.     
�������$��1q�6=   $��0,2,0,0q�6Q   $y�Hidden=�6b   �� 5/     -F   5        $	 
tbDateW3D5��5/     $��12(�60   $��29��6>   $��5,0,0,0q�6H   50     �� 51     -G   5        $ stpW3D6��51     $��6��6*   $��5��6:   $��82��6G   $��82��6R   .+�52     �� 
�������$��1q�6,   �� 53     -H   5        $ brdW3D6��53     
�������$��1q�6=   $��0,2,0,0q�6Q   $y�Hidden=�6b   �� 54     -I   5        $	 
tbDateW3D6��54     $��12(�60   $��30��6>   $��5,0,0,0q�6H   �� 55     -J   5        $	 w3d6_Event1��55     $��10(�61   $�� ��56  
   $��1,3,0,0q�6   
���  ��6$   57     �� 58     -K   5        $ stpW3D7��58     $��7��6*   $��5��6:   $��82��6G   $��82��6R   .+�59     �� 
�������$��1q�6,   �� 5:     -L   5        $ brdW3D7��5:     
�������$��1q�6=   $��0,2,0,0q�6Q   $y�Hidden=�6b   �� 5;     -M   5        $	 
tbDateW3D7��5;     $��12(�60   $��May-01��6>   $��5,0,0,0q�6L   5<     �� 5?     -N   5        $ stpW4D1��5?     $��1��6*   $��6��6:   $��82��6G   $��82��6R   .+�5@     �� 
�������$��1q�6,   �� 5A     
�������$��1q�6,   $��0,1,0,0q�6@   $y�Hidden=�6Q   �� 5B     -O   5        $	 
tbDateW4D1��5B     $��12(�60   $��02��6>   $��5,0,0,0q�6H   �� 5C     -P   5        $	 w4d1_Event1��5C     
���  ��$��9(�6B   $��1,3,0,0q�6O   $!��1pm Virtual Board Game Cafe��5D  
   $! 1pm Virtual Board Game Cafe��5E     5F     �� 5G     
�������$��1q�6,   $��
0,44.1,0,0q�6@   5H     �� 5I     -Q   5        $ stpW4D2��5I     $��2��6*   $��6��6:   $��82��6G   $��82��6R   .+�5J     �� 
�������$��1q�6,   �� 5K     
�������$��1q�6,   $��0,1,0,0q�6@   $y�Hidden=�6Q   �� 5L     -R   5        $	 
tbDateW4D2��5L     $��12(�60   $��03��6>   $��5,0,0,0q�6H   �� 5M     -S   5        $	 w4d2_Event1��5M     
���  ��$��1,3,0,0q�6B   $��10(�6S   $�� ��5N  
   �� 5O     
�������$��1q�6,   $��
0,42.7,0,0q�6@   5P     �� 5Q     -T   5        $ stpW4D3��5Q     $��3��6*   $��6��6:   $��82��6G   $��82��6R   .+�5R     �� 
�������$��1q�6,   �� 5S     
�������$��1q�6,   $��0,1,0,0q�6@   $y�Hidden=�6Q   �� 5T     -U   5        $	 
tbDateW4D3��5T     $��12(�60   $��04��6>   $��5,0,0,0q�6H   �� 5U     -V   5        $	 w4d3_Event1��5U     
���  ��$��1,3,0,0q�6B   $��9(�6S   $��11am Launchpad Liftoff!��5V  
   $ 11am Launchpad Liftoff!��5W     �� 5X     
�������$��1q�6,   $��
0,44.1,0,0q�6@   5Y     �� 5Z     -W   5        $ stpW4D4��5Z     $��4��6*   $��6��6:   $��82��6G   $��82��6R   .+�5[     �� 
�������$��1q�6,   �� 5\     
�������$��1q�6,   $��0,1,0,0q�6@   $y�Hidden=�6Q   �� 5]     -X   5        $	 
tbDateW4D4��5]     $��12(�60   $��05��6>   $��5,0,0,0q�6H   �� 5^     -Y   5        $	 w4d4_Event1��5^     $��10(�61   $�� ��5_  
   
���  ��$��1,3,0,0q�6#   �� 5`     
�������$��1q�6,   $��
0,42.7,0,0q�6@   5b     �� 5c     -Z   5        $ stpW4D5��5c     $��5��6*   $��6��6:   $��82��6G   $��82��6R   .+�5d     �� 
�������$��1q�6,   �� 5e     
�������$��1q�6,   $��0,1,0,0q�6@   $y�Hidden=�6Q   �� 5f     -[   5        $	 
tbDateW4D5��5f     $��12(�60   $��06��6>   $��5,0,0,0q�6H   �� 5g     
�������$��1q�6,   $��0,59,0,0q�6@   5h     �� 5i     -\   5        $ stpW4D6��5i     $��6��6*   $��6��6:   $��82��6G   $��82��6R   .+�5j     �� 
�������$��1q�6,   �� 5k     
�������$��1q�6,   $��0,1,0,0q�6@   $y�Hidden=�6Q   �� 5l     -]   5        $	 
tbDateW4D6��5l     $��12(�60   $��07��6>   $��5,0,0,0q�6H   �� 5m     -^   5        $	 w4d6_Event1��5m     
���  ��$��1,3,0,0q�6B   $��9(�6S   $��2pm Virtual RealiTEA��5n  
   $ 2pm Virtual RealiTEA��5o     �� 5p     
�������$��1q�6,   $��
0,44.1,0,0q�6@   5q     �� 5r     -_   5        $ stpW4D7��5r     $��7��6*   $��6��6:   $��82��6G   $��82��6R   .+�5s     �� 
�������$��1q�6,   �� 5t     
�������$��1q�6,   $��0,1,0,0q�6@   $y�Hidden=�6Q   �� 5u     -`   5        $	 
tbDateW4D7��5u     $��12(�60   $��08��6>   $��5,0,0,0q�6H   �� 5v     
�������$��1q�6,   $��0,59,0,0q�6@   5w     5y     5{     5|     