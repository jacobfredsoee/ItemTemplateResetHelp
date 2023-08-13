namespace ItemTemplateReset.View;

public partial class MainPage : ContentPage
{
	MainPageViewModel viewModel;
	public MainPage(MainPageViewModel viewModel)
	{
		InitializeComponent(); 
		BindingContext = viewModel;
        this.viewModel = viewModel;
    }

	private void OnResetClicked(object sender, EventArgs e) {
        //How to reset the radio buttons so that none is selected?
        viewModel.SelectedRole = -1; //This does not work
    }

    private void OnRoleChange(object sender, CheckedChangedEventArgs e) {
        RadioButton rb = sender as RadioButton;
        viewModel.SelectedRole = int.Parse(rb.Value.ToString());
    }
}

