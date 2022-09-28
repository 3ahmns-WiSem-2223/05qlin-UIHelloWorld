using TMPro;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public TextMeshProUGUI zahl;
    public int number;
    public bool stop = false;
  

    public void Add()
    {
        number = number +1;
        zahl.text = number.ToString();
    }

    public void Subtract()
    {

        number = number -1;
        zahl.text = number.ToString();
    }

    private void Update()
    {
        number = int.Parse(zahl.text);

        if (number >= 1000000 || number <= -1000000)
        {
            stop = true;
        }
        else
        {
            stop = false;
        }
    }

    public void SetZero()
    {
        number = 0;
        zahl.text = number.ToString();
    }

    public void Zero()
    {
        if (number == 0)
        {
            zahl.text = number.ToString();
        }
        else if (stop != true)
        {
            number = 0;
            zahl.text += number.ToString();
        }
    }

    public void One()
    {

        if (number == 0)
        {
            number = 1;
            zahl.text = number.ToString();
        }
        else if (stop != true)
        {
            number = 1;
            zahl.text += number.ToString();
        }
    }

    public void Two()
    {
        if (number == 0)
        {
            number = 2;
            zahl.text = number.ToString();
        }
        else if (stop != true)
        {
            number = 2;
            zahl.text += number.ToString();
        }
    }

    public void Three()
    {
        if (number == 0)
        {
            number = 3;
            zahl.text = number.ToString();
        }
        else if (stop != true)
        {
            number = 3;
            zahl.text += number.ToString();
        }
    }

    public void Four()
    {
        if (number == 0)
        {
            number = 4;
            zahl.text = number.ToString();
        }
        else if (stop != true)
        {
            number = 4;
            zahl.text += number.ToString();
        }
    }

    public void Five()
    {
        if (number == 0)
        {
            number = 5;
            zahl.text = number.ToString();
        }
        else if (stop != true)
        {
            number = 5;
            zahl.text += number.ToString();
        }
    }

    public void Six()
    {
        if (number == 0)
        {
            number = 6;
            zahl.text = number.ToString();
        }
        else if (stop != true)
        {
            number = 6;
            zahl.text += number.ToString();
        }
    }

    public void Seven()
    {
        if (number == 0)
        {
            number = 7;
            zahl.text = number.ToString();
        }
        else if (stop != true)
        {
            number = 7;
            zahl.text += number.ToString();
        }
    }

    public void Eight()
    {
        if (number == 0)
        {
            number = 8;
            zahl.text = number.ToString();
        }
        else if(stop != true)
        {
            number = 8;
            zahl.text += number.ToString();
        }
    }

    public void Nine()
    {
        if (number == 0)
        {
            number = 9;
            zahl.text = number.ToString();
        }
        else if(stop != true)
        {
            number = 9;
            zahl.text += number.ToString();
        }
    }
}
