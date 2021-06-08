using System;
using System.Collections.Generic;

#nullable disable

namespace TutorialEntityFrameWorkCore.Model
{
    public partial class Mascotas
    {
        public int MascotaId { get; set; }
        public string Nombre { get; set; }
        public string Raza { get; set; }
    }
}
