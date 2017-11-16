namespace Mazes
{
	public static class EmptyMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
			while (!robot.Finished) {
				if (robot.Y < width-2)
					robot.MoveTo (Direction.Right);
				if (robot.X < height-2)
					robot.MoveTo (Direction.Down);
			}
		}
	}
}