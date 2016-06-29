using System;

public class Class1
{
	public Class1()
	{
        public enum LabelIcon
    {
        Gray = 0,
        Blue,
        Teal,
        Green,
        Yellow,
        Orange,
        Red,
        Purple,
        None
    }

    public static void AddTargetIcon(GameObject g, LabelIcon icon)
    {
        Texture2D tex = EditorGUIUtility.IconContent("sv_label_" + (int)icon).image as Texture2D;
        Type editorGUIUtilityType = typeof(EditorGUIUtility);
        BindingFlags bindingFlags = BindingFlags.InvokeMethod | BindingFlags.Static | BindingFlags.NonPublic;
        object[] args = new object[] { g, tex };
        editorGUIUtilityType.InvokeMember("SetIconForObject", bindingFlags, null, null, args);
    }
}
}
