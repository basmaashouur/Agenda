using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Agenda_Rework
{   
    [Serializable()] 
    public class config
    {
        public bool Appointments;
        public bool todo;
        public bool uni_school;
        public bool self_study;
        public bool towatch;
        public bool toread;
        public MetroFramework.MetroColorStyle style;
        
        public config()
        {
            Appointments=todo=uni_school=self_study=towatch=toread = true; 
        }
       
        
    }
}
