   M S B A M L   `   `   `  ????M  IPractic2(4)_in_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Practic2_4__in_WPFPractic2_4__in_WPF  5   	   )    #Practic2_4__in_WPF.NoteCreateWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Practic2_4__in_WPF     5   	     ? Title$  NoteCreateWindow??5   	   $	??450??6"   $	??800??6/   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      $
??256* ?6   ?? 5      $	??93* ?6   ?? 5      $
??112* ?6   ?? 5      $
??113* ?6   ?? 5      $
??226* ?6    ? RowDefinitions 5   
   ?? 5      $	??29* ?6   ?? 5      $
??188* ?6   .+?5   
   ?? -   5        $??
Назад??5      $??Center=?6!   $??40??6>   $??Center=?6J   $??82??6e   $??3??6?   ?? 5   
   -   5         ??Name$
 Save??5      $??Сохранить??6   $??Center=?63   $??42??6P   $??Center=?6\   $??96??6w   $??4??6?   ?? 5   
   -   5         ??Name$ NameNote??5      $
??Left=?6$    ?? TextWrapping$
 Wrap=?6?   $??Center=?6S   $	??193??6n    J? RenderTransformOrigin$ 1.198,-2.402&?6z   $??40??6?   $??Название??6?   $??0??6?   $??10,0,0,0q?6?   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ DateNote??5      $??Center=?6'   $??Center=?6D      SelectedDateFormat$ Short=?6_   $??2??6z   $??38??6?   $	??100??6?   ?? 5   
   -   5        $ 	Bank_Text??5      $
??Left=?6%   $	??293??6@   $??	10,10,0,0q?6M   $
 Wrap=?6`   $	??Top=?6t   $	??221??6?   $??Содержимое??6?   $??0??6?   $??1??6?   5      5      