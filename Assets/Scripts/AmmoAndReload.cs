using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoAndReload : MonoBehaviour
{

    public GameObject GlypsBagOn;
    public int SelectedGlyph = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int previousSelectedGlyph = SelectedGlyph;

        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (SelectedGlyph <= 0)
                SelectedGlyph = transform.childCount - 1;
            else
                SelectedGlyph--;
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {

            if (SelectedGlyph >= transform.childCount - 1)
                SelectedGlyph = 0;
            else
                SelectedGlyph++;
        }

        if (previousSelectedGlyph != SelectedGlyph)
        {
            SelectGlyph();
        }
    }

    public void SelectGlyph()
    {
        int i = 0;
        foreach (Transform glyph in transform)
        {
            if (i == SelectedGlyph)

                glyph.gameObject.SetActive(true);
            

            else

                glyph.gameObject.SetActive(false);

            i++;
        }
    }
}
