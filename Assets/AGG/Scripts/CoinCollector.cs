using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameManager;

public class CoinCollector : MonoBehaviour
{
   /*public rigidbody _rb;

    void Start
    {
        rb = GetComponent<Rigidbody>();
    }
    */
    
     private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<ICollectable>(out ICollectable icoll))
        {
            icoll.OnCollected();    
            //StartCoroutine(WaitController);     
        }
    }

    /*private IEnumerator WaitController()
    {
        GetComponent<CharacterController>().enabled = false;
        yield return new WaitForsSeconds(2);
        GetComponent<CharacterController>().enabled = true;
    }
    */
}
