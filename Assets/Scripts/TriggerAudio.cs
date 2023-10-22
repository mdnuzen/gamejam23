using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAudio : MonoBehaviour
{
    public string fungusBlock = string.Empty;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "Player")
       {
            FungusHandler.instance.ExecuteBlock(fungusBlock);
            this.gameObject.SetActive(false);
       }
    }

}
