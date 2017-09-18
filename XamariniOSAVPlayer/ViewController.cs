using System;

using UIKit;
using AVFoundation;
using Foundation;

namespace XamariniOSAVPlayer
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		AVPlayer avplayer;
		AVPlayerLayer avplayerLayer;
		AVAsset avasset;
		AVPlayerItem avplayerItem;

		partial void BtnPlay_TouchUpInside(UIButton sender)
		{

			avasset = AVAsset.FromUrl(NSUrl.FromFilename("video.mp4"));
			avplayerItem = new AVPlayerItem(avasset);
			avplayer = new AVPlayer(avplayerItem);
			avplayerLayer = AVPlayerLayer.FromPlayer(avplayer);
			avplayerLayer.Frame = View.Frame;
			View.Layer.AddSublayer(avplayerLayer);
			avplayer.Play();

		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
