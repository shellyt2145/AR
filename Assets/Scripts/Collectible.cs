using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private bool _hasBeenCollected = false;

    private void OnTrigger(Collider collision)
    {
        //if (!_hasBeenCollected && collision.gameObject.GetComponent<Touch>)
        {
            handlecollected();
        }
    }

    public virtual void handlecollected()
    {
        _hasBeenCollected = true;
        Destroy(gameObject);
    }
}