   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   L HLoanCalculatorWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:LoanCalculatorWPF.ViewLoanCalculatorWPF.View 5   	   I)clr-namespace:LoanCalculatorWPF.ViewModelLoanCalculatorWPF.ViewModel 5   	   "   LoanCalculatorWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   6local$clr-namespace:LoanCalculatorWPF.View     5   	   8vm)clr-namespace:LoanCalculatorWPF.ViewModel     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Cie:http://schemas.microsoft.com/expression/2010/interactivity  5	   	   Ai9http://schemas.microsoft.com/expression/2010/interactions  5
   	     � Title$  Loan Calculator��5   	   $	��800��6!   $	��600��6.    � Icon$ images/euro.png��6:    � DataContext 5   	   ��    Locator �� Source# [   �� Path$
 Main�.  (System.Windows.Interactivity.Interaction   	Behaviors 5      '  !LoanCalculatorWPF.View.PrintClick  5   
   
   Btn 6   ��  �� ElementName$ btnPrint��   Document 6@   �� $ flowDocument��	 � 	Resources	 5      6  0LoanCalculatorWPF.View.BoolToVisibilityConverter  BoolToVisibilityConverter
 �� 
TargetType  txtNormalStyle �� Property �� Value  txtSmallStyle  tbNormalStyle  cbNormalStyle  slNormalStyle  btnNormalStyle  imgNormalStyle 	 CellInterestsTemplate � Maximum � Value �� Mode � ToolTip �� Orientation��%{  &	       &	      &	 �     &	 g    &	 1    &	 �    &	 7    &	 �    &		 _      5   
   6*   �� 5   
   "
 ��6   .�5      ��  � ��$ 16(�6)   �� 5       � ��$	 0,3q�6'   �� 5       � ��$ Center=�62   5      �� 5   
   "
 ��6   .�5      ��  � ��$ 12(�6)   �� 5       � ��$ 0,0,0,8q�6'   �� 5       � ��$ Center=�62   �� 5       � ��
 �����6+   5      �� 5   
   "
 ��6   .�5      ��  � ��$ 16(�6)   �� 5        � ��$	 0,3q�6'   �� 5!       � ��$ Center=�62   �� 5"       �@��TextAlignment$ Right=�6.   5#      �� 5$   
   "
 ��6   .�5%      ��  � ��$ 14(�6)   �� 5&       � ��$	 0,3q�6'   �� 5'       � ��$ Center=�62   5(      �� 5)   
   "
 ��6   .�5*      ��  � ��$	 3,3q�6'   �� 5+       � ��$ Center=�62   5,      �� 5-   
   "
 ��6   .�5.      ��  � ��$ 5q�6'   �� 5/       � ��$ Center=�62   �� 50       � ��$	 200��6)   51      �� 52   
   "
 ��6   .�53      ��  � ��$ 20��6&   �� 54       � ��$ 20��6'   �� 55       � ��$ Center=�62   56      �� 57   
   .R�58      � $	 100Q�6   
���\\��
��� d � 6(   �� *PercentageBaseAmount+$ OneWay=� 59      �� 5:      .+�5;      �� $ 
Horizontal=�6%   .+�5<      �� $��Base amount: ��6(   �� 5=      ��6(   �� *
BaseAmount+5>      �� 5?      $ 
Horizontal=�6%   .+�5@      �� $��Amount of interest: ��6(   �� 5A      ��6(   �� *AmountOfInterest+5B      5C      5E      5F      5G      .��5H      ]� .+�5I   
   o� $	��Top=�6   .@�5J      m� $
��Help��6   .@�5K      m� $��About��6    m� Icon 5L      �� 5M      $��images/info.png��6     5O      )  #LoanCalculatorWPF.View.AboutBoxOpen  5P      5R      5S      5T      � 5U   
   $��10q�6    � ColumnDefinitions 5V      �� 5W      $��1* �6#   �� 5X      $��2* �6#    � RowDefinitions 5Z      �� 5[      $
��auto �6    �� 5\      $
��auto �6    �� 5]      $
��auto �6    �� 5^      $
��auto �6    �� 5_      $
��auto �6    �� 5`      $
��auto �6    �� 5a      $
��auto �6    �� 5b      $
��auto �6    �� 5c      $
��auto �6    �� 5d      .+�5f      �� $��0��6   $��1��6(   $��Type:��65   #��[ 6B   �� 5g      $��0��6   $��2��6(   $��Amount:��65   #��[ 6D   �� 5h      $��0��6   $��4��6(   $��Number of years:��65   #��[ 6M   �� 5i      $��1��6   $��1��6'   #��[ 6�   ��64   �� *ListOfTypesOfLoan+ �� SelectedValue 6^   �� *SelectedLoanTypes+6�   �� 5j      -   5         ��Name$ 	txtAmount��5j      $��1��6)   $��2��69   #��[ 6�   ��6F   �� *Amount+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�.��6�   5k      �� 5l      $��1��6   $��3��6)   $ 
Horizontal=�66   $��Right=�6O   .+�5m      �� $��	Maximum: ��6   #��[ 6-   �� 5n      #��[ 6D   ��6   �� *	MaxAmount+$ TwoWay=�6D   5o      � 5p      $��1��6   $��4��6#    5q      �� 5r      $��4* �6'   �� 5s      $��1* �6'   .+�5u      �� #��[ 6    � Minimum$ 1Q�6�    6A   �� *NumberOfYears+ 6a   �� *MaxNumberOfYears+6�   �� 5v      -   5        $ tbNumberOfYears��5v      $��1��63   #��[ 6C   ��6j   �� *NumberOfYears+$ PropertyChanged=�5w      �� 5x      $��1��6   $��5��6)   $ 
Horizontal=�66   $��Right=�6O   .+�5y      �� $��	Maximum: ��6   #��[ 6-   �� 5z      #��[ 6K   ��6   �� *MaxNumberOfYears+$ TwoWay=�6K   5{      �� 5|      $��1��6   $��6��6%   ��62   �� *ApplyCommand+��5}      �� 5~      "
 ��6   .�5      ��  � {� .  66   �� 5�       � ��$ Center=�6>   �� 5�       � ��$ Right=�6@   �� 5�       � ��$	 200��62    �� Triggers 5�      ^� 5�       ^� 
Conditions 5�   "   �� 5�   &    �� Binding 60   �� $ (Validation.HasError)�$ 	txtAmount�� �� Value	 False6v   �� 5�   &    60   �� $ (Validation.HasError)�$ tbNumberOfYears��	 False6|   .0�5�   "   ��  � {� . 6>   5�      �� 5�       �� Binding 6*   �� $ 	txtAmount��$
 Text� �� Value 06_   .a�5�   "   ��  � {� .  6>   5�      5�      .��5�      �� $ 
Horizontal=�6   .+�5�      �� $��images/accept.png��6   #��[ 67   $
��10,0q�6_   �� 5�      $��Apply��6    #��[ 6-   5�      5�      �� 5�      
�������$��1q�6-   $��2��6A   $��7��6U   $��0, 10q�6b   ]� 5�      $��2��6   $��8��6,   y�69   �� *IsPlanVisible+ �� 	Converter# [ .+�5�      �� #��[ 67   ��6   �� *	Plan.Name+67   �� 5�      $��;  Interests: ��6   #��[ 62   �� 5�      #��[ 6A   ��6   �� *InterestsPercentage+6A   �� 5�      $��;  Sum of interests: ��6   #��[ 69   �� 5�      #��[ 6<   ��6   �� *SumOfInterests+6<   �� 5�      -   5          ��Name$  btnPrint��5�      $��Right=�6+   #��[ 6G   .��5�      �� $ 
Horizontal=�6!   .+�5�      �� $��images/print.png��6    $��20��6:   $��4q�6E   �� 5�      $��Print��6$   $��Center=�61   $��4q�6L   5�      5�      5�      &   System.Windows.Controls.DataGrid  5�      $��2��6   $��9��6+   ��. $
��Auto=�6]   !   
IsReadOnly! . "   AutoGenerateColumns" .  ��5�      �� *Plan.Installments+#   Columns# 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn$   Header$$ Number��6)   %   Width5  /System.Windows.Controls.DataGridLengthConverter$% 1* 6T   1	  +System.Windows.Controls.DataGridBoundColumn& 	  Binding& 69   �� *Number+6T     5�      $
$ Date��6)   $% 2* 6�   & 67   �� *PaymentDeadline+' �� StringFormat$' d��( �� ConverterCulture$( en-GB��6�     5�      $$ Amount��6)   $% 2* 6T   & 69   �� *Amount+6T   4
  .System.Windows.Controls.DataGridTemplateColumn
  5�      $% 3* 6-   ) 
  CellTemplate#) [	 68   *   
IsReadOnly* . 6n   5�      ,� 5�      $y�	Collapsed=�6'   .��5�      /� -   5        + /�Name$+ flowDocument��5�      .T�5�      �� .r�5�      �� $��0q�6#   ��67   �� *Plan.Installments+, �� View, 5�      �� 5�   "   .P�5�   &   �� $��Number��65   - �� Width$	- 100��6m   . �� DisplayMemberBinding. 6E   �� *Number+6m   �� 5�   &   $��Payment Deadline��65   $	- 200��6�   . 6O   �� *PaymentDeadline+$' d��$( en-GB��6�   �� 5�   &   $��Amount��65   $	- 200��6m   . 6E   �� *Amount+6m   5�   #   5�      5�      5�      5�      5�      5�      5�      