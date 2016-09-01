using UnityEngine;
using System.Collections;

public class Room {

	Vector3 location;

	public Vector3 Location {
		get {
			return location;
		}
	}

	int width;

	public int Width {
		get {
			return width;
		}
	}

	int height;

	public int Height {
		get {
			return height;
		}
	}

	Tile[,] tiles;

	public enum Doorway { top, right, bottom, left };

	public Room(int width, int height, Doorway [] doorway, int ndoors, Vector3 location){
		this.width = width;
		this.height = height;
		this.location = location;

		tiles = new Tile[width, height];
		for (int x = 0; x < width; x++) {
			for (int y = 0; y < height; y++) {
				tiles [x, y] = new Tile (this, x, y);
			}
		}

		for (int x = 0; x < width; x++) {
			for (int y = 0; y < height; y++) {
				if (x == 0 || y == 0 || x == height - 1 || y == height - 1)
					tiles [x, y].Type = Tile.TileType.Wall;
				else
					tiles [x, y].Type = Tile.TileType.Floor;
			}
		}


		for (int x = 0; x < ndoors; x++) {
			if (doorway[x] == Doorway.bottom)
				tiles [width / 2, 0].Type = Tile.TileType.Floor;
			if (doorway[x] == Doorway.top)
				tiles [width / 2, height - 1].Type = Tile.TileType.Floor;
			if (doorway[x] == Doorway.left)
				tiles [0, height / 2].Type = Tile.TileType.Floor;
			if (doorway[x] == Doorway.right)
				tiles [width - 1, height / 2].Type = Tile.TileType.Floor;
		}
	}

	public Tile GetTileAt(int x, int y) {
		return tiles[x, y];
	}

}
