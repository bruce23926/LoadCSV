using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordData : MonoBehaviour {

	// Use this for initialization
	public FileWriter FW;
	public string Data;
	public bool Flag;
	public float count = 0.1f;
	float CountClock = 0.0f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time >= CountClock) {
			Data = gameObject.transform.position.x.ToString();
			Data += ","+gameObject.transform.position.y.ToString();
			Data += ","+gameObject.transform.position.z.ToString();
			Data += "," + gameObject.transform.rotation.x.ToString();
			Data += "," + gameObject.transform.rotation.y.ToString();
			Data += "," + gameObject.transform.rotation.z.ToString();
			Data += ","+Flag.ToString();
			FW.WriteFile(Data);//Write string Data as a line of data
			CountClock += count;
		}
		
	}
}
