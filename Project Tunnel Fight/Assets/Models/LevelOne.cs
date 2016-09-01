using UnityEngine;
using System.Collections;

public class LevelOne {

	public Room RoomOne;
	public Room RoomTwo;
	public Room RoomThree;
	public Room HallwayOne;
	public Room HallwayTwo;

	public LevelOne(){
		RoomOne = new Room (5, 5, new Room.Doorway[]{Room.Doorway.top}, 1, new Vector3 (0, 0, 0));
		HallwayOne = new Room (3, 1, new Room.Doorway[]{Room.Doorway.top}, 1, new Vector3 (1, 5, 0));
		RoomTwo = new Room (7, 7, new Room.Doorway[]{Room.Doorway.bottom, Room.Doorway.right}, 2, new Vector3 (-1, 6, 0));
		HallwayTwo = new Room (1, 3, new Room.Doorway[]{Room.Doorway.right}, 1, new Vector3 (6, 8, 0));
		RoomThree = new Room (7, 7, new Room.Doorway[]{Room.Doorway.left}, 1, new Vector3 (7, 6, 0));
	}

}
