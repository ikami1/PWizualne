   M S B A M L   `   `   `  ���� O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  ? ;CORE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli@clr-namespace:Galazkiewicz.ProjectTireCatalog.Core;assembly=CORE$Galazkiewicz.ProjectTireCatalog.Core > :WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:Galazkiewicz.ProjectTireCatalog.WPF#Galazkiewicz.ProjectTireCatalog.WPF m;clr-namespace:Galazkiewicz.ProjectTireCatalog.WPF.ViewModel-Galazkiewicz.ProjectTireCatalog.WPF.ViewModel 5   /Galazkiewicz.ProjectTireCatalog.WPF.TiresWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     9System&clr-namespace:System;assembly=mscorlib     W
StyleAlias@clr-namespace:Galazkiewicz.ProjectTireCatalog.Core;assembly=CORE     Clocal1clr-namespace:Galazkiewicz.ProjectTireCatalog.WPF     Q	ViewModel;clr-namespace:Galazkiewicz.ProjectTireCatalog.WPF.ViewModel     -   $��
TireWindow��  � Title$  TiresWindow��$	��350��$	��600�� � 	Resources    purposeEnum S� 
MethodName S� 
ObjectType   System.Enum S� MethodParameters M� TypeName  TextBoxWithErrors �� Property �� Value �� DisplayMemberPath	 �� ElementName
 �� Path �� Triggers P� Property P� Value��%$  &	        &	 <     S� $ 	GetValues��"   M� $ StyleAlias:Purpose���� .���  �@=�ErrorTemplate �� .R�]� ��. .+��� $��Bottom=�$ ErrorContent������ $	 ErrorComponent��$(
 "AdornedElement.(Validation.Errors)�� $
��Left=�.+�A� $��20��$��20��
���  ��
���  ���� 
����������� $	 ErrorComponent��$.
 (AdornedElement.(Validation.Errors).Count��� 
���  ��$��2q�._��� $��ErrorComponent����  � ��$	 150�� P�  �@=�HasError . . ���  � ��$ 	20 2 2 50q�.���� .@��� $��Tires�� � DataContext E  ?Galazkiewicz.ProjectTireCatalog.WPF.ViewModel.TireListViewModel  .��]� ��. .+��� -   $��	TiresList��$
��left=����� *Tires+ �� SelectedItem �� *SelectedTire+���� .R���  �� Orientation$ 
Horizontal=�.+��� $��80������ *Producer.Name+�� $��50������ *Model+�� $��Bottom=�$ 
Horizontal=�.+��� ���� *FilterDataCommand+.��Filter�� $	��100������ *FilterValue+�� ���� *AddNewTireCommand+.��Add new tire�� ���� *SaveTireCommand+.��	Save tire� $��1�� �� *
EditedTire+ � RowDefinitions �� $
��Auto ��� $��* �.+�� $��0�� � ColumnDefinitions �� $
��Auto ��� $��* � �� �� �� �� �� .+��� $��0��$��Model:���� #��[ $��1��$��0��$	��150������ *Model+�� $��1��$��Waga:���� #��[ $��1��$��1��$	��150������ *Waga+�� $��2��$��	Producer:���� #��[ $��1��$��2��$
 Name������ *	Producers+ �� *
Producer+�� $��3��$��Purpose:���� #��[ $��1��$��3������  �� Source# [   �� *PurposeType+�� $��	Producers�� I  CGalazkiewicz.ProjectTireCatalog.WPF.ViewModel.ProducerListViewModel  .��]� ��. .+��� -   $��ProducerListPanel��$
��Left=�$
 Name������ *	Producers+ �� *SelectedProducer+�� $��Bottom=�$ 
Horizontal=�.+��� ���� *FilterDataCommand+.��Filter�� $	��100������ *FilterValue+�� ���� *AddNewProducerCommand+.��Add new Producer�� ���� *SaveProducerCommand+.��Save Producer� -   $��ProdDetailsList�� �� *EditedProducer+ �� $
��Auto ��� $��* �.+�� $��0�� �� $
��Auto ��� $��* � �� .+��� $��0��.��Name:�� #��[ $��0��$��1��$	��150������ *Name+