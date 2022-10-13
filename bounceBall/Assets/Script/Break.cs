using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{ 
    BreakBlockSpawn parent;
    private void OnCollisionExit2D(Collision2D other)
    {
        transform.parent.GetComponent<BreakBlockSpawn>().timestart = true;
        gameObject.SetActive(false);
    }
}



//if (other.gameObject.CompareTag ("Player"))
//{
//    gameObject.SetActive(false);
//}