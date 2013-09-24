using UnityEngine;
using System.Collections;

public class FishGod : MonoBehaviour {

    public Fish fishBlueprint;
    public int fishCount = 100;

	// Use this for initialization
	void Start () {
        int currentFishCounter = 0;
	    while ( currentFishCounter < fishCount ) {
            // spawn a fish
            Vector3 fishPosition = new Vector3( Random.Range( -10f, 10f ), Random.Range( -10f, 10f ), Random.Range( -10f, 10f ) );
            Instantiate( fishBlueprint, fishPosition, Quaternion.identity);

            // increment our fishCounter
            // currentFishCounter = currentFishCounter + 1;
            currentFishCounter++;
        }

        // when currentFishCounter is 100, the code will end the while() loop
        // and do whatever code is after it, like right here
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
