   M S B A M L   `   `   `  ���� >  :WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:Galazkiewicz.ProjectTireCatalog.WPF#Galazkiewicz.ProjectTireCatalog.WPF  9    3Galazkiewicz.ProjectTireCatalog.WPF.ProducersWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Clocal1clr-namespace:Galazkiewicz.ProjectTireCatalog.WPF     -   $��ProducerWindow��  � Title$  ProducersWindow��$	��450��$	��800��.���  � ColumnDefinitions �� $
��Auto ��� $
��Auto �.+��� -   $��ProducersList��$��0��$
��Left=�$��Stretch=� �� DisplayMemberPath$
 Name������  �� ElementName$ ProducerWindow�� �� Path$ 	Producers�� $��1�� � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto � �� $
��Auto ��� $	��400 �.+��� $��0��$��0��$��Producer Name:���� $��1��$��0��$��3q����� $ ProducersList��$ SelectedItem.Name�