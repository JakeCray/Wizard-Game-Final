using UnityEngine;
using System.Collections;

public class roatte : MonoBehaviour {

	public GameObject button;

	public float time = 1f;

	public float t = 1f;

	private float final;

	private float rotateFinal;

	bool run;

	RectTransform rt;

	void Start()
	{
		final = time;
		t = time;
		button = gameObject;
		rt = button.GetComponent<RectTransform> ();
	}

	public void rotate(float rotate)
	{
		run = true;
		rotateFinal = rotate;
	}

	void Update()
	{
		if (run)
		{
			t -= Time.deltaTime;
			rt.Rotate (Vector3.up, rotateFinal * Time.deltaTime);

			if(t <= 0){
				time = final;
				run = false;
			}
		}
	}

}
