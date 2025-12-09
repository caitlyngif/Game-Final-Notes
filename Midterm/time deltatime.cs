/* We use the following code for a motion sensor. If motion is detected, the light turns on. 
We then wait 5 seconds and turn off the light. 
Fill in the blank so the code runs independent of the framerate.
*/
using UnityEngine;

public class MotionDetector: MonoBehaviour{

    int waitTime; // = ???
    int waiting;
    bool light;

    public void Detected(){
        light = true;
        waiting = waitTime;
    }

    void Update(){
        if(light)
            if(waiting > 0)
                // ?
            else
                light = false;

    }
}

/*

int waitTime = 5; // shouldn't this be a float?

if(waiting > 0){
    waiting -= waitTime * Time.deltaTime;}

On 60 FPS, Time.deltaTime is 1/60.
It takes 300 frames to lower waiting from 5 to 0.
    This is 5 seconds.
On 30 FPS, Time.deltaTime is 1/30.
It takes 150 frames to lower waiting from 5 to 0.
    This is also 5 seconds.

*/