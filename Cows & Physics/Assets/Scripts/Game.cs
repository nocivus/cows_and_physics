using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

	public static Game game;
  public GameObject cowPrefab;

  void Awake()
  {
    if (game == null)
    {
      DontDestroyOnLoad(gameObject);
      game = this;
    }
    else if (game != this)
    {
      Destroy(gameObject);
    }
  }

  void Start() {

    InvokeRepeating("SpawnCow", 2, 1.5f);
  }

  public void SpawnCow() {

    Instantiate(cowPrefab);
  }
}
