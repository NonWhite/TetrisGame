using UnityEngine;
using System.Collections;
using Utils ;

public class Spawner : MonoBehaviour {

	public GameObject[] possiblePieces ;

	private int idPiece ;
	
	void Start () {
		Spawn () ;
	}

	void GetRandomPiece(){
		idPiece = Random.Range (0, possiblePieces.Length) ;
	}
	
	public void Spawn(){
		GetRandomPiece ();
		GameObject piece = possiblePieces[ idPiece ] ;
		Instantiate (piece, transform.position , Quaternion.identity);
	}
}