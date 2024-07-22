using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public managerChannel fromChannel;

    public int channel_new;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        run();
    }

    public void run() 
    {
        if (transform.position != fromChannel.manager_channel[channel_new].channels.position)
        {
            Vector3 box = Vector3.MoveTowards(transform.position, fromChannel.manager_channel[channel_new].channels.position, fromChannel.speed * Time.deltaTime);
            rb.MovePosition(box);
            print("1");
        }
        else 
        {
            print("2");
        }
    }
    
}
