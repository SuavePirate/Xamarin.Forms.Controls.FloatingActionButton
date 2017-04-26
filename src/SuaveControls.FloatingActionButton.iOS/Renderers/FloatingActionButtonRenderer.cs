using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using CoreGraphics;
using System.ComponentModel;
using SuaveControls.FloatingActionButton.iOS.Renderers;

[assembly: ExportRenderer(typeof(SuaveControls.Views.FloatingActionButton), typeof(FloatingActionButtonRenderer))]
namespace SuaveControls.FloatingActionButton.iOS.Renderers
{
    [Preserve]
    public class FloatingActionButtonRenderer : ButtonRenderer
    {
        public static void InitRenderer()
        {
        }
        public FloatingActionButtonRenderer()
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement == null)
                return;

            // remove text from button and set the width/height/radius
            Element.WidthRequest = 50;
            Element.HeightRequest = 50;
            Element.BorderRadius = 25;
            Element.BorderWidth = 0;
            Element.Text = null;

            // set background
            Control.BackgroundColor = ((SuaveControls.Views.FloatingActionButton)Element).ButtonColor.ToUIColor();
        }
        public override void Draw(CGRect rect)
        {
            base.Draw(rect);
            // add shadow
            Layer.ShadowRadius = 2.0f;
            Layer.ShadowColor = UIColor.Black.CGColor;
            Layer.ShadowOffset = new CGSize(1, 1);
            Layer.ShadowOpacity = 0.80f;
            Layer.ShadowPath = UIBezierPath.FromOval(Layer.Bounds).CGPath;
            Layer.MasksToBounds = false;

        }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == "ButtonColor")
            {
                Control.BackgroundColor = ((SuaveControls.Views.FloatingActionButton)Element).ButtonColor.ToUIColor();
            }
        }
    }
}