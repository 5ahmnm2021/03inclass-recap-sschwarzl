using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    //Change Scene 
    public void ChangeSzene00()
    {
        SceneManager.LoadScene("00WelcomeScene");
    }
    
    public void ChangeScene01()
    {
        SceneManager.LoadScene("01ColorScene");
    }

    public void ChangeScene02()
    {
        SceneManager.LoadScene("02NumberScene");
    }


    //Random Color (01ColorScene)
    public Image colorField;
    public void RandomColor()
    {
        Color[] colors =
        {
            new Color32 (255, 205, 25, 100),
            new Color32 (95, 34, 0, 100),
            new Color32 (207, 63, 21, 100),
            new Color32 (103, 47, 84, 100),
        };

        if (Input.GetKeyDown("space"))
        {
            colorField.color = colors[Random.Range(0, colors.Length)];
        }
    }

    void Update()
    {
        RandomColor();
    }

    //Number Addition (02NumberScene)
    public InputField ifA;
    public InputField ifB;

    public Text result;
    public Text message;

    private bool aFloat = true;
    private bool bFloat = true;

    public void AddNumbers()
    {
        float ifAFloat = 0;
        float ifBFloat = 0;
        string errorMsg = "Geben Sie eine Zahl ein";

        try
        {
            ifAFloat = float.Parse(ifA.text);
            ifA.image.color = Color.white;
            message.text = "ADD NUMBERS";
            aFloat = true;
        }
        catch (System.Exception)
        {
            message.text = errorMsg;
            ifA.image.color = Color.red;
            aFloat = false;
        }

        try
        {
            ifBFloat = float.Parse(ifB.text);
            ifB.image.color = Color.white;
            bFloat = true;
        }
        catch (System.Exception)
        {
            message.text = errorMsg;
            ifB.image.color = Color.red;
            bFloat = false;
        }

        if (aFloat && bFloat)
        {
            result.text = (ifAFloat + ifBFloat).ToString();
        }
    }
}
