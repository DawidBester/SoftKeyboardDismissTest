namespace SoftKeyboardDismissTest
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }


        
        private async void Button_OnClicked(object? sender, EventArgs e)
        {
            Test3Entry.Focus();
            Test3Entry.Text = "Keyboard Focus set";
            await Task.Delay(TimeSpan.FromSeconds(1));
            Test3Entry.Unfocus();
        }
    }

}
