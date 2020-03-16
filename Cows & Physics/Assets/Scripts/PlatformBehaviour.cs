using UnityEngine;
using System.Collections;

public class PlatformBehaviour : MonoBehaviour {

  public float speed = 5.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
    if (Input.GetKey(KeyCode.LeftArrow)) {
      transform.position = new Vector3(transform.position.x - speed * Time.deltaTime,
                                     transform.position.y, 
                                     transform.position.z);
    } else if (Input.GetKey(KeyCode.RightArrow)) {
      transform.position = new Vector3(transform.position.x + speed * Time.deltaTime,
                                     transform.position.y, 
                                     transform.position.z);
    }
	}
}
