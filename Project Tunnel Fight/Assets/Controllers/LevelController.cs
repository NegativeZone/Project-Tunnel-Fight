using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour {

	public static LevelController Instance { get; protected set; }

	public GameObject FloorTile;
	public GameObject WallTile;

	public Level level { get; protected set; }

	// Use this for initialization
	void Start () {
		if (Instance != null)
			Debug.LogError ("Never have two world controllers.");
		Instance = this;
		level = new Level();
		LoadALevel ();
	}

	// Update is called once per frame
	void Update () {

	}

	void LoadALevel(){
		level.LoadLevel ("L1.txt");
		// Create a GameObject for each tile so that they're visible
		for (int x = 0; x < level.Width; x++) {
			for (int y = 0; y < level.Height; y++) {
				Tile tile_data = level.GetTileAt (x, y);
				if (tile_data.Type == Tile.TileType.Floor) {
					GameObject NewTile = Instantiate (FloorTile);
					NewTile.transform.position = new Vector3 (tile_data.X, tile_data.Y, 0);
					NewTile.transform.SetParent (this.transform);
				} else if (tile_data.Type == Tile.TileType.Wall) {
					GameObject NewTile = Instantiate (WallTile);
					NewTile.transform.position = new Vector3 (tile_data.X, tile_data.Y, 0);
					NewTile.transform.SetParent (this.transform);
				}
			}
		}
	}
		
	public Tile GetTileAtWorldCoord(Vector3 coord){
		int x = Mathf.RoundToInt (coord.x);
		int y = Mathf.RoundToInt (coord.y);

		return level.GetTileAt (x, y);
	}
}
