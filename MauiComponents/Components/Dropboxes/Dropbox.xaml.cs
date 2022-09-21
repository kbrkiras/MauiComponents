using Microsoft.AspNetCore.Components;

namespace MauiComponents;

public partial class Dropbox : Grid
{
    public EventCallback<string> OnSelectedIndexChanged { get; set; }
    public Dropbox()
    {
        InitializeComponent();
    }
    protected void SelectedIndexChanged(object sender, EventArgs e)
    {
        OnSelectedIndexChanged.InvokeAsync();
    }
}