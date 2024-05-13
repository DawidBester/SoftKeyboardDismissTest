using System.Diagnostics;
using CommunityToolkit.Maui.Core.Platform;

namespace SoftKeyboardDismissTest
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }


        
        private async void Test3SetFocusAndUnfocusButton_OnClicked(object? sender, EventArgs e)
        {
            Test3Entry.Focus();
            Test3Entry.Text = "Keyboard Focus set";
            await Task.Delay(TimeSpan.FromSeconds(1));
            Test3Entry.Unfocus();
        }

        private void ButtonNavigation_OnClicked(object? sender, EventArgs e)
        {
            Navigation.PushAsync(new Test4Page());
        }

        private void Test3Entry_OnUnfocused(object? sender, FocusEventArgs e)
        {
            DismissEntryKeyboard(sender);
        }

        private void Test2Entry_OnUnfocused(object? sender, FocusEventArgs e)
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



}
