using HelloWear.Handlers;

namespace HelloWear
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            // Create handler factories with the current activity instance
            var incrementClickHandler = Factories.ClickHanlderFactory.CreateIncrementClickHandlerFactory(this);
            incrementClickHandler.Initialize();
        }
    }
}