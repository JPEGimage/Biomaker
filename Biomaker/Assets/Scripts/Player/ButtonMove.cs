using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonMove : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rig;

    public Animator anim;

    private SpriteRenderer img;

    public float speed;
    bool moving = false;
    string direction;
    void Start()
    {
        img = player.GetComponent<SpriteRenderer>();
    }
    void FixedUpdate()
    {
        if(moving)
        {
            switch (direction)
            {
                case "up":
                    var up = new Vector3(0f, 1f, 0f).normalized;
                    rig.velocity = up * speed;
                    anim.SetBool("move",true);
                    break;
                case "down":
                    var down = new Vector3(0f, -1f, 0f).normalized;
                    rig.velocity = down * speed;
                    anim.SetBool("move", true);
                    break;
                case "left":
                    img.flipX = true;
                    var left = new Vector3(-1f, 0f, 0f).normalized;
                    rig.velocity = left * speed;
                    anim.SetBool("move", true);
                    break;
                case "right":
                    img.flipX = false;
                    var right = new Vector3(1f, 0f, 0f).normalized;
                    rig.velocity = right * speed;
                    anim.SetBool("move", true);
                    break;
            }
        }
        else
        {
            rig.velocity = new Vector2(0f, 0f);
            anim.SetBool("move", false);
        }
    }
    public void Move(string di)
    {
        direction = di;
        moving = true;
    }
    public void Stop()
    {
        moving = false;
    }

}