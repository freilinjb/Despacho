﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
    public class Consultar : Conexion
    {
        public static DataSet Ejecutar(string cmd)
        {
            Debug.WriteLine($"Depuraion: {cmd}");
            DataSet data = new DataSet();
            try
            {
                connection.Open();
                var adapter = new SqlDataAdapter(cmd, connection);
                adapter.Fill(data);
            }
            catch (ArgumentException ex)
            {
                //RadMessageBox.Show(null, "INFORMACION DEL SISTEMA", "adsfaf", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1, RightToLeft.Yes, ex.Message);
                MessageBox.Show("HA OCURRIDO UN ERROR", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, ex.Message);
            }
            finally
            {
                Conexion.connection.Close();
            }
            return data;
        }

    }
}
