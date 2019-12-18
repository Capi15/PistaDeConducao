using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PistaDeConducao
{
    class Pistas
    {
        
        int mouseX;
        int mouseY;
        List<String> linhas = new List<String>();
        AreaDeJogo pontos;

        
        public Pistas()
        {
            System.IO.File.WriteAllText(@"./../Pistas.txt", pontos.Pontos.ToString());
        }
    }
}
