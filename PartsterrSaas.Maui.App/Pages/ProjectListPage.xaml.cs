namespace PartsterrSaas.Maui.App.Pages;

public partial class ProjectListPage : ContentPage
{
    public ProjectListPage(ProjectListPageModel model)
    {
        BindingContext = model;
        InitializeComponent();
    }
}