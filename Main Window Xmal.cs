﻿<Window x:Class="Lab_12_Task_1.MainWindow"  
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"  
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"  
        Title="Order Information" Height="350" Width="525">
    <StackPanel Margin="10">
        <Label Content="Select Shipping Address:" />
        <ComboBox x:Name="AddressComboBox"   
          SelectionChanged="AddressComboBox_SelectionChanged"  
          Height="25"/>

        <Label Content="New Address:" />
        <TextBox x:Name="NewAddressTextBox"   
                 Margin="0,5,0,10"   
                 Height="25"/>

        <Button Content="Change Address" Click="ChangeAddress_Click" Margin="0,5,0,0"/>
        <Button Content="Add Address" Click="AddAddress_Click" Margin="0,5,0,0"/>

        <TextBlock x:Name="ShippingAddressTextBlock"   
                   Text="{Binding RelativeSource={RelativeSource AncestorType=Window}, Path=ShippingAddress}"   
                   Margin="0,10,0,0"/>
    </StackPanel>
</Window>
