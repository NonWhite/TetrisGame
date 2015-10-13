using UnityEngine;
using System.Collections;
using Utils ;

public class Piece : MonoBehaviour {
	
	private float xmin = Constants.BX_MIN ;
	private float xmax = Constants.BX_MAX ;
	private float ymin = Constants.BY_MIN ;
	private float ymax = Constants.BY_MAX ;

	void Start(){
		Vector3 position = Constants.roundVector (transform.position);
		transform.position = position;
	}

	void Update () {
		if( Input.GetKeyDown( KeyCode.DownArrow ) ){
			Vector3 newPos = transform.position + Constants.DOWN_MOV ;
			if( isValid( newPos ) )
				transform.position = newPos ;
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			Vector3 newPos = transform.position + Constants.RIGHT_MOV ;
			if( isValid( newPos ) )
				transform.position = newPos ;
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			Vector3 newPos = transform.position + Constants.LEFT_MOV ;
			if( isValid( newPos ) )
				transform.position = newPos ;
		}
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			transform.Rotate ( 0 , 0 , 90 ) ;
		}
	}

	bool isValid( Vector3 pos ){
		bool xValid = xmin <= pos.x && pos.x <= xmax;
		bool yValid = ymin <= pos.y && pos.y <= ymax;
		return xValid && yValid;
	}
}
