using System.Windows.Input;

namespace SoftKeyboardDismissTest.Controls;

//[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class PageHeader : ContentView
{
    public PageHeader()
    {
        InitializeComponent();
        
        //HideSoftInputOnTapped
    }
    
    public static readonly BindableProperty LeftButtonGridIsVisibleProperty = BindableProperty.Create(
        "LeftButtonGridIsVisible",
        typeof(bool),
        typeof(Grid),
        true);
    
    public bool LeftButtonGridIsVisible
    {
        get => (bool)GetValue(LeftButtonGridIsVisibleProperty);
        set => SetValue(LeftButtonGridIsVisibleProperty, value);
    }

    public static readonly BindableProperty PageTitleTextProperty = BindableProperty.Create(
        "PageTitleText",        // the name of the bindable property
        typeof(string),     // the bindable property type
        typeof(PageHeader),   // the parent object type
        string.Empty);      // the default value for the property


    public string PageTitleText
    {
        get => (string)GetValue(PageTitleTextProperty);
        set => SetValue(PageTitleTextProperty, value);
    }
    
   
    public static readonly BindableProperty LeftButtonIconProperty = BindableProperty.Create(
        "LeftButtonIcon",        // the name of the bindable property
        typeof(string),     // the bindable property type
        typeof(PageHeader),   // the parent object type
        string.Empty);      // the default value for the property


    public string LeftButtonIcon
    {
        get => (string)GetValue(LeftButtonIconProperty);
        set => SetValue(LeftButtonIconProperty, value);
    }
    
    public static readonly BindableProperty LeftButtonIconFontFamilyProperty = BindableProperty.Create(
        "LeftButtonIconFontFamily",        // the name of the bindable property
        typeof(string),     // the bindable property type
        typeof(PageHeader),   // the parent object type
        string.Empty);      // the default value for the property


    public string LeftButtonIconFontFamily
    {
        get => (string)GetValue(LeftButtonIconFontFamilyProperty);
        set => SetValue(LeftButtonIconFontFamilyProperty, value);
    }

    public static readonly BindableProperty LeftButtonIconTextProperty = BindableProperty.Create(
        "LeftButtonIconText",        // the name of the bindable property
        typeof(string),     // the bindable property type
        typeof(PageHeader),   // the parent object type
        string.Empty);      // the default value for the property


    public string LeftButtonIconText
    {
        get => (string)GetValue(LeftButtonIconTextProperty);
        set => SetValue(LeftButtonIconTextProperty, value);
    }

    public static readonly BindableProperty LeftButtonTappedCommandProperty =
        BindableProperty.Create(
            propertyName: nameof(LeftButtonTappedCommand),
            returnType: typeof(ICommand),
            declaringType: typeof(PageHeader),
            defaultValue: default(ICommand),
            propertyChanged: OnLeftButtonTapCommandPropertyChanged);

    static void OnLeftButtonTapCommandPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is PageHeader headerTemplate && newValue is ICommand command)
        {
            headerTemplate.LeftButtonTappedCommand = command;
        }
    }

    public ICommand LeftButtonTappedCommand
    {
        get => (ICommand)GetValue(LeftButtonTappedCommandProperty);
        set => SetValue(LeftButtonTappedCommandProperty, value);
    }
    
    

    
}