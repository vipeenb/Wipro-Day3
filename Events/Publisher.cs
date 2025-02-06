﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Events
{
    public delegate void DelEvent();
    internal class Publisher
    {
        public event DelEvent SampEvent; //Event creation
        //public event EventHandler MyEvnt;
        public void Initiate()
        {
            Console.WriteLine("Event Started");
            RaiseEvent();
        }
        public void RaiseEvent()
        {
            SampEvent?.Invoke(); //Invoke the subsrciber methods
        }
    }
}
