using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

namespace LiamDavis
{
    public class ContactDirectory : MonoBehaviour
    {
        [SerializeField] private List<PhoneBook> PhoneBook = new List<PhoneBook>();
        private void Start()
        {
            for(int i = 0; i < PhoneBook.Count; i++)
            {
                PhoneBook[i].Initialise();
            }
        }
    }
        
}
