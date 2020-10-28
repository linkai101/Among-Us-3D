using UnityEngine;
using System.Collections;
 
public class FPSDisplay : MonoBehaviour
{
	float deltaTime = 0.0f;
 
	void Update()
	{
		deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
	}
 
	void OnGUI()
	{
		int w = Screen.width, h = Screen.height;
 
		GUIStyle style = new GUIStyle();
 
		Rect rect = new Rect(0, 0, w, h * 2 / 100);
		style.alignment = TextAnchor.UpperRight;
		style.fontSize = h * 2 / 100;
		style.normal.textColor = new Color (1.0f, 1.0f, 1.0f, 1.0f);
		float msec = deltaTime * 1000.0f;
		float fps = 1.0f / deltaTime;
		string text = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps);
		GUI.Label(rect, text, style);


		GUIStyle style2 = new GUIStyle();
		Rect rect2 = new Rect(0, 0, w, h * 2 / 100);
		style2.alignment = TextAnchor.UpperLeft;
		style2.fontSize = h * 2 / 100;
		style2.normal.textColor = new Color (1.0f, 1.0f, 1.0f, 1.0f);
		string text2 = string.Format("v0.0.2alpha");
		GUI.Label(rect2, text2, style2);
    }

}