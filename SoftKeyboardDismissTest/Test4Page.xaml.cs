using System.Diagnostics;
using System.Windows.Input;

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
            
            Button_OnClicked(sender, null);
        });
	}

    private void Button_OnClicked(object? sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}