using UnityEngine;
using System.Collections;
using Utils ;

public class Grid : MonoBehaviour {

	private static int width = Constants.GRID_WIDTH ;
	private static int height = Constants.GRID_HEIGHT ;

	public static Transform[,] grid = new Transform[ width , height ] ;
	
	private static void deleteRow( int y ){
		for( int x = 0 ; x < width ; x++){
			Destroy( grid[ x , y ].gameObject ) ;
			grid[ x , y ] = null ;
		}
	}

	private static void decreaseRow( int y ){
		for( int x = 0 ; x < width ; x++){
			if( grid[ x , y ] == null ) continue ;
			grid[ x , y - 1 ] = grid[ x , y ] ;
			grid[ x , y ] = null ;
			grid[ x , y - 1 ].position += Constants.DOWN_MOV ;
		}
	}

	private static void decreaseRowsAbove( int y ){
		for (int i = y; i < height; i++) decreaseRow( i ) ;
	}

	private static bool isRowFull( int y ){
		for (int x = 0; x < width; x++)
			if (grid [x, y] == null)
				return false;
		return true;
	}

	public static void deleteFullRows(){
		for (int y = 0; y < height; y++) {
			if( isRowFull( y ) ){
				deleteRow( y ) ;
				decreaseRowsAbove( y ) ;
				y-- ;
			}
		}
	}

	public static bool insideGrid( Vector3 pos ){
		int x = (int)pos.x, y = (int)pos.y;
		bool xValid = 0 <= x && x < width ;
		bool yValid = 0 <= y && y < height ;
		return xValid && yValid ;
	}
}
