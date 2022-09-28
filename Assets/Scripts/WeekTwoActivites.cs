using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace LiamDavis
{
    public class WeekTwoActivites : MonoBehaviour
    {
        private string favouritegame = "Max Payne 3";
        private int hourPlayed = 300;
        private float costOfGame = 60f;

        

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log(" hello world " + " My Favourite game is " + favouritegame + hourPlayed + costOfGame);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}