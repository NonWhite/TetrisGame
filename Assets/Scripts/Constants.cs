using UnityEngine ;
using System.Collections;

namespace Utils
{
	public class Constants
	{
		// GRID BOUNDS
		public static int GRID_WIDTH = 10 ;
		public static int GRID_HEIGHT = 20 ;

		// MOVEMENTS
		public static Vector3 LEFT_MOV = new Vector3 (-1, 0, 0) ;
		public static Vector3 RIGHT_MOV = new Vector3 (1, 0, 0) ;
		public static Vector3 DOWN_MOV = new Vector3 (0, -1, 0) ;
		public static Vector3 UP_MOV = new Vector3 (0, 1, 0) ;

		public static Vector3 roundVector(Vector3 v) {
			float x = Mathf.Round (v.x);
			float y = Mathf.Round (v.y);
			float z = Mathf.Round (v.z);
			return new Vector3(x,y,z);
		}
	}
}

