using UnityEngine;
using System;
using System.IO;
using System.Collections;

public class Level {

	Tile[,] tiles;

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

	public Level(int width = 15, int height = 15) {
		this.width = width;
		this.height = height;

		this.tiles = new Tile[width, height];

		for (int x = 0; x < width; x++) {
			for (int y = 0; y < height; y++) {
				tiles [x, y] = new Tile (this, x, y);
			}
		}

		Debug.Log ("Level loaded!");
	}

	public Tile GetTileAt(int x, int y){
		if (x > width || x < 0) {
			return null;
		} else if (y > height || y < 0) {
			return null;
		} else
			return tiles [x, y];
	}

	public void LoadLevel(string LevelFileName){
		String input = File.ReadAllText("Assets/Levels/" + LevelFileName);
		int i = 0, j = 0;
		int[,] result = new int[width, height];
		foreach (var row in input.Split('\n'))
		{
			j = 0;
			foreach (var col in row.Trim().Split(' '))
			{
				result[i, j] = int.Parse(col.Trim());
				j++;
			}
			i++;
		}
		for (int x = 0; x < width; x++) {
			for (int y = 0; y < height; y++) {
				if (result [x, y] == 0)
					tiles [x, y].Type = Tile.TileType.Empty;
				else if (result [x, y] == 1)
					tiles [x, y].Type = Tile.TileType.Floor;
				else
					tiles [x, y].Type = Tile.TileType.Wall;
			}
		}
	}

}
