using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public hp[] aoi;
    public int etap;
    public bool ed;
    public bool boxer;
    public bool goroh;
    public bool dron;
    public Transform point;
    public float time;

    public GameObject[] me;
    public GameObject[] bx;

    public Text t;

    public Transform of;
    public GameObject on;
    public Transform cam;
    public GameObject eee;

    public Reiting ret;

    void Start()
    {
        etap = Data.lvl;
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "WALL")
        {
            if (boxer == false)
            {
                op();
            }
            else
            {
                boxer = false;
                me[0].GetComponent<Animator>().SetTrigger("удар");
                bx[0].SetActive(false);
                bx[1].SetActive(false);
                col.gameObject.GetComponent<Wall>().ooop = true;
            }
        }
    }
    void Update()
    {
        t.text = Data.moni.ToString("D1");
        if (aoi[0].Health > 0 && aoi[1].Health > 0 && aoi[2].Health > 0)
        {
            if (ed)
            {
                aoi[0].Health += 20;
                aoi[1].Health += 20;
                aoi[2].Health += 20;
                me[0].GetComponent<Animator>().SetTrigger("перекур");
                me[1].GetComponent<Animator>().SetTrigger("перекур");
                me[2].GetComponent<Animator>().SetTrigger("перекур");

                ed = false;
            }
            if (dron)
            {
                time += 0.05f;
                me[1].GetComponent<Animator>().SetTrigger("удар");
                bx[2].SetActive(true);
                if (time > 170)
                {
                    time = 0;
                    bx[2].SetActive(false);
                    dron = false;
                }
            }
            if (goroh)
            {
                me[2].GetComponent<Animator>().SetTrigger("удар");
                goroh = false;
            }
        }
        else
        {
            op();
        }
    }
    public void Buy()
    {
        if (Data.moni >= 100)
        {
            Data.moni -= 100;
            Data.lvl = etap;
            Application.LoadLevel(0);
        }
    }
    public void NO()
    {
        Application.LoadLevel(0);
    }
    public void XEXEXE()
    {
        Data.moni += 100;
    }
    void op()
    {
        Data.i1 += 1;
        Data.time += ret.time;
        Data.begin = true;
        if (etap != Data.lvl)
        {
            on.SetActive(true);
            transform.parent = null;
            of.parent = null;
            cam.parent = null;
            Destroy(eee);
        }
        else
        {
            Application.LoadLevel(0);
        }
    }
}
