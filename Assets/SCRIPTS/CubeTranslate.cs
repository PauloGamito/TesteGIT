using UnityEngine;
using System.Collections;

public class CubeTranslate : MonoBehaviour 
{

	//PUBLIC

	public float lerpFactor;
	public float destination = 5;
	public float startPosX = 0;
	public float endPosX = 5;

	//PRIVATE

	private Vector3 currentPosition = new Vector3();

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		lerpFactor += Time.deltaTime;
		if (transform.position.x != destination) 
		{
			currentPosition.x = Mathf.Lerp (currentPosition.x, destination, lerpFactor);
			transform.position = currentPosition;
		}


		else
		{
			if (transform.position.x == startPosX)
				destination = endPosX;
			else 
				destination = startPosX;
			lerpFactor = 0;
		}
	}
}
