using UnityEngine;
using System.Collections;

public class Tile {

	public enum TileType { Floor, Wall };

	TileType type;

	public TileType Type {
		get {
			return type;
		}
		set {
			type = value;
		}
	}

	Room room;

	int x;

	public int X {
		get {
			return x;
		}
	}

	int y;

	public int Y {
		get {
			return y;
		}
	}

	Player player;

	public Tile(Room room, int x, int y) {
		this.room = room;
		this.x = x;
		this.y = y;
	}

}
