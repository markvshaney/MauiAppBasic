
using Android.App;
using Android.Content;
using Android.Telephony;
using Android.Util;
using MauiAppBasic.Services;


namespace MauiBasicApp.Platforms.Android.AndroidServices
{
    [BroadcastReceiver(Enabled = true, Exported = true)]
    [IntentFilter(new[] { "android.intent.action.PHONE_STATE" })]
    public class PhoneCallReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            if (intent.Action == "android.intent.action.PHONE_STATE")
            {
                string state = intent.GetStringExtra(TelephonyManager.ExtraState);

                if (state == TelephonyManager.ExtraStateRinging)
                {
                    string incomingNumber = intent.GetStringExtra(TelephonyManager.ExtraIncomingNumber);
                    Log.Debug("PhoneCallReceiver", "Incoming call from: " + incomingNumber);

                    // You can handle the incoming call here
                }
            }
        }
    }
}