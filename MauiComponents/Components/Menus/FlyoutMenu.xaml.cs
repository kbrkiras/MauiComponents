using MauiComponents.Models;

namespace MauiComponents.Components.Menus;

public partial class FlyoutMenu : ContentPage
{
    List<Menu> Menus = new List<Menu>();
    public FlyoutMenu()
    {
        InitializeComponent();
        initMenus();

    }
    void initMenus()
    {
        Menus.Add(new Menu() { Ad = "Ana Sayfa", Icon = "home.svg", Id = 1, SelectedBackgroundColor = Color.FromRgba(0, 0, 0, 1), TextColor = Color.FromHex("#1D5099") });
        Menus.Add(new Menu() { Ad = "Profil", Icon = "user.svg", Id = 2, SelectedBackgroundColor = Color.FromRgba(0, 0, 0, 1), TextColor = Color.FromHex("#1D5099") });
        Menus.Add(new Menu() { Ad = "Senkronizasyon", Icon = "sync.svg", Id = 3, SelectedBackgroundColor = Color.FromRgba(0, 0, 0, 1), TextColor = Color.FromHex("#1D5099") });
        Menus.Add(new Menu() { Ad = "Ayarlar", Icon = "setting.svg", Id = 4, SelectedBackgroundColor = Color.FromRgba(0, 0, 0, 1), TextColor = Color.FromHex("#1D5099") });
        Menus.Add(new Menu() { Ad = "Çýkýþ Yap", Icon = "signout.svg", Id = 5, SelectedBackgroundColor = Color.FromRgba(0, 0, 0, 1), TextColor = Color.FromHex("#1D5099")});
        collectionView.ItemsSource = Menus;
    }
   
}