using UnityEngine ;
using System.Collections;

namespace Utils
{
	public class Constants
	{
		// BOARD BOUNDS
		public static int BX_MIN = -5 ;
		public static int BX_MAX = -BX_MIN ;

		public static int BY_MIN = -10 ;
		public static int BY_MAX = -BY_MIN ;

		// SPAWN BOUNDS
		public static int SPAWN_Y = 8 ;
		public static int SX_MIN = -3 ;
		public static int SX_MAX = -SX_MIN ;

		// MOVEMENTS
		public static Vector3 LEFT_MOV = new Vector3 (-1, 0, 0) ;
		public static Vector3 RIGHT_MOV = new Vector3 (1, 0, 0) ;
		public static Vector3 DOWN_MOV = new Vector3 (0, -1, 0) ;

		public static Vector3 roundVector(Vector3 v) {
			float x = Mathf.Round (v.x);
			float y = Mathf.Round (v.y);
			float z = Mathf.Round (v.z);
			return new Vector3(x,y,z);
		}
	}
}

