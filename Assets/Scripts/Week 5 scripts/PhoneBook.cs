using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace LiamDavis
{
    public enum Specimen 
    { 
        JeffPawnstein, Johnstonathen, ThighHackmen, Undefined
    }

    public class PhoneBook : MonoBehaviour
    {
        [SerializeField] private Specimen chooseSpecimen = Specimen.Undefined;
        [SerializeField] private string firstName;
        [SerializeField] private string lastName;
        [SerializeField] private string preferdName;
        [SerializeField] private string phoneNumber;
        [SerializeField] private string address;
        [SerializeField] private string email;        

        public void Initialise()
        {           
            switch (chooseSpecimen)
            {
                case Specimen.JeffPawnstein:
                    SetupJeff();
                    break;
                case Specimen.Johnstonathen:
                    SetupJohnstonathen();
                    break;
                case Specimen.ThighHackmen:
                    SetupThigh();
                    break;
                case Specimen.Undefined:
                    break;
                default:
                    break;
            }
        }

        private void SetupJohnstonathen()
        {
            firstName = "Tigh";
            lastName = "Tanus";
            preferdName = "johnstonathen";
            phoneNumber = "1800 8487";
            address = "19 blind chicken coup dr";
            email = "bahonkadonk@bigbehinds.com";
        }
        private void SetupJeff()
        {
            firstName = "Jeff";
            lastName = "Pawnstein";
            preferdName = "Jeff Pawnstein";
            phoneNumber = "5333 729678346";
            address = "1 Jeff Pawnstein ave, 1000";
            email = "JeffPawnstein@JeffPawnstien.JP";
        }
        private void SetupThigh()
        {
            firstName = "Thigh";
            lastName = "Hackmen";
            preferdName = "Big Thighs";
            phoneNumber = "9569 6995";
            address = "Where I walk is my home dr";
            email = "JeffPawnstein@JeffPawnstien.JP";
        }
    }
}
