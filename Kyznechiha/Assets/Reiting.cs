using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Reiting : MonoBehaviour
{
    public Text[] i;
    public float time;
    public bool end;

    void Update()
    {
        if (end)
        {
            i[0].text = "Белгород пернул " + Data.i4.ToString("D1") + " раз";
            i[1].text = "Жёлудь сломал " + Data.i3.ToString("D1") + " построек";
            i[2].text = "Джамал разъебал " + Data.i5.ToString("D1") + " дронов";

            i[3].text = "А вмести они \n " +
                         "Спиздили " + Data.moni.ToString("D1") + " рублей\n" +
                         "Наебнулись " + Data.i1.ToString("D1") + " раз\n" +
                         "Выкурили " + Data.i2.ToString("D1") + " ашек";


            if (Data.i1 == 0)
            {
                int minutes = Mathf.FloorToInt(Data.time / 60);
                int seconds = Mathf.FloorToInt(Data.time % 60);
                i[4].text = "Время прохождения " + minutes.ToString("D2") + ":" + seconds.ToString("D2");
                time = 0;
            }
            else
            {
                int minutes = Mathf.FloorToInt(time / 60);
                int seconds = Mathf.FloorToInt(time % 60);
                i[4].text = "Время прохождения " + minutes.ToString("D2") + ":" + seconds.ToString("D2");

            }
        }
        else
        {
            time += Time.deltaTime;
        }
    }
}
