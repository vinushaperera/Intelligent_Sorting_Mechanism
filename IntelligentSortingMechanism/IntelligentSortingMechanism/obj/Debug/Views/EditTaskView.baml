   M S B A M L   `   `   `  ����V  RIntelligentSortingMechanism, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:IntelligentSortingMechanism.Views!IntelligentSortingMechanism.Views  5   	   4    .IntelligentSortingMechanism.Views.EditTaskView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:IntelligentSortingMechanism.Views     5   	     � Title$  EditTaskView��5   	   $��412.105��6   $��529.703��6/   .��5	      � .+�5
   
   �� -   5         ��Name$ edit_task_header��5
      $��22(�6.   $��Center=�6<   $��220,21,208,0q�6Y   $
��Wrap=�6o   $��	Edit Task��6�   $	��Top=�6�   $��94��6�   �� 5   
   -   5        $ task_desc_txt��5      $��16(�6+   $
��Left=�69   $��	91,90,0,0q�6T   $
��Wrap=�6g   $��Task Description : ��6{   $	��Top=�6�   �� 5   
   -   5         ��Name$ desc_box��5      $��16(�6$   $
��Left=�62   $��23��6M   $��
248,90,0,0q�6Y    �� TextWrapping$
 Wrap=�6m   $�� ��6�   $	��Top=�6�   $	��201��6�   �� 5   
   -   5        $ priority_txt��5      $��16(�6+   $
��Left=�69   $��121,135,0,0q�6T   $
��Wrap=�6i   $��Task Priority : ��6}   $	��Top=�6�   �� 5   
   -   5         ��Name$ priority_box��5      $
��Left=�6)   $��248,134,0,0q�6D   $	��Top=�6Y   $	��201��6q   .@�5      �� -   5        $
��cbi1��5      .��6'   16*   �� 5      -   5        $
��cbi2��5      .��6'   26*   �� 5      -   5        $
��cbi3��5      .��6'   36*   �� 5      -	   5        $
��cbi4��5      .��6'   46*   �� 5      -
   5        $
��cbi5��5      .��6'   56*   5      �� 5   
   -   5        $ date_txt��5      $��16(�6'   $
��Left=�65   $��109,179,0,0q�6P   $
��Wrap=�6e   $��Task Deadline : ��6y   $	��Top=�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ date_box��5      $
��Left=�6'   $��248,179,0,0q�6B   $	��Top=�6W   $	��201��6o   �� 5   
   -   5        $ link_txt��5      $��16(�6'   $
��Left=�65   $��123,223,0,0q�6P   $
��Wrap=�6e   $��Task Link ID : ��6y   $	��Top=�6�   �� 5   
   -   5        $ link_box��5      $��16(�6$   $
��Left=�62   $��23��6M   $��248,223,0,0q�6Y   $
 Wrap=�6n   $�� ��6�   $	��Top=�6�   $	��201��6�   �� 5   
   -   5         ��Name$ done_btn��5      $
��Done��6#   $
��Left=�62   $��149,315,0,0q�6M   $	��Top=�6b   $	��100��6z   $��35��6�   $��16(�6�   6�   �� 5   
   -   5        $ 
cancel_btn��5      $��Cancel��6%   $
��Left=�66   $��286,315,0,0q�6Q   $	��Top=�6f   $	��100��6~   $��35��6�   $��16(�6�   6�   �� 5   
   -   5        $ error_txt_box��5      $
��Left=�6+   $��143,268,0,0q�6F   $
��Wrap=�6[   
���  ��$��16(�6�   $	��Top=�6�   ��6�   �� *	Error_txt+6�   5      5      