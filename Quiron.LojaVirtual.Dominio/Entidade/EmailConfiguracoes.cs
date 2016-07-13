using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quiron.LojaVirtual.Dominio.Entidade
{
    public class EmailConfiguracoes
    {
        public bool UsarSsl { get; set; }

        public string ServidorSmtp = "smtp.aminformatica.net.br";

        public int PortaServidor = 587;

        public string Usuario = "mtavares@aminformatica.net.br";

        public bool EscreverArquivo = false;

        public string PastaArquivo = @"c:\envioemail";

        public string De = "mtavares@aminformatica.net.br";

        public string Para = "mtavares@aminformatica.net.br";
    }
}
