# Components for .NET MAUI
## 🚀 Getting Started
Quick Start
1. Install via NuGet
### Terminal:
dotnet add package KbrKiras.MauiComponents -Version 1.0.2

### Nuget Terminal:
Install-Package KbrKiras.MauiComponents -Version 1.0.2

## How to use it?
### Navbar
```
....
xmlns:mauicomponents="clr-namespace:MauiComponents;assembly=MauiComponents"
....

<Shell.TitleView>
        <mauicomponents:NavBar>
            <mauicomponents:NavBar.BindingContext>
                <models:NavBarModel Title="Test" Icon="dotnet_bot.svg"></models:NavBarModel>
            </mauicomponents:NavBar.BindingContext>
        </mauicomponents:NavBar>
</Shell.TitleView>
```

![image](https://user-images.githubusercontent.com/41776940/191427413-be149d96-a95c-41cd-bf94-851b0481ec82.png)

### TextInput

```
<mauicomponents:TextInput>
                <mauicomponents:TextInput.BindingContext>
                    <models:EntryModel ShowIconWhenEmpty="True" Icon="search.png" Placeholder="Search"></models:EntryModel>
                </mauicomponents:TextInput.BindingContext>
 </mauicomponents:TextInput>
 ```
 ![image](https://user-images.githubusercontent.com/41776940/191434536-5d267785-a166-4c9c-b323-b1287f64c6d3.png)
