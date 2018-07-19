using Android.App;
using Android.Widget;
using Android.OS;

namespace Wk1
{
    [Activity(Label = "Wk1", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
       // int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            ImageView img = FindViewById<ImageView>(Resource.Id.myImage);

            var imgSwitch = true;
            img.Click += delegate {
                if (imgSwitch){
                    int resourceId = (int)typeof(Resource.Drawable).GetField("light_off").GetValue(null);
                    img.SetImageResource(resourceId);
                    imgSwitch = false;
                }
                else{
                    int resourceId = (int)typeof(Resource.Drawable).GetField("light_on").GetValue(null);
                    img.SetImageResource(resourceId);
                    imgSwitch = true;
                }
            };
        }
    }
}

