using UnityEngine;
using System.Collections;

public class CowBehaviour : MonoBehaviour {

  public float speed = 0.1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
  {
    transform.position = new Vector3(transform.position.x + speed * Time.deltaTime,
                                     transform.position.y, 
                                     transform.position.z);

    if (transform.position.y <= -5) {
      Destroy(gameObject);
      //Game.game.SpawnCow();
    }
	}

  void OnTriggerEnter2D(Collider2D collider) {
    Destroy(gameObject);
    //Game.game.SpawnCow();
  }
}
