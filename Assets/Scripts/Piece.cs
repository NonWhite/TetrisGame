using UnityEngine;
using System.Collections;
using Utils ;

public class Piece : MonoBehaviour {
	
	private float lastFall = 0 ;

	void Start(){
		if (!isValid ()) {
			Debug.Log ( "GAME OVER" ) ;
			Destroy ( gameObject ) ;
		}
	}

	void Update () {
		if( Input.GetKeyDown( KeyCode.DownArrow ) || Time.time - lastFall >= 1 ){
			transform.position += Constants.DOWN_MOV ;
			if( isValid() ){
				updateGrid() ;
			}else{
				transform.position += Constants.UP_MOV ;
				Grid.deleteFullRows();
				FindObjectOfType<Spawner>().Spawn() ;
				enabled = false;
			}
			lastFall = Time.time ;
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			transform.position += Constants.RIGHT_MOV ;
			if( isValid() ) updateGrid() ;
			else transform.position += Constants.LEFT_MOV ;
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			transform.position += Constants.LEFT_MOV ;
			if( isValid() ) updateGrid () ;
			else transform.position += Constants.RIGHT_MOV ;
		}
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			transform.Rotate ( 0 , 0 , -90 ) ;
			if( isValid() ) updateGrid () ;
			else transform.Rotate ( 0 , 0 , 90 ) ;
		}
	}

	bool isValid(){
		foreach (Transform child in transform) {
			Vector3 pos = Constants.roundVector( child.position ) ;
			if( !Grid.insideGrid( pos ) ) return false ;

			int x = (int)pos.x , y = (int)pos.y ;
			Transform cell = Grid.grid[ x , y ] ;
			if( cell != null && cell.parent != transform ) return false ;
		}
		return true;
	}

	void updateGrid(){
		for (int y = 0; y < Constants.GRID_HEIGHT; y++) 
			for (int x = 0; x < Constants.GRID_WIDTH; x++)
				if (Grid.grid [x, y] != null)
					if (Grid.grid [x, y].parent == transform)
						Grid.grid [x, y] = null;

		foreach (Transform child in transform) {
			Vector3 pos = Constants.roundVector( child.position ) ;
			int x = (int)pos.x , y = (int)pos.y ;
			Grid.grid[ x , y ] = child ;
		}
	}
}
