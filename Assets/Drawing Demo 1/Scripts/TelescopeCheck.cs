using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TelescopeCheck : MonoBehaviour
{
    public Sprite sprite;  
    public Sprite highlightSprite; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButton(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);
            if (hit != false)
            {
                if (hit.collider.transform == this.transform)
                {
                    StartCoroutine(EndCheck());
                }
            }
        }
    }

    private void OnMouseEnter()
    {
        if (
            CheckScript.drawing_1_Complete &&
            CheckScript.drawing_2_Complete &&
            CheckScript.drawing_3_Complete)
        {  
                transform.GetComponent<SpriteRenderer>().sprite = highlightSprite;
        } 
    }

    private void OnMouseExit()
    {
        transform.GetComponent<SpriteRenderer>().sprite = sprite; 
        
    }

    IEnumerator EndCheck()
    {
        if (
            CheckScript.drawing_1_Complete &&
            CheckScript.drawing_2_Complete &&
            CheckScript.drawing_3_Complete)
        {
            SceneController.setDrawn();
            SceneManager.LoadScene(sceneName: "End Scene");

        }
        else
        {
            Debug.Log("You seem to be missing a drawing");
        }
        yield return null;
    }
}
