using UnityEngine;
using UnityEngine.SceneManagement;

public class UserInterfaceButtons : MonoBehaviour
{
    public float scalingSpeed = 0.03f;
    public float rotationSpeed = 70.0f;
    public float translationSpeed = 5.0f;
    //	public GameObject Model;
    bool repeatScaleUp = false;
    bool repeatScaleDown = false;
    bool repeatRotateLeft = false;
    bool repeatRotateRight = false;
    bool repeatPositionUp = false;
    bool repeatPositionDown = false;
    bool repeatPositionLeft = false;
    bool repeatPositionRight = false;

    private void Start()
    {
        Debug.Log("ON START BAR = "+GameObject.FindWithTag("Model").transform.position.y);
    }

    void Update()
    {
        if (repeatScaleUp)
        {
            ScaleUpButton();
        }

        if (repeatScaleDown)
        {
            ScaleDownButton();
        }

        if (repeatRotateRight)
        {
            RotationRightButton();
        }

        if (repeatRotateLeft)
        {
            RotationLeftButton();
        }

        if (repeatPositionUp)
        {
            PositionUpButton();
        }

        if (repeatPositionDown)
        {
            PositionDownButton();
        }

        if (repeatPositionLeft)
        {
            PositionLeftButton();
        }

        if (repeatPositionRight)
        {
            PositionRightButton();
        }

    }

    public void CloseAppButton()
    {
        Application.Quit();
    }

    public void RotationRightButton()
    {
        // transform.Rotate (0, -rotationSpeed * Time.deltaTime, 0);
        GameObject.FindWithTag("Model").transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
    }

    public void RotationLeftButton()
    {
        // transform.Rotate (0, rotationSpeed * Time.deltaTime, 0);
        GameObject.FindWithTag("Model").transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }

    public void RotationRightButtonRepeat()
    {
        // transform.Rotate (0, -rotationSpeed * Time.deltaTime, 0);
        repeatRotateRight = true;
    }

    public void RotationLeftButtonRepeat()
    {
        // transform.Rotate (0, rotationSpeed * Time.deltaTime, 0);
        repeatRotateLeft = true;
    }

    public void ScaleUpButton()
    {
        // transform.localScale += new Vector3(scalingSpeed, scalingSpeed, scalingSpeed);
        //GameObject.FindWithTag("Model").transform.localScale += new Vector3(scalingSpeed, scalingSpeed, scalingSpeed);
        Debug.Log(GameObject.FindWithTag("Model").transform.rotation.eulerAngles.z);

        
        if (GameObject.FindWithTag("Model").transform.rotation.eulerAngles.z <= (8.0f) || GameObject.FindWithTag("Model").transform.rotation.eulerAngles.z - 1.3f >= (352.0f))
        {
            GameObject.FindWithTag("Model").transform.Translate(0, translationSpeed * Time.deltaTime, 0, Space.World);

            GameObject.FindWithTag("Model").transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime,Space.World);
        }
    }

    public void ScaleUpButtonRepeat()
    {
        repeatScaleUp = true;
        repeatPositionUp = false;
        Debug.Log("Up");
    }
    public void ScaleDownButtonRepeat()
    {
        repeatScaleDown = true;
        repeatPositionDown = false;
        Debug.Log("Down");
    }
    public void PositionDownButtonRepeat()
    {
        repeatPositionDown = true;
        repeatScaleDown = false;
    }
    public void PositionUpButtonRepeat()
    {
        repeatPositionUp = true;
        repeatScaleUp = false;
    }
    public void PositionLeftButtonRepeat()
    {
        repeatPositionLeft = true;
    }
    public void PositionRightButtonRepeat()
    {
        repeatPositionRight = true;
    }

    public void ScaleUpButtonOff()
    {
        repeatScaleUp = false;
        Debug.Log("Off");
    }
    public void ScaleDownButtonOff()
    {
        repeatScaleDown = false;
        Debug.Log("Off");
    }

    public void RotateLeftButtonOff()
    {
        repeatRotateLeft = false;
        Debug.Log("Off");
    }

    public void RotateRightButtonOff()
    {
        repeatRotateRight = false;
        Debug.Log("Off");
    }
    public void PositionRightButtonOff()
    {
        repeatPositionRight = false;
        Debug.Log("Off");
    }
    public void PositionLeftButtonOff()
    {
        repeatPositionLeft = false;
        Debug.Log("Off");
    }
    public void PositionUpButtonOff()
    {
        repeatPositionUp = false;
        Debug.Log("Off");
    }
    public void PositionDownButtonOff()
    {
        repeatPositionDown = false;
        Debug.Log("Off");
    }

    public void ScaleDownButton()
    {

        Debug.Log(GameObject.FindWithTag("Model").transform.rotation.eulerAngles.z);
        //// transform.localScale += new Vector3(-scalingSpeed, -scalingSpeed, -scalingSpeed);
        //GameObject.FindWithTag("Model").transform.localScale += new Vector3(-scalingSpeed, -scalingSpeed, -scalingSpeed);
        if (GameObject.FindWithTag("Model").transform.position.y > 49.57965)
        {
            if (GameObject.FindWithTag("Model").transform.rotation.eulerAngles.z + 1.3f <= (8.0f) || GameObject.FindWithTag("Model").transform.rotation.eulerAngles.z >= (352.0f))
            {
                //GameObject.FindWithTag("Model").transform.Translate(0, -translationSpeed * Time.deltaTime, 0);
                GameObject.FindWithTag("Model").transform.Translate(0, -translationSpeed * Time.deltaTime, 0, Space.World);
                GameObject.FindWithTag("Model").transform.Rotate(0, 0, rotationSpeed * Time.deltaTime, Space.World);
            }
        }
    }

    public void PositionUpButton()
    {
        Debug.Log(GameObject.FindWithTag("Model").transform.rotation.eulerAngles.z);
       
        if (GameObject.FindWithTag("Model").transform.rotation.eulerAngles.z + 1.3f <= (8.0f) || GameObject.FindWithTag("Model").transform.rotation.eulerAngles.z >= (352.0f))
        {
            GameObject.FindWithTag("Model").transform.Translate(0, translationSpeed * Time.deltaTime, 0, Space.World);
            GameObject.FindWithTag("Model").transform.Rotate(0, 0, rotationSpeed * Time.deltaTime, Space.World);

        }
        //GameObject.FindWithTag("Model").transform.Translate(0, translationSpeed * Time.deltaTime, 0);


    }

    public void PositionDownButton()
    {
        Debug.Log("POSITION: "+ GameObject.FindWithTag("Model").transform.position.y);
        if (GameObject.FindWithTag("Model").transform.position.y > 49.57965)
        {
            if (GameObject.FindWithTag("Model").transform.rotation.eulerAngles.z  <= (8.0f) || GameObject.FindWithTag("Model").transform.rotation.eulerAngles.z - 1.3f >= (352.0f))
            {
                //GameObject.FindWithTag("Model").transform.Translate(0, -translationSpeed * Time.deltaTime, 0);
                GameObject.FindWithTag("Model").transform.Translate(0, -translationSpeed * Time.deltaTime, 0, Space.World);
                GameObject.FindWithTag("Model").transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime, Space.World);

                //Debug.Log(GameObject.FindWithTag("Model").transform.rotation.eulerAngles.z);
            }
        }
    }

    public void PositionRightButton()
    {
        GameObject.FindWithTag("Model").transform.Translate(-translationSpeed * Time.deltaTime, 0, 0);
    }

    public void PositionLeftButton()
    {
        GameObject.FindWithTag("Model").transform.Translate(translationSpeed * Time.deltaTime, 0, 0);  // backward
    }

    public void ChangeScene(string a)
    {
        //#pragma warning disable CS0618 // Type or member is obsolete
        //        Application.LoadLevel(a);
        //#pragma warning restore CS0618 // Type or member is obsolete

        SceneManager.LoadScene(a);
    }

    public void AnyButton()
    {
        Debug.Log("Any");
    }
}
