package md51deaf69f6bbd9131d9a0967158ffc568;


public class EditTutorProfileA
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
		mono.android.Runtime.register ("Pass_App.EditTutorProfileA, PASS App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", EditTutorProfileA.class, __md_methods);
	}


	public EditTutorProfileA () throws java.lang.Throwable
	{
		super ();
		if (getClass () == EditTutorProfileA.class)
			mono.android.TypeManager.Activate ("Pass_App.EditTutorProfileA, PASS App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
