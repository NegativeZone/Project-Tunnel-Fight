using UnityEngine;
using System.Collections;

public class Tile {

	public enum TileType { Empty, Floor, Wall };

	TileType type = TileType.Empty;

	public TileType Type {
		get {
			return type;
		}
		set {
			type = value;
		}
	}
		
	Enemy enemy;

	public Enemy Enemy {
		get {
			return enemy;
		}
		set {
			enemy = value;
		}
	}

	Level level;

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

	public Tile(Level level, int x, int y){
		this.x = x;
		this.y = y;
		this.level = level;
		enemy = null;
	}
}
