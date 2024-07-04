
namespace MauiApp1;

public partial class DeviceHmi
{
    public static readonly BindableProperty IsDisabledProperty = BindableProperty.Create(nameof(IsDisabled), typeof(bool), typeof(DeviceHmi), propertyChanged: InnerProperyChanged);
    public bool IsDisabled
    {
        get => (bool)GetValue(IsDisabledProperty);
        set => SetValue(IsDisabledProperty, value);
    }
    
    public static readonly BindableProperty ImgSrcProperty = BindableProperty.Create(nameof(ImgSrc), typeof(string), typeof(DeviceHmi));
    public string ImgSrc
    {
        get => (string)GetValue(ImgSrcProperty);
        set => SetValue(ImgSrcProperty, value);
    }
    
    public static readonly BindableProperty LabelButtonProperty = BindableProperty.Create(nameof(LabelButton), typeof(string), typeof(DeviceHmi));
    public string LabelButton
    {
        get => (string)GetValue(LabelButtonProperty);
        set => SetValue(LabelButtonProperty, value);
    }
    
    public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(DeviceHmi));
    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }
    
    public static readonly BindableProperty ValueProperty = BindableProperty.Create(nameof(Value), typeof(string), typeof(DeviceHmi));
    public string Value
    {
        get => (string)GetValue(ValueProperty);
        set => SetValue(ValueProperty, value);
    }

    public static readonly BindableProperty SetEmptyWhenProperty = BindableProperty.Create(nameof(SetEmptyWhen), typeof(bool), typeof(DeviceHmi), propertyChanged: InnerProperyChanged);
    public bool SetEmptyWhen
    {
        get => (bool)GetValue(SetEmptyWhenProperty);
        set => SetValue(SetEmptyWhenProperty, value);
    }

    private static void InnerProperyChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
        var control = (DeviceHmi)bindable;
    }

    public static readonly BindableProperty IconLabelColorProperty = BindableProperty.Create(nameof(IconLabelColor), typeof(Color), typeof(DeviceHmi), defaultValue: Colors.AliceBlue);
    public Color IconLabelColor
    {
        get => (Color)GetValue(IconLabelColorProperty);
        set => SetValue(IconLabelColorProperty, value);
    }


    public DeviceHmi()
    {
        InitializeComponent();
    }

}