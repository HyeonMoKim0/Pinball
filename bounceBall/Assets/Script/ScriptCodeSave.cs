using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCodeSave : MonoBehaviour
{
    
}
//star
/*GameManager gameManager = FindObjectOfType<GameManager>();
            gameManager.GameClear();*/

//jumpblock
/*void OnTriggerEnter2D(Collider2D other)
{
    if (other.tag == "Player")
    {
        //BounceBall script�� ����� ���� ��������
        GameObject temp = GameObject.Find("BounceBall");
        Rigidbody2D ballRigidbody = temp.GetComponent<BounceBall>().ballRigidbody;
        Vector2 newVelocity = temp.GetComponent<BounceBall>().newVelocity;
        float orig_y = temp.GetComponent<BounceBall>().orig_y;
        float jumpBoost = temp.GetComponent<BounceBall>().jumpBoost;
        bool hit = temp.GetComponent<BounceBall>().hit;

        //JumpBlock
        newVelocity = new Vector2(ballRigidbody.velocity.x, orig_y * jumpBoost);
        ballRigidbody.velocity = newVelocity;
        hit = true;*/

//bounceball
/*GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.GameOver();*/