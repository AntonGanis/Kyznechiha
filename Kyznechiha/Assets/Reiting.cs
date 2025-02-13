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
            i[0].text = "�������� ������ " + Data.i4.ToString("D1") + " ���";
            i[1].text = "Ƹ���� ������ " + Data.i3.ToString("D1") + " ��������";
            i[2].text = "������ �������� " + Data.i5.ToString("D1") + " ������";

            i[3].text = "� ������ ��� \n " +
                         "�������� " + Data.moni.ToString("D1") + " ������\n" +
                         "���������� " + Data.i1.ToString("D1") + " ���\n" +
                         "�������� " + Data.i2.ToString("D1") + " ����";


            if (Data.i1 == 0)
            {
                int minutes = Mathf.FloorToInt(Data.time / 60);
                int seconds = Mathf.FloorToInt(Data.time % 60);
                i[4].text = "����� ����������� " + minutes.ToString("D2") + ":" + seconds.ToString("D2");
                time = 0;
            }
            else
            {
                int minutes = Mathf.FloorToInt(time / 60);
                int seconds = Mathf.FloorToInt(time % 60);
                i[4].text = "����� ����������� " + minutes.ToString("D2") + ":" + seconds.ToString("D2");

            }
        }
        else
        {
            time += Time.deltaTime;
        }
    }
}
