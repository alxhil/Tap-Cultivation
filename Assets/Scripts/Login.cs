using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour {

    

    public InputField nameField;
    public InputField passwordField;
    public Text errorText;
    public static string wwwText;

    public Button submitButton;

    public void CallLogin()
    {
        StartCoroutine(LoginPlayer());
    }

    IEnumerator LoginPlayer()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", nameField.text);
        form.AddField("password", passwordField.text);
        WWW www = new WWW("http://tapcultivation.com/mysql/loginweb.php", form);
        yield return www;
        wwwText = www.text;
        if(www.text[0] == '0')
        {
            dbManager.username = nameField.text;
            dbManager.spiritstone = int.Parse(www.text.Split('\t')[1]);
            Debug.Log(dbManager.spiritstone);
            UnityEngine.SceneManagement.SceneManager.LoadScene(3);
        } else
        {

            errorText.text = "User login failed Error #" +www.text;
        }

    }

    public void VerifyInputs()
    {
        submitButton.interactable = (nameField.text.Length >= 3 && passwordField.text.Length >= 6);
    }

    public void errorCode()
    {
        errorText.text = "Error Code: " + wwwText;
    }

    

}
