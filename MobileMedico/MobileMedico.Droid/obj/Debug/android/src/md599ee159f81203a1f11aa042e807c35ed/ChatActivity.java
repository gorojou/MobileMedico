package md599ee159f81203a1f11aa042e807c35ed;


public class ChatActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("MobileMedico.Droid.ChatActivity, MobileMedico.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ChatActivity.class, __md_methods);
	}


	public ChatActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ChatActivity.class)
			mono.android.TypeManager.Activate ("MobileMedico.Droid.ChatActivity, MobileMedico.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
