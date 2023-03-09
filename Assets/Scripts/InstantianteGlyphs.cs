
using UnityEngine;

public class InstantianteGlyphs : MonoBehaviour
{

    public int SelectedGlyph = 0;

    void Start()
    {
        SelectGlyph();
    }

    private void Update()
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

        if(previousSelectedGlyph != SelectedGlyph)
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
