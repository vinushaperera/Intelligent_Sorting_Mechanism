   M S B A M L   `   `   `  ����V  RIntelligentSortingMechanism, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:IntelligentSortingMechanism.Views!IntelligentSortingMechanism.Views  5   	   3    -IntelligentSortingMechanism.Views.AddTaskView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:IntelligentSortingMechanism.Views     5   	     � Title$  AddTaskView��5   	   $	��400��6   $	��460��6*   .��5	      � .+�5
   
   �� -   5         ��Name$ task_desc_lbl��5
      $��Task Description��6'   $
��Left=�6B   $��	86,77,0,0q�6]   $	��Top=�6p   �� 5   
   -   5        $ task_deadline_lbl��5      $��Due Date��6+   $
��Left=�6>   $��
86,124,0,0q�6Y   $	��Top=�6m   $��96��6�   �� 5   
   -   5        $ task_priority_lbl��5      $��Priority��6+   $
��Left=�6>   $��
86,172,0,0q�6Y   $	��Top=�6m   $��96��6�   �� 5   
   -   5         ��Name$ add_task_header��5      $��18(�6-   $
��Left=�6;   $��
191,17,0,0q�6V   $
��Wrap=�6j   $��New Task��6~   $	��Top=�6�   �� 5   
   -   5         ��Name$ task_desc_box��5      $
��Left=�6)   $��23��6D   $��
220,78,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��120��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ task_deadline_date��5      $
��Left=�61   $��220,124,0,0q�6L   $	��Top=�6a   $	��120��6y   �� 5   
   -   5         ��Name$ task_priority_combo��5       �� Text$ Select Priority��60   $
��Left=�6G   $��220,173,0,0q�6b   $	��Top=�6w   $	��120��6�   .@�5      �� -   5        $
��cbi1��5      .��6'   16*   �� 5      -	   5        $
��cbi2��5      .��6'   26*   �� 5      -
   5        $
��cbi3��5      .��6'   36*   �� 5      -   5        $
��cbi4��5      .��6'   46*   �� 5      -   5        $
��cbi5��5      .��6'   56*   5      �� 5   
   -   5         ��Name$ back_btn��5      $
��Back��6#   $
��Left=�62   $��253,299,0,0q�6M   $	��Top=�6b   $��75��6z   6�   �� 5   
   -   5        $ add_task_btn��5      $��Add Task��6'   $
��Left=�6:   $��132,299,0,0q�6U   $	��Top=�6j   $��75��6�   6�   �� 5   
   -   5        $ link_id_lbl��5      $��Task Link ID��6%   $
��Left=�6<   $��
86,223,0,0q�6W   $	��Top=�6k   �� 5   
   -   5        $ link_id_box��5      $
��Left=�6'   $��23��6B   $��220,223,0,0q�6N   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��120��6�   5      5      