   M S B A M L   `   `   `  ????T  PYaraTechnologiesAssesment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:YaraTechnologiesAssesmentYaraTechnologiesAssesment  5   	   ,    &YaraTechnologiesAssesment.ViewTeachers   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   _ [MaterialDesignThemes.Wpf, Version=4.7.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   3local'clr-namespace:YaraTechnologiesAssesment  5   	     ? WindowStyle$
  None=?5	   	    ? WindowStartupLocation$ CenterScreen=?5
   	    ? Title$ ViewTeachers??5   	   $	??450??6   $	??500??6+   .??5      ? -   5        .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgv_teachers??5      $??Center=?6)   $??0,29,0,0q?6G   $	??309??6Y   $	??Top=?6f   $	??428??6~   $??Center=?6?   ?? 5   
   -   5         ??Name$ btn_view??5      $
??VIEW??6#   $
??Left=?62   $??250,377,0,0q?6M   $	??Top=?6b   $??76??6?   ?? 5   
   -   5        $ 
btn_cancel??5      $??CANCEL??6%   $
??Left=?66   $??347,377,0,0q?6Q   $	??Top=?6f   6~   ?? 5   
   -   5         ??Name$ txt_name??5      $
??Left=?6$   $??
64,377,0,0q?6?   $?? ??6S    ?? TextWrapping$
 Wrap=?6[   $	??Top=?6o   $	??165??6?   $??32??6?   $??13(?6?   $??Center=?6?   $??Center=?6?   5      5      