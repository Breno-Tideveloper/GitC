using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject.Model
{
    

    public class Informacao : Form1
    {

        public Informacao ()
        {
                
        }

        public bool Ativo { get; set; } = true;
        public int UsuInc { get; set; } = Usuario;
        public int UsuAlt { get; set; } = Usuario;
        public DateTime DatInc { get; set; } = DateTime.Now;
        public DateTime DatAlt { get; set; } = DateTime.Now;

    }
}
