package mono.com.twilio.ipmessaging;


public class IPMessagingClientListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.twilio.ipmessaging.IPMessagingClientListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onChannelAdd:(Lcom/twilio/ipmessaging/Channel;)V:GetOnChannelAdd_Lcom_twilio_ipmessaging_Channel_Handler:Twilio.IPMessaging.IPMessagingClientListenerInvoker, Twilio.IPMessaging.Android\n" +
			"n_onChannelChange:(Lcom/twilio/ipmessaging/Channel;)V:GetOnChannelChange_Lcom_twilio_ipmessaging_Channel_Handler:Twilio.IPMessaging.IPMessagingClientListenerInvoker, Twilio.IPMessaging.Android\n" +
			"n_onChannelDelete:(Lcom/twilio/ipmessaging/Channel;)V:GetOnChannelDelete_Lcom_twilio_ipmessaging_Channel_Handler:Twilio.IPMessaging.IPMessagingClientListenerInvoker, Twilio.IPMessaging.Android\n" +
			"n_onChannelSynchronizationChange:(Lcom/twilio/ipmessaging/Channel;)V:GetOnChannelSynchronizationChange_Lcom_twilio_ipmessaging_Channel_Handler:Twilio.IPMessaging.IPMessagingClientListenerInvoker, Twilio.IPMessaging.Android\n" +
			"n_onClientSynchronization:(Lcom/twilio/ipmessaging/IPMessagingClient$SynchronizationStatus;)V:GetOnClientSynchronization_Lcom_twilio_ipmessaging_IPMessagingClient_SynchronizationStatus_Handler:Twilio.IPMessaging.IPMessagingClientListenerInvoker, Twilio.IPMessaging.Android\n" +
			"n_onError:(Lcom/twilio/ipmessaging/ErrorInfo;)V:GetOnError_Lcom_twilio_ipmessaging_ErrorInfo_Handler:Twilio.IPMessaging.IPMessagingClientListenerInvoker, Twilio.IPMessaging.Android\n" +
			"n_onToastFailed:(Lcom/twilio/ipmessaging/ErrorInfo;)V:GetOnToastFailed_Lcom_twilio_ipmessaging_ErrorInfo_Handler:Twilio.IPMessaging.IPMessagingClientListenerInvoker, Twilio.IPMessaging.Android\n" +
			"n_onToastNotification:(Ljava/lang/String;Ljava/lang/String;)V:GetOnToastNotification_Ljava_lang_String_Ljava_lang_String_Handler:Twilio.IPMessaging.IPMessagingClientListenerInvoker, Twilio.IPMessaging.Android\n" +
			"n_onToastSubscribed:()V:GetOnToastSubscribedHandler:Twilio.IPMessaging.IPMessagingClientListenerInvoker, Twilio.IPMessaging.Android\n" +
			"n_onUserInfoChange:(Lcom/twilio/ipmessaging/UserInfo;)V:GetOnUserInfoChange_Lcom_twilio_ipmessaging_UserInfo_Handler:Twilio.IPMessaging.IPMessagingClientListenerInvoker, Twilio.IPMessaging.Android\n" +
			"";
		mono.android.Runtime.register ("Twilio.IPMessaging.IPMessagingClientListenerImplementor, Twilio.IPMessaging.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", IPMessagingClientListenerImplementor.class, __md_methods);
	}


	public IPMessagingClientListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == IPMessagingClientListenerImplementor.class)
			mono.android.TypeManager.Activate ("Twilio.IPMessaging.IPMessagingClientListenerImplementor, Twilio.IPMessaging.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onChannelAdd (com.twilio.ipmessaging.Channel p0)
	{
		n_onChannelAdd (p0);
	}

	private native void n_onChannelAdd (com.twilio.ipmessaging.Channel p0);


	public void onChannelChange (com.twilio.ipmessaging.Channel p0)
	{
		n_onChannelChange (p0);
	}

	private native void n_onChannelChange (com.twilio.ipmessaging.Channel p0);


	public void onChannelDelete (com.twilio.ipmessaging.Channel p0)
	{
		n_onChannelDelete (p0);
	}

	private native void n_onChannelDelete (com.twilio.ipmessaging.Channel p0);


	public void onChannelSynchronizationChange (com.twilio.ipmessaging.Channel p0)
	{
		n_onChannelSynchronizationChange (p0);
	}

	private native void n_onChannelSynchronizationChange (com.twilio.ipmessaging.Channel p0);


	public void onClientSynchronization (com.twilio.ipmessaging.IPMessagingClient.SynchronizationStatus p0)
	{
		n_onClientSynchronization (p0);
	}

	private native void n_onClientSynchronization (com.twilio.ipmessaging.IPMessagingClient.SynchronizationStatus p0);


	public void onError (com.twilio.ipmessaging.ErrorInfo p0)
	{
		n_onError (p0);
	}

	private native void n_onError (com.twilio.ipmessaging.ErrorInfo p0);


	public void onToastFailed (com.twilio.ipmessaging.ErrorInfo p0)
	{
		n_onToastFailed (p0);
	}

	private native void n_onToastFailed (com.twilio.ipmessaging.ErrorInfo p0);


	public void onToastNotification (java.lang.String p0, java.lang.String p1)
	{
		n_onToastNotification (p0, p1);
	}

	private native void n_onToastNotification (java.lang.String p0, java.lang.String p1);


	public void onToastSubscribed ()
	{
		n_onToastSubscribed ();
	}

	private native void n_onToastSubscribed ();


	public void onUserInfoChange (com.twilio.ipmessaging.UserInfo p0)
	{
		n_onUserInfoChange (p0);
	}

	private native void n_onUserInfoChange (com.twilio.ipmessaging.UserInfo p0);

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
