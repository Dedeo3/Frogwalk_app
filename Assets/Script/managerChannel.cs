using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerChannel : MonoBehaviour
{
    public float speed;
    [System.Serializable]
    public class data_channel
    {
        public Transform channels;
    }

    public List<data_channel> manager_channel = new List<data_channel>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
