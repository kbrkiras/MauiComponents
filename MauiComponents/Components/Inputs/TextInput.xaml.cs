using MauiComponents.Models;

namespace MauiComponents;

public partial class TextInput : Grid
{
    public static BindableProperty UnderlineThicknessProperty = BindableProperty.Create(
          nameof(UnderlineThickness), typeof(int), typeof(TextInput), 0);
    public int UnderlineThickness
    {
        get => (int)GetValue(UnderlineThicknessProperty);
        set => SetValue(UnderlineThicknessProperty, value);
    }
    public TextInput()
    {
        InitializeComponent();
    }
    void OnTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        if (newText.Length > 0 || (newText.Length == 0 && ((EntryModel)gridEntry.BindingContext).ShowIconWhenEmpty == true))
        {
            imgEntry.IsVisible = true;
        }
        else
        {
            imgEntry.IsVisible = false;
        }
    }
    void ImgOnClick(object sender, EventArgs e)
    {
        if (imgEntry.Source.ToString().Contains("eye"))
        {
            this.entry.IsPassword = !entry.IsPassword;
            this.imgEntry.Source = entry.IsPassword ? "eye_slash.svg" : "eye.svg";
        }
    }
}