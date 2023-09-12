using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ArabicSupport;
using RTLTMPro;
using TMPro;

public class LanguageController : MonoBehaviour
{
     
    public string arabicString,englishString;
    public bool inverse;
    private void OnEnable()
    {
        if (inverse) 
        {

            if (GetComponent<Text>() != null)
            {
                if (PlayerPrefs.GetString("Language", "Ar").Equals("Ar"))
                {
                    GetComponent<Text>().text = englishString;

                }
                else
                {
                    GetComponent<Text>().text = ArabicFixer.Fix(arabicString);
                }
            }
            else
            {
                if (PlayerPrefs.GetString("Language", "Ar").Equals("Ar"))
                {
                    GetComponent<TextMeshProUGUI>().text = englishString;

                }
                else
                {
                    GetComponent<TextMeshProUGUI>().text = arabicString;
                }
            }
        }
        else
        {
            if (GetComponent<Text>() != null)
            {
                if (PlayerPrefs.GetString("Language", "Ar").Equals("Ar"))
                {

                    GetComponent<Text>().text = ArabicFixer.Fix(arabicString);
                }
                else
                {
                    GetComponent<Text>().text = englishString;
                }
            }
            else
            {
                if (PlayerPrefs.GetString("Language", "Ar").Equals("Ar"))
                {
                    GetComponent<TextMeshProUGUI>().text = arabicString;

                }
                else
                {
                    GetComponent<TextMeshProUGUI>().text = englishString;
                }
            }
        }
    }
}
