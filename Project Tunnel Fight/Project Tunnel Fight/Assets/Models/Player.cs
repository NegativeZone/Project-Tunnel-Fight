using UnityEngine;
using System.Collections;

public class Player {

	int hP;

	public int HP {
		get {
			return hP;
		}
		set {
			hP = value;
		}
	}

	int damage;

	public int Damage {
		get {
			return damage;
		}
	}

	int x;

	public int X {
		get {
			return x;
		}
		set {
			x = value;
		}
	}

	int y;

	public int Y {
		get {
			return y;
		}
		set {
			y = value;
		}
	}

	public Player(int x, int y){
		this.x = x;
		this.y = y;
		this.hP = 10;
		this.damage = 5;
	}

}
