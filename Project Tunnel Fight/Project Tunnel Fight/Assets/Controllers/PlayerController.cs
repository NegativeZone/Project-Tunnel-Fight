using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	Player player;

	// Use this for initialization
	void Start () {
		player = new Player (12, 2);
		transform.position = new Vector3 (player.X, player.Y, 0);
	}

	IEnumerator AttackUp(){
		transform.position += new Vector3 (0, 0.4f, 0);
		yield return new WaitForSecondsRealtime (0.2f);
		transform.position -= new Vector3 (0, 0.4f, 0);		
	}
	IEnumerator AttackDown(){
		transform.position += new Vector3 (0, -0.4f, 0);
		yield return new WaitForSecondsRealtime (0.2f);
		transform.position -= new Vector3 (0, -0.4f, 0);		
	}
	IEnumerator AttackLeft(){
		transform.position += new Vector3 (-0.4f, 0, 0);
		yield return new WaitForSecondsRealtime (0.2f);
		transform.position -= new Vector3 (-0.4f, 0, 0);		
	}
	IEnumerator AttackRight(){
		transform.position += new Vector3 (0.4f, 0, 0);
		yield return new WaitForSecondsRealtime (0.2f);
		transform.position -= new Vector3 (0.4f, 0, 0);		
	}

	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("w")) {
			Vector3 NextPos = transform.position + new Vector3(0, 1, 0);
			if (LevelController.Instance.GetTileAtWorldCoord (NextPos).Enemy != null) {
				StartCoroutine (AttackUp ());
				LevelController.Instance.GetTileAtWorldCoord (NextPos).Enemy.HP -= player.Damage;
			}
			else if(LevelController.Instance.GetTileAtWorldCoord(NextPos).Type == Tile.TileType.Floor){
				transform.position = NextPos;
				player.X = (int)NextPos.x;
				player.Y = (int)NextPos.y;
			}
		} else if (Input.GetKeyDown ("s")) {
			Vector3 NextPos = transform.position + new Vector3(0, -1, 0);
			if (LevelController.Instance.GetTileAtWorldCoord (NextPos).Enemy != null) {
				StartCoroutine (AttackDown ());
				LevelController.Instance.GetTileAtWorldCoord (NextPos).Enemy.HP -= player.Damage;
			}
			else if(LevelController.Instance.GetTileAtWorldCoord(NextPos).Type == Tile.TileType.Floor){
				transform.position = NextPos;
				player.X = (int)NextPos.x;
				player.Y = (int)NextPos.y;
			}
		}
		else if (Input.GetKeyDown ("a")) {
			Vector3 NextPos = transform.position + new Vector3(-1, 0, 0);
			if (LevelController.Instance.GetTileAtWorldCoord (NextPos).Enemy != null) {
				StartCoroutine (AttackLeft ());
				LevelController.Instance.GetTileAtWorldCoord (NextPos).Enemy.HP -= player.Damage;
			}
			else if(LevelController.Instance.GetTileAtWorldCoord(NextPos).Type == Tile.TileType.Floor){
				transform.position = NextPos;
				player.X = (int)NextPos.x;
				player.Y = (int)NextPos.y;
			}
		}
		else if (Input.GetKeyDown ("d")) {
			Vector3 NextPos = transform.position + new Vector3(1, 0, 0);
			if (LevelController.Instance.GetTileAtWorldCoord (NextPos).Enemy != null) {
				StartCoroutine (AttackRight ());
				LevelController.Instance.GetTileAtWorldCoord (NextPos).Enemy.HP -= player.Damage;
			}
			else if(LevelController.Instance.GetTileAtWorldCoord(NextPos).Type == Tile.TileType.Floor){
				transform.position = NextPos;
				player.X = (int)NextPos.x;
				player.Y = (int)NextPos.y;
			}
		}
	}
}
