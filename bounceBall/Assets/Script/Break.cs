using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{
    //BreakBlockSpawn parent;
    //private void Start()
    //{
    //    StartCoroutine(T());
    //}

    private void OnCollisionExit2D(Collision2D other)
    {
        //transform.parent.GetComponent<BreakBlockSpawn>().timestart = true;
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        transform.parent.GetComponent<BreakBlockSpawn>().active++;
    }

    //IEnumerator T()
    //{
    //    yield return new WaitForSeconds(0.1f);
    //}
}



//if (other.gameObject.CompareTag ("Player"))
//{
//    gameObject.SetActive(false);
//}