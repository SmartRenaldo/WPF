   M S B A M L   `   `   `  ????B  >15_Menu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:_15_Menu_15_Menu  5   	       _15_Menu.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:_15_Menu     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)    ? 	Resources 5
       	  myCmd??%   &	        ?? 5   
   6*   5       J? CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command# [  5      6_    J? InputBindings 5      ?? 5   
    ?? Command# [  6    ?? Gesture$ Ctrl+6??66   6I   .??5      ? .+?5   
   o? $	??Top=?6   $??30??6'   .@?5      m? $
??Beef??6    m? Command# [  6%   m? 5      $
??Lamb??6   m? 5      $
??Pork??6   .@?5      m? $??Roast??6    m? InputGestureText$ Ctrl+6??6*   6F   m? 5      $	??BBQ??6   6*   m? 5      $??Fried??6   6,   5      5      5      5       