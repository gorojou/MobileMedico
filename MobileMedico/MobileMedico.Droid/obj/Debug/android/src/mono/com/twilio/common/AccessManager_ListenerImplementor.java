package mono.com.twilio.common;


public class AccessManager_ListenerImplementor
	extends java.lang.Object
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
		mono.android.Runtime.register ("Twilio.Common.AccessManager+IListenerImplementor, Twilio.Common.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AccessManager_ListenerImplementor.class, __md_methods);
	}


	public AccessManager_ListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == AccessManager_ListenerImplementor.class)
			mono.android.TypeManager.Activate ("Twilio.Common.AccessManager+IListenerImplementor, Twilio.Common.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
