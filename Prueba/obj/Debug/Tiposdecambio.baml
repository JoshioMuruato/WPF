   M S B A M L   `   `   `  ����A  =Prueba, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PruebaPrueba  5   	       Prueba.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Prueba     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6*   $	��450��66   $	��800��6F   $	��800��6U   $	��450��6d   .��5	      �  J� RenderTransformOrigin$ 0.5,0.5&�6   z�5
   
   V� 5      .~�5      ��  �� ScaleY$ 1Q�6!    �� ScaleX$ 1Q�6,   �� 5       �� AngleY$ 0Q�6     �� AngleX$ 0Q�6+   �� 5       �� Angle$ 0Q�6"   T� 5      5      ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      � 	 � Color$	 #0061FF��6   
 � Offset$
 0Q�6/   � 5      $	 #606fff��6   $
 0.539Q�6/   5       � ColumnDefinitions 5   
   �� 5      $
��139* �6   �� 5      $	��43* �6   �� 5      $
��610* �6   .+�5   
   �� $��2��6   $
��Left=�6$   $��57��6?   $��	15,69,0,0q�6K   
�������$	��Top=�6m   $	��390��6�   �� 5"   
   $��2��6   $
��Left=�6$   $��57��6?   $��
228,69,0,0q�6K   
�������$	��Top=�6n   $��89��6�   �� 5%   
   $��2��6   $
��Left=�6$   $��57��6?   $��
140,69,0,0q�6K   
�������$	��Top=�6n   $��89��6�   �� 5(   
   $��2��6   $
��Left=�6$   $��30��6?   $��	15,96,0,0q�6K   
�������$	��Top=�6m   $	��390��6�   �� 5+   
   -   5         ��Name$ 	TipoScra1��5+      $ ��Tipo de Cambio (Scraping):��6#   $
��Left=�6H   $��	92,34,0,0q�6c   $	��Top=�6v   
�������$
��Bold"�6�   $��16(�6�   $��2��6�   �� 5,   
   -   5        $ 
FechaScra1��5,      $��
dd/mm/yyyy��6$   $
��Left=�69   $��
42,100,0,0q�6T   $	��Top=�6h   $��2��6�   
�������6�   �� 5-   
   -   5        $ TFechaScra1��5-      $��Fecha��6%   $
��Left=�65   $��	60,71,0,0q�6P   $	��Top=�6c   $��2��6{   
�������$
��Bold"�6�   �� 5.   
   -   5        $ FIXScra1��5.      $	��0.0��6"   $
��Left=�60   $��173,100,0,0q�6K   $	��Top=�6`   $��2��6x   
�������6�   �� 5/   
   -   5        $ 	TFIXScra1��5/      $	��FIX��6#   $
��Left=�61   $��
173,71,0,0q�6L   $	��Top=�6`   $��2��6x   
�������$
��Bold"�6�   �� 50   
   -   5        $ DOFScra1��50      $	��0.0��6"   $
��Left=�60   $��258,100,0,0q�6K   $	��Top=�6`   $��2��6x   
�������6�   �� 51   
   -   5        $ 	TDOFScra1��51      $	��DOF��6#   $
��Left=�61   $��
259,71,0,0q�6L   $	��Top=�6`   $��2��6x   
�������$
��Bold"�6�   �� 52   
   -   5        $ Para_Pagos1��52      $	��0.0��6%   $
��Left=�63   $��346,100,0,0q�6N   $	��Top=�6c   $��2��6{   
�������6�   �� 53   
   -	   5        $ TPara_Pagos1��53      $��
Para Pagos��6&   $
��Left=�6;   $��
322,71,0,0q�6V   $	��Top=�6j   $��2��6�   
�������$
��Bold"�6�   $��82��6�   �� 56   
   -
   5        $ TipoApi1��56      $��Tipo de Cambio (API):��6"   $
��Left=�6B   $��123,209,0,0q�6]   $	��Top=�6r   $��2��6�   
�������$��16(�6�   $
��Bold"�6�   �� 57   
   -   5        $ 	ValorApi1��57      $	��0.0��6#   $
��Left=�61   $��173,245,0,0q�6L   $	��Top=�6a   $��2��6y   ���	#FFFDFDFD$ -0.385,0.577&�6�   �� 58   
   -   5        $ Usuario1��58      $
��User��6"   $
��Left=�61   $��
462,15,0,0q�6L   $	��Top=�6`   $��2��6x   
�������6�   �� 59   
   -   5         ��Name$ button1Scra��59      $��	Consultar��6&   $��2��6:   $
��Left=�6J   $��173,136,0,0q�6e   $	��Top=�6z   $��75��6�   $��Medium"�6�   
�������$��2q�6�   ���	#00DDDDDD
������� � 	Resources 5:       �� 
TargetType �� Property �� Value��%_   '��       �� 5;      " ��6   .�5<      ��  �@��CornerRadius$ 10��65   5=      5>      5?      �� 5@   
   -   5        $ 
button1API��5@      $��	Consultar��6%   $��2��69   $
��Left=�6I   $��165,284,0,0q�6d   $	��Top=�6y   $��76��6�   $��Medium"�6�   
�������$��2q�6�   ���	#00DDDDDD
������� 5A      ��%_   '��       �� 5B      " ��6   .�5C      ��  �@��CornerRadius$ 10��65   5D      5E      5F      5I      5J      