using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Monetization;

public class AdShow : MonoBehaviour
{

    private string adid = "3234202";
    private string videoad = "video";
    // Start is called before the first frame update
    void Start()
    {
        Monetization.Initialize(adid,true);
    }

    public void Adshower()
    {
        if (Monetization.IsReady(videoad))
        {
            ShowAdPlacementContent ad = null;
            ad = Monetization.GetPlacementContent(videoad) as ShowAdPlacementContent;
            if (ad != null)
            {
                ad.Show();
            }
        }
    }

}
