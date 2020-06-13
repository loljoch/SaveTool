using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EditorDraggableObject
{
    public void OnGUI()
    {
		Rect drawRect = new Rect(20, 20, 100, 100);

		GUIStyle style = new GUIStyle();
		GUIStyleState gUIStyleState = new GUIStyleState();
		Texture2D bg = new Texture2D(1, 1);
		bg.SetPixel(1, 1, Color.red);
		bg.wrapMode = TextureWrapMode.Repeat;
		bg.Apply();
		gUIStyleState.background = bg;
		style.normal = gUIStyleState;

		GUILayout.BeginArea(drawRect);
		GUILayout.Label("Yeet\nBelow yeet", style, GUILayout.ExpandWidth(true));
		GUILayout.EndArea();
	}

	private void OnMouseEnter()
    {
        Debug.Log("Mouse entered me");
    }
}
