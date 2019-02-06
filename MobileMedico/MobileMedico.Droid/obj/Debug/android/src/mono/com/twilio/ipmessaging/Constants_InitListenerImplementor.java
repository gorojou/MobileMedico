package mono.com.twilio.ipmessaging;


public class Constants_InitListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.twilio.ipmessaging.Constants.InitListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onError:(Ljava/lang/Exception;)V:GetOnError_Ljava_lang_Exception_Handler:Twilio.IPMessaging.IConstantsInitListenerInvoker, Twilio.IPMessaging.Android\n" +
			"n_onInitialized:()V:GetOnInitializedHandler:Twilio.IPMessaging.IConstantsInitListenerInvoker, Twilio.IPMessaging.Android\n" +
			"";
		mono.android.Runtime.register ("Twilio.IPMessaging.IConstantsInitListenerImplementor, Twilio.IPMessaging.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Constants_InitListenerImplementor.class, __md_methods);
	}


	public Constants_InitListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Constants_InitListenerImplementor.class)
			mono.android.TypeManager.Activate ("Twilio.IPMessaging.IConstantsInitListenerImplementor, Twilio.IPMessaging.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onError (java.lang.Exception p0)
	{
		n_onError (p0);
	}

	private native void n_onError (java.lang.Exception p0);


	public void onInitialized ()
	{
		n_onInitialized ();
	}

	private native void n_onInitialized ();

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
