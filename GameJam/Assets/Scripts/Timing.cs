using UnityEngine;
using System.Collections;

public class Timing : MonoBehaviour
{
    public bool _isRed;
    public bool _isGreen;
    public bool _isBlue;
    public bool _isYellow;
    private float time = 1;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Red")
            StartCoroutine(PressRed());

        else if (coll.gameObject.tag == "Green")
            StartCoroutine(PressGreen());

        else if (coll.gameObject.tag == "Blue")
            StartCoroutine(PressBlue());

        else if (coll.gameObject.tag == "Yellow")
            StartCoroutine(PressYellow());

    }

    IEnumerator PressRed()
    {
        _isRed = true;
        
        yield return new WaitForSeconds(time);
        _isRed = false;
    }

    IEnumerator PressGreen()
    {
        _isGreen = true;

        yield return new WaitForSeconds(time);
        _isGreen = false;
    }

    IEnumerator PressBlue()
    {
        _isBlue = true;

        yield return new WaitForSeconds(time);
        _isBlue = false;
    }

    IEnumerator PressYellow()
    {
        _isYellow = true;

        yield return new WaitForSeconds(time);
        _isYellow = false;
    }
}
