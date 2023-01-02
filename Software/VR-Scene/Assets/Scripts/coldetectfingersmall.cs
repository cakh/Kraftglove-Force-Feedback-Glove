using UnityEngine;
public class coldetectfingersmall : coldetectthumbsmall
{
    string fingertag;
    int fingerno;
    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "cube" || collision.gameObject.tag == "heart")
        {
            fingertag = this.gameObject.tag;
            fingerno = int.Parse(fingertag);
            objectnamefinger = collision.gameObject.name;
            if (0 < fingerno && fingerno < 4) colfin[fingerno] = true; 
        }
    }
    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "cube" || collision.gameObject.tag == "heart")
        {
            fingertag = this.gameObject.tag;
            fingerno = int.Parse(fingertag);
            objectnamefinger = null;
            if (0 < fingerno && fingerno < 4) colfin[fingerno] = false;
        }
    }
}
