using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace SisOxi.WinUI
{
    public partial class ProtocoloUI : Telerik.WinControls.UI.RadForm
    {
        TratamientoCamaraHiperbaricaUI tratamiento;

        public ProtocoloUI()
        {
            InitializeComponent();
        }

        public ProtocoloUI(TratamientoCamaraHiperbaricaUI t)
        {
            InitializeComponent();
            tratamiento = t;
        }

        private void ProtocoloUI_Load(object sender, EventArgs e)
        {
            cargarTablaDeConversiones();
            WinFormTelerikDS.WinForm.ConvertirBordesRedondeadosLabelEnForm(this);
        }

        private void cargarTablaDeConversiones()
        {
            string[] cabecera ={"Profundidad","PSI","PIES","ATS"};
            double[] PSI = { 7.35,8.82,10.30,11.70,13.20,14.70,16.20,17.60,19.0,20.50,22.0,23.5,25.0,27.0,28.0,29.4};
            double[] PIES = { 16.5,19.8,23.0,27.0,28.7,33.0,36.3,39.0,43.0,46.2,49.0,52.8,56.0,60.0,62.7,66.0 };
            string[] ATS = { "1' 5","1' 6","1' 7", "1' 8","1' 9","2' 0","2' 1","2' 2","2' 3","2' 4","2' 5","2' 6","2' 7","2' 8","2' 9","3' 0" };
            
            DataTable dt = new DataTable();
            for (int i = 0; i < 4; i++)
            {
                dt.Columns.Add(cabecera[i]);
            }
            
            for (int i = 0; i < 16; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = (i + 1);
                dr[1] = PSI[i];
                dr[2] = PIES[i];
                dr[3] = ATS[i];
                dt.Rows.Add(dr);
            }
            dgvTablaDeConversiones.DataSource = dt;
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            string protocolo=dgvTablaDeConversiones.SelectedRows[0].Cells[0].Value.ToString();


            if (rbtA.Checked == true)
            {
                protocolo += "A";
            }
            else if (rbtB.Checked == true)
            {
                protocolo += "B";
            }
            else if (rbtC.Checked == true)
            {
                protocolo += "C";
            }
            else if (rbtD.Checked == true)
            {
                protocolo += "D";
            }
            else
            {
                protocolo = "Otros";
            }


            tratamiento.RecibirProtocolo(protocolo);
            this.Close();
        }
    }
}
