/*

The Grim Reaper is a game object in our scene that has a Reaper script attached to it. 
Grim Reaper’s scythe is another game object that is a child of Grim Reaper. The child game object has a scythe script attached to it.

Fill in the blank below so that calling Claim does not throw a runtime error. Assume class Character exists elsewhere.

*/
using UnityEngine;

public class Reaper:MonoBehaviour{

    Scythe scythe;

    void Start(){
        BLANK
    }

    public void Claim(Character character){
        character.Die();
        scythe.Upgrade();
    }
}

/*

void Start(){
    scythe = GetComponentInChildren<Scythe>();
}
*/