using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GazeSelect : MonoBehaviour
{
    bool gaze = false;
    float timer = 0f;
    public GameObject card1;
    public void GazeOn()
    {
        gaze = true;
    }
    public void GazeOff()
    {
        gaze = false;
        timer = 0f;
    }
    // Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    void Update()
    {
        if (gaze)
        {
            timer += Time.deltaTime;
            if (timer >= 3f)
            {
                timer = 0f;
                gaze = false;
                gameObject.GetComponent<Transform>().localScale = new Vector3(2f, 2f, 2f);
                //while (timer < 9f)
                //{
                //    timer += Time.deltaTime;
                //    Instantiate(card1, new Vector3(2.0f,0,0),Quaternion.identity);
                //} 
                //Destroy(gameObject);
                //timer = 0f;
                //gaze = false;
                //gameObject.GetComponent<Button>().onClick.Invoke();

            }

        }
    }
}