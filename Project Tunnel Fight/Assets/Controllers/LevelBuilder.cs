using UnityEngine;
using System.Collections;

public class LevelBuilder : MonoBehaviour {

	int CurrLevel;
	bool LevelChanged;

	LevelOne Level_One;
	LevelTwo Level_Two;
	public GameObject FloorTile;
	public GameObject WallTile;
	public GameObject TileHolder;

	// Use this for initialization
	void Start () {
		CurrLevel = 1;
		LevelChanged = true;
		Level_One = new LevelOne ();
		TileHolder = new GameObject();
		TileHolder.transform.position = new Vector3(0,0,0);

		for (int x = 0; x < Level_One.RoomOne.Width; x++) {
			for (int y = 0; y < Level_One.RoomOne.Height; y++) {
				if (Level_One.RoomOne.GetTileAt (x, y).Type == Tile.TileType.Floor) {
					GameObject NewTile = Instantiate (FloorTile);
					NewTile.transform.position = new Vector3 (x, y, 0) + Level_One.RoomOne.Location;
					NewTile.transform.SetParent(TileHolder.transform);
				}
				else if (Level_One.RoomOne.GetTileAt (x, y).Type == Tile.TileType.Wall) {
					GameObject NewTile = Instantiate (WallTile);
					NewTile.transform.position = new Vector3 (x, y, 0) + Level_One.RoomOne.Location;
					NewTile.transform.SetParent(TileHolder.transform);
				}
			}
		}
		for (int x = 0; x < Level_One.RoomTwo.Width; x++) {
			for (int y = 0; y < Level_One.RoomTwo.Height; y++) {
				if (Level_One.RoomTwo.GetTileAt (x, y).Type == Tile.TileType.Floor) {
					GameObject NewTile = Instantiate (FloorTile);
					NewTile.transform.position = new Vector3 (x, y, 0) + Level_One.RoomTwo.Location;
					NewTile.transform.SetParent(TileHolder.transform);
				}
				else if (Level_One.RoomTwo.GetTileAt (x, y).Type == Tile.TileType.Wall) {
					GameObject NewTile = Instantiate (WallTile);
					NewTile.transform.position = new Vector3 (x, y, 0) + Level_One.RoomTwo.Location;
					NewTile.transform.SetParent(TileHolder.transform);
				}
			}
		}
		for (int x = 0; x < Level_One.RoomThree.Width; x++) {
			for (int y = 0; y < Level_One.RoomThree.Height; y++) {
				if (Level_One.RoomThree.GetTileAt (x, y).Type == Tile.TileType.Floor) {
					GameObject NewTile = Instantiate (FloorTile);
					NewTile.transform.position = new Vector3 (x, y, 0) + Level_One.RoomThree.Location;
					NewTile.transform.SetParent(TileHolder.transform);
				}
				else if (Level_One.RoomThree.GetTileAt (x, y).Type == Tile.TileType.Wall) {
					GameObject NewTile = Instantiate (WallTile);
					NewTile.transform.position = new Vector3 (x, y, 0) + Level_One.RoomThree.Location;
					NewTile.transform.SetParent(TileHolder.transform);
				}
			}
		}
		for (int x = 0; x < Level_One.HallwayOne.Width; x++) {
			for (int y = 0; y < Level_One.HallwayOne.Height; y++) {
				if (Level_One.HallwayOne.GetTileAt (x, y).Type == Tile.TileType.Floor) {
					GameObject NewTile = Instantiate (FloorTile);
					NewTile.transform.position = new Vector3 (x, y, 0) + Level_One.HallwayOne.Location;
					NewTile.transform.SetParent(TileHolder.transform);
				}
				else if (Level_One.HallwayOne.GetTileAt (x, y).Type == Tile.TileType.Wall) {
					GameObject NewTile = Instantiate (WallTile);
					NewTile.transform.position = new Vector3 (x, y, 0) + Level_One.HallwayOne.Location;
					NewTile.transform.SetParent(TileHolder.transform);
				}
			}
		}
		for (int x = 0; x < Level_One.HallwayTwo.Width; x++) {
			for (int y = 0; y < Level_One.HallwayTwo.Height; y++) {
				if (Level_One.HallwayTwo.GetTileAt (x, y).Type == Tile.TileType.Floor) {
					GameObject NewTile = Instantiate (FloorTile);
					NewTile.transform.position = new Vector3 (x, y, 0) + Level_One.HallwayTwo.Location;
					NewTile.transform.SetParent(TileHolder.transform);
				}
				else if (Level_One.HallwayTwo.GetTileAt (x, y).Type == Tile.TileType.Wall) {
					GameObject NewTile = Instantiate (WallTile);
					NewTile.transform.position = new Vector3 (x, y, 0) + Level_One.HallwayTwo.Location;
					NewTile.transform.SetParent(TileHolder.transform);
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("l")) {
			CurrLevel = 2;
			LevelChanged = false;
		}
		if (CurrLevel == 2 && LevelChanged == false) {
			Destroy (TileHolder);
			Level_Two = new LevelTwo ();
			TileHolder = new GameObject();
			TileHolder.transform.position = new Vector3(0,0,0);

			for (int x = 0; x < Level_Two.RoomOne.Width; x++) {
				for (int y = 0; y < Level_Two.RoomOne.Height; y++) {
					if (Level_Two.RoomOne.GetTileAt (x, y).Type == Tile.TileType.Floor) {
						GameObject NewTile = Instantiate (FloorTile);
						NewTile.transform.position = new Vector3 (x, y, 0) + Level_Two.RoomOne.Location;
						NewTile.transform.SetParent(TileHolder.transform);
					}
					else if (Level_Two.RoomOne.GetTileAt (x, y).Type == Tile.TileType.Wall) {
						GameObject NewTile = Instantiate (WallTile);
						NewTile.transform.position = new Vector3 (x, y, 0) + Level_Two.RoomOne.Location;
						NewTile.transform.SetParent(TileHolder.transform);
					}
				}
			}
			for (int x = 0; x < Level_Two.RoomTwo.Width; x++) {
				for (int y = 0; y < Level_Two.RoomTwo.Height; y++) {
					if (Level_Two.RoomTwo.GetTileAt (x, y).Type == Tile.TileType.Floor) {
						GameObject NewTile = Instantiate (FloorTile);
						NewTile.transform.position = new Vector3 (x, y, 0) + Level_Two.RoomTwo.Location;
						NewTile.transform.SetParent(TileHolder.transform);
					}
					else if (Level_Two.RoomTwo.GetTileAt (x, y).Type == Tile.TileType.Wall) {
						GameObject NewTile = Instantiate (WallTile);
						NewTile.transform.position = new Vector3 (x, y, 0) + Level_Two.RoomTwo.Location;
						NewTile.transform.SetParent(TileHolder.transform);
					}
				}
			}
			for (int x = 0; x < Level_Two.RoomThree.Width; x++) {
				for (int y = 0; y < Level_Two.RoomThree.Height; y++) {
					if (Level_Two.RoomThree.GetTileAt (x, y).Type == Tile.TileType.Floor) {
						GameObject NewTile = Instantiate (FloorTile);
						NewTile.transform.position = new Vector3 (x, y, 0) + Level_Two.RoomThree.Location;
						NewTile.transform.SetParent(TileHolder.transform);
					}
					else if (Level_Two.RoomThree.GetTileAt (x, y).Type == Tile.TileType.Wall) {
						GameObject NewTile = Instantiate (WallTile);
						NewTile.transform.position = new Vector3 (x, y, 0) + Level_Two.RoomThree.Location;
						NewTile.transform.SetParent(TileHolder.transform);
					}
				}
			}
			for (int x = 0; x < Level_Two.HallwayOne.Width; x++) {
				for (int y = 0; y < Level_Two.HallwayOne.Height; y++) {
					if (Level_Two.HallwayOne.GetTileAt (x, y).Type == Tile.TileType.Floor) {
						GameObject NewTile = Instantiate (FloorTile);
						NewTile.transform.position = new Vector3 (x, y, 0) + Level_Two.HallwayOne.Location;
						NewTile.transform.SetParent(TileHolder.transform);
					}
					else if (Level_Two.HallwayOne.GetTileAt (x, y).Type == Tile.TileType.Wall) {
						GameObject NewTile = Instantiate (WallTile);
						NewTile.transform.position = new Vector3 (x, y, 0) + Level_Two.HallwayOne.Location;
						NewTile.transform.SetParent(TileHolder.transform);
					}
				}
			}
			for (int x = 0; x < Level_Two.HallwayTwo.Width; x++) {
				for (int y = 0; y < Level_Two.HallwayTwo.Height; y++) {
					if (Level_Two.HallwayTwo.GetTileAt (x, y).Type == Tile.TileType.Floor) {
						GameObject NewTile = Instantiate (FloorTile);
						NewTile.transform.position = new Vector3 (x, y, 0) + Level_Two.HallwayTwo.Location;
						NewTile.transform.SetParent(TileHolder.transform);
					}
					else if (Level_Two.HallwayTwo.GetTileAt (x, y).Type == Tile.TileType.Wall) {
						GameObject NewTile = Instantiate (WallTile);
						NewTile.transform.position = new Vector3 (x, y, 0) + Level_Two.HallwayTwo.Location;
						NewTile.transform.SetParent(TileHolder.transform);
					}
				}
			}
		}
	}
}
