using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class noteDetector : MonoBehaviour
{

    public LayerMask noPlayer;
    public TextMeshProUGUI scoreUI;
    public int Scorecount;


    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        Collider2D collider = Physics2D.OverlapCircle(new Vector2(transform.position.x, transform.position.y), noPlayer);
        if (collider != null)
        {
            if (Input.GetKeyDown("space") && collider.gameObject.name != "triggerzone")
            {
                Scorecount++;

                scoreUI.text = Scorecount.ToString();
                Destroy(collider.gameObject);
            }
            else
            {


            }
            Debug.Log("up key was pressed");

        }
        Debug.Log(collider.gameObject.name);
    }
}