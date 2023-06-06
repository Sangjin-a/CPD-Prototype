using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public Transform moveGoal;
    public float speed;

    private Transform playerTR;
    private Animator anim;

    public Button[] btns;
    private void Awake()
    {
        // btns = new Button[10];
        playerTR = gameObject.transform;
        anim = gameObject.GetComponent<Animator>();
    }
    void Start()
    {
        foreach (Button a in btns)
        {
            Debug.Log(a);
            //a.ge
        }
    }

    // Update is called once per frame
    void Update()
    {
        playerTR.position = Vector3.MoveTowards(playerTR.position, moveGoal.position, Time.deltaTime * speed);
    }
    public void PlayerMove()
    {
        StartCoroutine("Move");
    }
    IEnumerator Move()
    {
        btns[0].GetComponentInChildren<TextMeshProUGUI>().text = "STOP";
        anim.SetBool("isMove", true);
        while (true)
        {                       
            playerTR.position = Vector3.MoveTowards(playerTR.position, moveGoal.position, Time.deltaTime * speed);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
