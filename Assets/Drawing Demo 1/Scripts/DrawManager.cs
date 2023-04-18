using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawManager : MonoBehaviour
{
    private Camera _cam;
    [SerializeField] private Line _linePrefab;

    public static bool resetLines = false;

    public const float RESOLUTION = 0.1f;

    private Line _currentLine;

    private List<Line> _lines;

    void Start()
    {
        _cam = Camera.main;
        _lines = new List<Line>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);

        if (OnPage.validDraw == true && _cam.transform.position.x > -300 && _cam.transform.position.x < -250)
        {
            //Debug.Log("validDraw");
            if (Input.GetMouseButtonDown(0)) { 
                _currentLine = Instantiate(_linePrefab, mousePos, Quaternion.identity); 
                _lines.Add(_currentLine);
            } 
            if (Input.GetMouseButton(0) && _currentLine != null) {
                    _currentLine.SetPosition(mousePos);
            }
        }
    }

    public void Delete()
    {
        Debug.Log("Delete Clicked!");
        StartCoroutine(Deleting());
     //   StartCoroutine(resetLine());
        _lines.Clear();
    }

    IEnumerator Deleting()
    {
    
        Debug.Log(_lines.Count);
        for (int i = 0; i < _lines.Count; i++)
        {
            Debug.Log(_lines[i]);
            Object.Destroy(_lines[i].gameObject);
        }
        yield return null;
    }

    /*
    IEnumerator resetLine()
    {
        resetLines = true;
        new WaitForSeconds(.1f);
        resetLines = false;
        yield return null;


    }
    */
}
