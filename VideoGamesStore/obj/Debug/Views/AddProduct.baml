   M S B A M L   `   `   `  ����  VideoGamesStore&     VideoGamesStore.Views.AddProduct   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Icon$  /Resources/logo.ico��5   	    � Title$ 
AddProduct��5   	   $	��450��6   $	��600��6)   .��5	      � ���#171d25 � RowDefinitions 5
   
   �� 5      $��50 �6   �� 5      $��2* �6   �� 5      $��40 �6   .+�5   
   � $��0��6   ���#9966CC � ColumnDefinitions 5      �� 5      $��70 �6#   �� 5      $��2* �6#   �� 5      $��70 �6#   .+�5      �� -   5        $��backToCatalog��5   %   $��0��6   $��32(�6P   $	��←��6^   ���#9966CC
�������6   �� 5      $��Playerok��6   
�������   TextBlockStyle#��[  6;   $��1��6c   $��0��6s   $��Center=�6�   $��Center=�6�   5      � 5   
   $��1��6    5      �� 5      $��2* �6#   �� 5      .+�5      � $��0��6   $��1��6#    5      �� 5       $��* �6$   �� 5!      $��* �6$   �� 5"      $��* �6$   �� 5#      $��* �6$   �� 5$      $��* �6$   �� 5%      $��2* �6$   .+�5'      �� 
�������$��Название: ��6/   $
��Left=�6A   $��Center=�6\   #��[  6w   �� 5(      -   5        $��TitleTextBox��5(   .   
�������
���   �$	��140��6U   $��40��6a   $��35, 0, 0, 0q�6m   �� 5)      
�������$��1��6/   $��Разработчик: ��6<   $
��Left=�6Q   $��Center=�6l   #��[  6�   �� 5*      -   5        $��developerComboBox��5*   I   $��1��6b   $	��140��6o   $��40��6{   
�������$��35, 0, 0, 0q�6�   �� 5+      
�������$��2��6/   $��
Жанр: ��6<   $
��Left=�6J   $��Center=�6e   #��[  6�   �� 5,      -   5        $��categoryComboBox��5,   G   $��2��6_   $	��140��6l   $��40��6x   
�������$��35, 0, 0, 0q�6�   �� 5-      
�������$��3��6/   $��Стоимость: ��6<   $
��Left=�6O   $��Center=�6j   #��[  6�   �� 5.      -   5        $��PriceTextBox��5.   :   
�������$��3��6-   
���   �$	��140��6a   $��40��6m   $��35, 0, 0, 0q�6y   �� 5/      
�������$��4��6/   $��Скидка: ��6<   $
��Left=�6L   $��Center=�6g   #��[  6�   �� 50      -   5        $��DiscountTextBox��50   :   
�������$��4��6-   
���   �$	��140��6d   $��40��6p   $��35, 0, 0, 0q�6|   �� 51      
�������$��5��6/   $��Описание: ��6<   $
��Left=�6N   $��Center=�6i   #��[  6�   �� 52      -   5        $��DescriptionTextBox��52   M   
�������
���   �$��5��6@   $��70��6g   $	��250��6s   $��145, 0, 0, 0q�6   53      �� 54      -   5        $��editProductImage��54      $��2��6,   $	��160��6<   $	��160��6H   $
��Fill=�6U   �� 55      -	   5        $��OpenDialogButton��55   {   
���   �
�������$��15(�6;   $��Impact)�6I   $+��%Выбрать изображение��6]   $	��170��6�   $��70��6�   $��2��6�   $	��Top=�6�   $��Center=�6�   $��0,15,0,0q�6�   �� 56      -
   5        $��saveEditForm��56   q   
���   �
�������$��15(�6;   $��Impact)�6I   $��Сохранить��6]   $��2��6�   $	��170��6�   $��70��6�   $��Center=�6�   $��Bottom=�6�   $��0,0,0,15q�6�   57      58      59      