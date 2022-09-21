namespace MauiComponents;

public partial class NumericInput : Grid
{
    public NumericInput()
    {
        InitializeComponent();
    }
    void OnTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
    }
    void PlusOnClick(object sender, EventArgs e)
    {
        entry.Text = (Convert.ToInt32(entry.Text)+1).ToString();
    }
    void MinusOnClick(object sender, EventArgs e)
    {
        entry.Text = (Convert.ToInt32(entry.Text) - 1).ToString();
    }
}