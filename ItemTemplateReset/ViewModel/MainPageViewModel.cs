namespace ItemTemplateReset.ViewModel;

public partial class MainPageViewModel : ObservableObject
{
    public ObservableCollection<PickableRole> PickableRoles { get; set; } = new();

    [ObservableProperty]
    public int selectedRole = -1;

    public MainPageViewModel() {
        SetPickableRoles();
    }

    private void SetPickableRoles() {
        PickableRoles.Add(new PickableRole() { Id = 1, Name = "Role 1"} );
        PickableRoles.Add(new PickableRole() { Id = 2, Name = "Role 2" });
        PickableRoles.Add(new PickableRole() { Id = 3, Name = "Role 3" });
        PickableRoles.Add(new PickableRole() { Id = 4, Name = "Role 4" });
        PickableRoles.Add(new PickableRole() { Id = 5, Name = "Role 5" });
    }
}
