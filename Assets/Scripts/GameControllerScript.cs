using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    
    public Ball ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GameObject.Find("left flipper").GetComponent<Rigidbody2D>().AddForce(Vector2.up*150);
            //Vector2 is a two directional number with an X and Y component. Vector2.up is a vector which points up in the Y direction, 
            //and has no X component (0 in the X direction), so this code will push the flipper up with a force of 150- so it's not affected
            //by gravity/
        }
        else
        {
            //GameObject.Find("left flipper").GetComponent<HingeJoint2D>().useMotor = false;
        }


        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            GameObject.Find("right flipper").GetComponent<Rigidbody2D>().AddForce(Vector2.up * 150);
        }
        else
        {
            //GameObject.Find("right flipper").GetComponent<HingeJoint2D>().useMotor = false;

        }
    }
}
