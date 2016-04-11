using UnityEngine;
using System.Collections;

public class Timing : MonoBehaviour
{
    public bool _isRed;
    public bool _isGreen;
    public bool _isBlue;
    public bool _isYellow;
    private float time = 1;
    public GameObject buttonRed;
    public GameObject buttonGreen;
    public GameObject buttonBlue;
    public GameObject buttonYellow;

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
        buttonRed.SetActive(true);
        _isRed = true;

        yield return new WaitForSeconds(time);
        _isRed = false;
        buttonRed.SetActive(false);
    }

    IEnumerator PressGreen()
    {
        buttonGreen.SetActive(true);
        _isGreen = true;

        yield return new WaitForSeconds(time);
        _isGreen = false;
        buttonGreen.SetActive(false);
    }

    IEnumerator PressBlue()
    {
        buttonBlue.SetActive(true);
        _isBlue = true;

        yield return new WaitForSeconds(time);
        _isBlue = false;
        buttonBlue.SetActive(false);
    }

    IEnumerator PressYellow()
    {
        buttonYellow.SetActive(true);
        _isYellow = true;

        yield return new WaitForSeconds(time);
        _isYellow = false;
        buttonYellow.SetActive(false);
    }
}
