using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Com.Davemorrissey.Labs.Subscaleview;

namespace SubsamplingScaleImageViewBinding.Sample
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);




            var source = ImageSource.ForResource(Resource.Drawable.swissroad);

            var imageView = FindViewById<SubsamplingScaleImageView>(Resource.Id.imageView);
            imageView.SetImage(source);
        }
    }
}

