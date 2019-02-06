package mono.com.twilio.ipmessaging;


public class ChannelListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.twilio.ipmessaging.ChannelListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAttributesChange:(Ljava/util/Map;)V:GetOnAttributesChange_Ljava_util_Map_Handler:Twilio.IPMessaging.IChannelListenerInvoker, Twilio.IPMessaging.Android\n" +
			"n_onMemberChange:(Lcom/twilio/ipmessaging/Member;)V:GetOnMemberChange_Lcom_twilio_ipmessaging_Member_Handler:Twilio.IPMessaging.IChannelListenerInvoker, Twilio.IPMessaging.Android\n" +
			"n_onMemberDelete:(Lcom/twilio/ipmessaging/Member;)V:GetOnMemberDelete_Lcom_twilio_ipmessaging_Member_Handler:Twilio.IPMessaging.IChannelListenerInvoker, Twilio.IPMessaging.Android\n" +
			"n_onMemberJoin:(Lcom/twilio/ipmessaging/Member;)V:GetOnMemberJoin_Lcom_twilio_ipmessaging_Member_Handler:Twilio.IPMessaging.IChannelListenerInvoker, Twilio.IPMessaging.Android\n" +
			"n_onMessageAdd:(Lcom/twilio/ipmessaging/Message;)V:GetOnMessageAdd_Lcom_twilio_ipmessaging_Message_Handler:Twilio.IPMessaging.IChannelListenerInvoker, Twilio.IPMessaging.Android\n" +
			"n_onMessageChange:(Lcom/twilio/ipmessaging/Message;)V:GetOnMessageChange_Lcom_twilio_ipmessaging_Message_Handler:Twilio.IPMessaging.IChannelListenerInvoker, Twilio.IPMessaging.Android\n" +
			"n_onMessageDelete:(Lcom/twilio/ipmessaging/Message;)V:GetOnMessageDelete_Lcom_twilio_ipmessaging_Message_Handler:Twilio.IPMessaging.IChannelListenerInvoker, Twilio.IPMessaging.Android\n" +
			"n_onSynchronizationChange:(Lcom/twilio/ipmessaging/Channel;)V:GetOnSynchronizationChange_Lcom_twilio_ipmessaging_Channel_Handler:Twilio.IPMessaging.IChannelListenerInvoker, Twilio.IPMessaging.Android\n" +
			"n_onTypingEnded:(Lcom/twilio/ipmessaging/Member;)V:GetOnTypingEnded_Lcom_twilio_ipmessaging_Member_Handler:Twilio.IPMessaging.IChannelListenerInvoker, Twilio.IPMessaging.Android\n" +
			"n_onTypingStarted:(Lcom/twilio/ipmessaging/Member;)V:GetOnTypingStarted_Lcom_twilio_ipmessaging_Member_Handler:Twilio.IPMessaging.IChannelListenerInvoker, Twilio.IPMessaging.Android\n" +
			"";
		mono.android.Runtime.register ("Twilio.IPMessaging.IChannelListenerImplementor, Twilio.IPMessaging.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ChannelListenerImplementor.class, __md_methods);
	}


	public ChannelListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ChannelListenerImplementor.class)
			mono.android.TypeManager.Activate ("Twilio.IPMessaging.IChannelListenerImplementor, Twilio.IPMessaging.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onAttributesChange (java.util.Map p0)
	{
		n_onAttributesChange (p0);
	}

	private native void n_onAttributesChange (java.util.Map p0);


	public void onMemberChange (com.twilio.ipmessaging.Member p0)
	{
		n_onMemberChange (p0);
	}

	private native void n_onMemberChange (com.twilio.ipmessaging.Member p0);


	public void onMemberDelete (com.twilio.ipmessaging.Member p0)
	{
		n_onMemberDelete (p0);
	}

	private native void n_onMemberDelete (com.twilio.ipmessaging.Member p0);


	public void onMemberJoin (com.twilio.ipmessaging.Member p0)
	{
		n_onMemberJoin (p0);
	}

	private native void n_onMemberJoin (com.twilio.ipmessaging.Member p0);


	public void onMessageAdd (com.twilio.ipmessaging.Message p0)
	{
		n_onMessageAdd (p0);
	}

	private native void n_onMessageAdd (com.twilio.ipmessaging.Message p0);


	public void onMessageChange (com.twilio.ipmessaging.Message p0)
	{
		n_onMessageChange (p0);
	}

	private native void n_onMessageChange (com.twilio.ipmessaging.Message p0);


	public void onMessageDelete (com.twilio.ipmessaging.Message p0)
	{
		n_onMessageDelete (p0);
	}

	private native void n_onMessageDelete (com.twilio.ipmessaging.Message p0);


	public void onSynchronizationChange (com.twilio.ipmessaging.Channel p0)
	{
		n_onSynchronizationChange (p0);
	}

	private native void n_onSynchronizationChange (com.twilio.ipmessaging.Channel p0);


	public void onTypingEnded (com.twilio.ipmessaging.Member p0)
	{
		n_onTypingEnded (p0);
	}

	private native void n_onTypingEnded (com.twilio.ipmessaging.Member p0);


	public void onTypingStarted (com.twilio.ipmessaging.Member p0)
	{
		n_onTypingStarted (p0);
	}

	private native void n_onTypingStarted (com.twilio.ipmessaging.Member p0);

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
