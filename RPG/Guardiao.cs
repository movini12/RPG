using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class Guardiao 
    {
        public string nome;
        public int idade,luz;
        public Status status;
        public float defesatotal;

        public void Defesa()
        {
            (this.status.defesa + status.agilidade) * (1 + (status.sorte / 100))

            
        }


    }
}
