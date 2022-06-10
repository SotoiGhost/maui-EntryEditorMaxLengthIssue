namespace EntryEditorMaxLengthIssue;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		txtEntry.Text = "1234567890";
		txtEditor.Text = "1234567890";
    }
}

