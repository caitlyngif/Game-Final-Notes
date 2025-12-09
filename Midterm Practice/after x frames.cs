/*

What is the value of x after five frames?

*/
using UnityEngine;

public class Test: MonoBehaviour{

    int x = 10;

    void Start(){
        x = 2;
    }

    void LateUpdate(){
        if(x == 2)
            x = x / 2;
    }

    void Update(){
        if(x<10){
            x = x * 2;
        }
    }
}

/*

First frame
Start: x = 2
Update: x = 4
LateUpdate: x = 2

Second frame
Update: x = 8

Third frame
Update: x = 16

Fourth frame
Update: x = 16

Fifth frame
Update: x = 16

*/