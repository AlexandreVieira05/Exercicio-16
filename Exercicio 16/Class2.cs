using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_16
{
    internal class fechafrms
    {
        public static void fecharfrm()       //fechafrms.fecharfrm();
        {
            var fecharform = Application.OpenForms.Cast<Form>().ToList();
            foreach (Form frm in fecharform)
            {
                frm.Close();
            }
        }
    }
}
