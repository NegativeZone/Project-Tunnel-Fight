using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	Enemy enemy;
	public int x;
	public int y;
	public GameObject BaddieSprite;
	public GameObject BaddieBlood;

	// Use this for initialization
	void Start () {
		enemy = new Enemy (x, y);
		BaddieSprite.transform.position = new Vector3(enemy.X, enemy.Y, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (enemy.HP != 0)
			LevelController.Instance.GetTileAtWorldCoord (BaddieSprite.transform.position).Enemy = enemy;
		if (enemy.HP == 0) {
			Destroy (BaddieSprite);
			BaddieSprite = Instantiate (BaddieBlood);
			BaddieSprite.transform.position = new Vector3(enemy.X, enemy.Y, 0);
			LevelController.Instance.GetTileAtWorldCoord (BaddieSprite.transform.position).Enemy = null;
		}
	}
}
