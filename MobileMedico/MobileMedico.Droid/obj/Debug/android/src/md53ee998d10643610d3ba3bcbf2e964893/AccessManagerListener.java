package md53ee998d10643610d3ba3bcbf2e964893;


public class AccessManagerListener
	extends com.twilio.common.AccessManager
	implements
		mono.android.IGCUserPeer,
		com.twilio.common.AccessManager.Listener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onError:(Lcom/twilio/common/AccessManager;Ljava/lang/String;)V:GetOnError_Lcom_twilio_common_AccessManager_Ljava_lang_String_Handler:Twilio.Common.AccessManager/IListenerInvoker, Twilio.Common.Android\n" +
			"n_onTokenExpired:(Lcom/twilio/common/AccessManager;)V:GetOnTokenExpired_Lcom_twilio_common_AccessManager_Handler:Twilio.Common.AccessManager/IListenerInvoker, Twilio.Common.Android\n" +
			"n_onTokenUpdated:(Lcom/twilio/common/AccessManager;)V:GetOnTokenUpdated_Lcom_twilio_common_AccessManager_Handler:Twilio.Common.AccessManager/IListenerInvoker, Twilio.Common.Android\n" +
			"";
		mono.android.Runtime.register ("Twilio.Common.AccessManagerListener, Twilio.Common.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AccessManagerListener.class, __md_methods);
	}


	public AccessManagerListener (android.content.Context p0, java.lang.String p1, com.twilio.common.AccessManager.Listener p2) throws java.lang.Throwable
	{
		super (p0, p1, p2);
		if (getClass () == AccessManagerListener.class)
			mono.android.TypeManager.Activate ("Twilio.Common.AccessManagerListener, Twilio.Common.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.String, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:Twilio.Common.AccessManager+IListener, Twilio.Common.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public void onError (com.twilio.common.AccessManager p0, java.lang.String p1)
	{
		n_onError (p0, p1);
	}

	private native void n_onError (com.twilio.common.AccessManager p0, java.lang.String p1);


	public void onTokenExpired (com.twilio.common.AccessManager p0)
	{
		n_onTokenExpired (p0);
	}

	private native void n_onTokenExpired (com.twilio.common.AccessManager p0);


	public void onTokenUpdated (com.twilio.common.AccessManager p0)
	{
		n_onTokenUpdated (p0);
	}

	private native void n_onTokenUpdated (com.twilio.common.AccessManager p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
