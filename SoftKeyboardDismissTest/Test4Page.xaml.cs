using System.Diagnostics;
using System.Windows.Input;
using CommunityToolkit.Maui.Core.Platform;

namespace SoftKeyboardDismissTest;

public partial class Test4Page : ContentPage
{
   
    private ICommand _leftButtonClickCommand;

    public ICommand LeftButtonCommand
    {
        get { return _leftButtonClickCommand; }
        set
        {
            _leftButtonClickCommand = value;
            OnPropertyChanged();
        }
    }

	public Test4Page()
	{
		InitializeComponent();

        LeftButtonCommand = new Command((sender) =>
        {
            Debug.WriteLine("LeftButtonCommand executed");
            
            LeftButton_OnClicked(sender, null);
        });
	}

    private void LeftButton_OnClicked(object? sender, EventArgs e)
    {

        // Workaround Reference
        // https://stackoverflow.com/questions/73649236/how-do-you-find-the-newly-focused-element-in-net-maui-used-inside-unfocused-ev
        // https://stackoverflow.com/questions/73199602/need-a-way-to-hide-soft-keyboard-in-mauis-editor-entry-fields

        //var views = PageVerticalStackLayout.Children; 

        //foreach (var view1 in views)
        //{
        //    var view = (View)view1;

        //    if (view != null && view.IsFocused)
        //    {
        //        Debug.WriteLine("view focused is : " + view);

        //        if (view is Entry entry)
        //        { 
        //            entry.HideKeyboardAsync(CancellationToken.None);
        //        }
        //    }
        //}
        //Trick To Hide VirtualKeyboard
        // SomeEntry.IsEnabled = false;
       // SomeEntry.IsEnabled = true;
        
        Navigation.PopAsync();
    }

    private void Test4Entry_OnUnfocused(object? sender, FocusEventArgs e)
    {
        DismissEntryKeyboard(sender);
    }

    public async void DismissEntryKeyboard(object? sender)
    {
        if (sender is ITextInput textInput)
        {
            Debug.WriteLine("Test4Entry_OnUnfocused");
            await textInput.HideKeyboardAsync(CancellationToken.None);
        }
    }
}