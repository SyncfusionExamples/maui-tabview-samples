# Maui TabView Samples
Contains samples for .NET MAUI Tab View.
#   Getting Started with .NET MAUI Tab View (SfTabView)
This section explains the steps required to configure the .NET MAUI Tab View control and customize its elements.

##  Adding a .NET MAUI Tab View reference
Syncfusion .NET MAUI controls are available in Nuget.org. To add .NET MAUI Tab View to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.TabView and then install it.

#   Create a simple .NET MAUI Tab View
This section explains how to create a .NET MAUI Tab View and configure it. The control can be configured entirely in C# code or by the XAML markup.

##  Creating the project
Create a new .NET MAUI application in Visual Studio

##  Adding a .NET MAUI Tab View control
Step 1: Add the NuGet to the project as discussed in the above reference section.

Step 2: Add the namespace as shown in the following code sample.

**[XAML]**
```
xmlns:tabView="clr-namespace:Syncfusion.Maui.TabView;assembly=Syncfusion.Maui.TabView"
```

Step 3: Set the control to content in ContentPage.

**[XAML]**
```
<ContentPage.Content>
        <tabView:SfTabView BackgroundColor="#f6f6f6">
            <tabView:SfTabItem Header="Call">
                <tabView:SfTabItem.Content>
                    <Grid BackgroundColor="White" x:Name="AllContactsGrid">
                        <ListView x:Name="ContactListView" 
                                  ItemsSource="{Binding ContactList}"
                                  RowHeight="75">
                            <ListView.BindingContext>
                                <local:ContactsViewModel />
                            </ListView.BindingContext>
                            <ListView.ItemTemplate>
                                <DataTemplate>
                                    <ViewCell>
                                        <StackLayout Orientation="Vertical" Margin="30,0,0,0">
                                            <Label Text="{Binding Name}"
                                                   FontSize="24" />
                                            <Label Text="{Binding Number}" 
                                                   FontSize="20" 
                                                   TextColor="LightSlateGray" />
                                        </StackLayout>
                                    </ViewCell>
                                </DataTemplate>
                            </ListView.ItemTemplate>
                        </ListView>
                    </Grid>
                </tabView:SfTabItem.Content>
            </tabView:SfTabItem>
            <tabView:SfTabItem Header="Favorites">
                <tabView:SfTabItem.Content>
                    <ListView RowHeight="50">
                        <ListView.ItemsSource>
                            <x:Array Type="{x:Type x:String}">
                                <x:String>James</x:String>
                                <x:String>Richard</x:String>
                                <x:String>Michael</x:String>
                                <x:String>Alex</x:String>
                                <x:String>Clara</x:String>
                            </x:Array>
                        </ListView.ItemsSource>
                        <ListView.ItemTemplate>
                            <DataTemplate>
                                <ViewCell>
                                    <Grid Margin="10,5">
                                        <Label
                                            VerticalOptions="Start"
                                            HorizontalOptions="Start"
                                            TextColor="#666666"
                                            FontSize="16"
                                            Text="{Binding}"/>
                                    </Grid>
                                </ViewCell>
                            </DataTemplate>
                        </ListView.ItemTemplate>
                    </ListView>
                </tabView:SfTabItem.Content>
            </tabView:SfTabItem>
            <tabView:SfTabItem Header="Contacts">
                <tabView:SfTabItem.Content>
                    <ListView RowHeight="50">
                        <ListView.ItemsSource>
                            <x:Array Type="{x:Type x:String}">
                                <x:String>Steve</x:String>
                                <x:String>Mark</x:String>
                                <x:String>Alan</x:String>
                                <x:String>Sandra</x:String>
                                <x:String>Ryan</x:String>
                            </x:Array>
                        </ListView.ItemsSource>
                        <ListView.ItemTemplate>
                            <DataTemplate>
                                <ViewCell>
                                    <Grid Margin="10,5">
                                        <Label
                                            VerticalOptions="Start"
                                            HorizontalOptions="Start"
                                            TextColor="#666666"
                                            FontSize="16"
                                            Text="{Binding}"/>
                                    </Grid>
                                </ViewCell>
                            </DataTemplate>
                        </ListView.ItemTemplate>
                    </ListView>
                </tabView:SfTabItem.Content>
            </tabView:SfTabItem>
        </tabView:SfTabView>
    </ContentPage.Content>
```
