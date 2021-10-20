using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour

{
    //public float input;

    public carController controller;

    public GameObject cameraTarget;
    public GameObject player;
    public GameObject[] camraPositions;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        controller = player.GetComponent<carController>();
        //controller.cameraTarget.transform.GetChild(0);  (Old camera transistion code)
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //input = Input.GetAxis("Horizontal");   (Old camera code)
        gameObject.transform.position = controller.cameraTarget.transform.GetChild(0).transform.position;
        //gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x + input, gameObject.transform.localPosition.y, gameObject.transform.localPosition.z);  (Old camera code)
        gameObject.transform.LookAt(controller.cameraTarget.transform.GetChild(1).transform.position);
        
    }
}
