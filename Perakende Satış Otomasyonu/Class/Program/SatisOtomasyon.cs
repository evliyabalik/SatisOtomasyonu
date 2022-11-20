using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perakende_Satış_Otomasyonu.Class.Program
{
    public class SatisOtomasyon: Form
    {
        //public void SetArraysNull(params string[][] arrays)
        //{
        //    for (int i = 0; i < arrays.Length; i++)
        //    {
        //        for (int j = 0; j < arrays[i].Length; j++)
        //        {
        //            arrays[i][j] = null;
        //        }
        //    }
        //}

        public void NewProductClick(params TextBox[] textBoxes)
        {
            for (int i = 0; i < textBoxes.Length; i++)
            {
                textBoxes[i].Text = null;
            }
        }
        public void NewProductClick(params ComboBox[] comboBoxes)
        {
            for (int i = 0; i < comboBoxes.Length; i++)
            {
                comboBoxes[i].Text = comboBoxes[i].Items[0].ToString();
            }
        }
    }
}
