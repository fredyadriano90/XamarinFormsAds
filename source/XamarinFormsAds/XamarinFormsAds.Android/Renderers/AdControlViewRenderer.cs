using Android.Content;
using Android.Gms.Ads;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using XamarinFormsAds.Controls;
using XamarinFormsAds.Droid.Renderers;

[assembly: Xamarin.Forms.ExportRenderer(typeof(AdControlView), typeof(AdControlViewRenderer))]
namespace XamarinFormsAds.Droid.Renderers
{
    public class AdControlViewRenderer : ViewRenderer<AdControlView, AdView>
    {
        private AdView _adView;

        public AdControlViewRenderer(Context context) : base(context)
        { }

        protected override void OnElementChanged(ElementChangedEventArgs<AdControlView> e)
        {
            base.OnElementChanged(e);

            if (Control == null && e.NewElement != null)
                SetNativeControl(CreateAdView());
        }

        private AdView CreateAdView()
        {
            if (_adView != null)
                return _adView;

            _adView = new AdView(Context)
            {
                AdUnitId = Element.AdUnitId,
                AdSize = AdSize.SmartBanner
            };

            _adView.LayoutParameters = new LinearLayout.LayoutParams(LayoutParams.WrapContent, LayoutParams.WrapContent);

            _adView.LoadAd(new AdRequest.Builder().Build());

            return _adView;
        }
    }
}