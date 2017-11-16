namespace Mazes
{
	public static class SnakeMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
			string side = "right";
			while (!robot.Finished) {
				if (robot.X == 1 && robot.Y != 1) {
					side = "right"; 
					PassDown (robot);
					robot.MoveTo (Direction.Right);
				} else if (robot.X == width - 2) {
					side = "left"; 
					PassDown (robot);
					robot.MoveTo (Direction.Left);
				}

				MoveInSide (robot, side);
			}
		}

		public static void PassDown(Robot robot)
		{
			for (var i = 0; i < 2; i++) {
				robot.MoveTo (Direction.Down);
			}
		}

		public static void MoveInSide(Robot robot, string side)
		{
			if (side == "left") {
				robot.MoveTo (Direction.Left);
			} else {
				robot.MoveTo (Direction.Right);
			}
		}
	}
}