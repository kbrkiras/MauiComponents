namespace MauiComponents;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Accordion : ContentView
{
    public static readonly BindableProperty IndicatorViewProperty = BindableProperty.Create(nameof(IndicatorView), typeof(View), typeof(Accordion), default(View));
    public View IndicatorView
    {
        get => (View)GetValue(IndicatorViewProperty);
        set => SetValue(IndicatorViewProperty, value);
    }

    public static readonly BindableProperty ContentViewProperty = BindableProperty.Create(nameof(AccordionContentView), typeof(View), typeof(Accordion), default(View));
    public View AccordionContentView
    {
        get => (View)GetValue(ContentViewProperty);
        set => SetValue(ContentViewProperty, value);
    }

    public static readonly BindableProperty TitleBindableProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(Accordion), default(string));
    public string Title
    {
        get => (string)GetValue(TitleBindableProperty);
        set => SetValue(TitleBindableProperty, value);
    }

    public static readonly BindableProperty IsOpenBindablePropertyProperty = BindableProperty.Create(nameof(IsOpen), typeof(bool), typeof(Accordion), false, propertyChanged: IsOpenChanged);
    public bool IsOpen
    {
        get { return (bool)GetValue(IsOpenBindablePropertyProperty); }
        set { SetValue(IsOpenBindablePropertyProperty, value); }
    }

    public static BindableProperty HeaderBackgroundColorProperty = BindableProperty.Create(nameof(HeaderBackgroundColor), typeof(Color), typeof(Accordion), Color.FromRgba(0, 0, 0, 1));
    public Color HeaderBackgroundColor
    {
        get { return (Color)GetValue(HeaderBackgroundColorProperty); }
        set { SetValue(HeaderBackgroundColorProperty, value); }
    }

    private static void IsOpenChanged(BindableObject bindable, object oldValue, object newValue)
    {

        bool isOpen;

        if (bindable != null && newValue != null)
        {
            var control = (Accordion)bindable;
            isOpen = (bool)newValue;

            if (control.IsOpen == false)
            {
                VisualStateManager.GoToState(control, "Open");
                control.Close();
            }
            else
            {
                VisualStateManager.GoToState(control, "Closed");

                control.Open();
            }
        }
    }

    public uint AnimationDuration { get; set; }

    public Accordion()
    {
        InitializeComponent();
        Close();
        AnimationDuration = 250;
        IsOpen = false;
    }

    async void Close()
    {
        _accordion_view.BackgroundColor = Colors.LightGray;
        // HeaderBackgroundColorProperty = BindableProperty.Create(nameof(HeaderBackgroundColor), typeof(Color), typeof(Accordion), Color.FromRgba(0, 0, 0, 1));
        await Task.WhenAll(
            this._accContent.TranslateTo(0, -10, AnimationDuration),
            _indicatorContainer.RotateTo(-180, AnimationDuration),
            _accContent.FadeTo(0, 50)
            );
        _accContent.IsVisible = false;
    }

    async void Open()
    {
        _accContent.IsVisible = true;
        //_accordion_view.BackgroundColor = Color.FromRgba(140, 63, 93, 0.6);
        _accordion_view.BackgroundColor = Colors.MediumPurple;


        await Task.WhenAll(
           _accContent.TranslateTo(0, 10, AnimationDuration),
           _indicatorContainer.RotateTo(0, AnimationDuration),
           _accContent.FadeTo(30, 50, Easing.SinIn)
       );
    }

    private void TitleTapped(object sender, EventArgs e)
    {
        IsOpen = !IsOpen;
    }
}