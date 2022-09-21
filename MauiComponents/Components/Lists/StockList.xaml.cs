using Microsoft.AspNetCore.Components;
using MauiComponents.Models;

namespace MauiComponents;

public partial class StockList : ListView
{
    public EventCallback<StockModel> OnEdit { get; set; }
    public EventCallback<StockModel> OnSurvey { get; set; }
    public StockList()
    {
        InitializeComponent();
    }
    async void OnEditInvoked(object sender, EventArgs e)
    {
        await OnEdit.InvokeAsync(sender as StockModel);
    }
    async void OnSurveyInvoked(object sender, EventArgs e)
    {
        await OnSurvey.InvokeAsync(sender as StockModel);
    }

}