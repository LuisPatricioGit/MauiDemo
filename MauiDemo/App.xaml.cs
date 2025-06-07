namespace MauiDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navPage = new NavigationPage(new MyPage());

            navPage.BarBackground = Colors.Red;
            navPage.BarTextColor = Colors.Blue;

            MainPage = new StackLayoutDemo();
        }

        //protected override Window CreateWindow(IActivationState? activationState)
        //{
        //    return new Window(new AppShell());
        //}
    }
}