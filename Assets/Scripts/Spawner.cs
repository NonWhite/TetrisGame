using UnityEngine;
using System.Collections;
using Utils ;

public class Spawner : MonoBehaviour {

	public GameObject[] possiblePieces ;

	private Vector3 initPos ;
	private int idPiece ;
	
	void Start () {
		Spawn () ;
	}

	void Update () {
//		if (Input.GetMouseButtonDown (0)) {
//			Spawn() ;
//		}
	}

	void GetRandomPiece(){
		idPiece = Random.Range (0, possiblePieces.Length) ;
	}

	void GetRandomPosition(){
		int x = Random.Range (Constants.SX_MIN, Constants.SX_MAX);
		initPos = new Vector3 (x, Constants.SPAWN_Y, 0);
		initPos = Constants.roundVector (initPos);
	}

	void Spawn(){
		GetRandomPiece ();
		GetRandomPosition ();
		GameObject piece = possiblePieces[ idPiece ] ;
		Instantiate (piece, initPos, Quaternion.identity);
	}
}