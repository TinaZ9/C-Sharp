using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Ball
    {
        private int roll;
        private int jump;
        private string contact="";
        


        //Setters
        public void setRoll(int roll)
        {
            this.roll = roll;
        }

        public void setJump(int jump)
        {
            this.jump = jump;
        }

        public void setContact(string contact)
        {
            this.contact = contact;
        }


        //Getters
        public int getRoll()
        {
            return this.roll;
        }

        public int getJump()
        {
            return this.jump;
        }

        public string getContact()
        {
            return this.contact;
        }


    }
}
