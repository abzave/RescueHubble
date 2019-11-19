using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class RotarObjetoConSwipes:MonoBehaviour
{
	Vector2 firstPressPos;
	Vector2 secondPressPos;
	Vector2 currentSwipe;
	private float anteriorX = 0;
	private float anteriorY = 0;

	public void FixedUpdate()
	{
		if(Input.touches.Length > 0)
		{
			Touch t = Input.GetTouch(0);
			if(t.phase == TouchPhase.Began){
				anteriorX = t.position.x;
				anteriorY = t.position.y;
			}
			if(t.phase == TouchPhase.Moved)
			{
				//save began touch 2d point
				transform.Rotate( new Vector2((t.position.y-anteriorY)*-0.05f,(t.position.x-anteriorX)*0.05f));
				anteriorX = t.position.x;
				anteriorY = t.position.y;
			}

		}
	}

}