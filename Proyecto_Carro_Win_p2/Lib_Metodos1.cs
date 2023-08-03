using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Proyecto_Carro_Win_p3
{
    class Lib_Metodos1
    {
        //public static String ConnectionString = "Data Source=SQL2005;Initial Catalog=Proyecto_Carro;User ID=sa;Password=armenteros";
        public static String ConnectionString = "Data Source=.;Initial Catalog=Proyecto_Carro;Integrated Security = true";
        public static SqlConnection ConexionSQL;

            
        public static DataTable Retorna_tabla()
        {
            string sqlSelect = "SELECT Nro_producto, Descripcion, Unidades_inventario, Precio, Modelo, " +
                               " Valor = (Unidades_inventario*Precio) FROM Carros";

            // Create a data adapter
            SqlDataAdapter da = new SqlDataAdapter(sqlSelect, ConnectionString);

            // Fill a DataTable using DataAdapter and output to console
            DataTable dt = new DataTable();
            da.Fill(dt);

            //Console.WriteLine("---DataTable---");
            //foreach (DataRow row in dt.Rows)
            //    Console.WriteLine("{0} {1} {2} {3} {4} {5}", row[0], row[1], row[2], row[3], row[4], row[5]);

            return dt;
        }

        public static void GuardarCarro(CarroSub ObjCarro)
        {
            SqlConnection cn;
            String strSQL;
            SqlCommandBuilder cb;
            SqlDataAdapter da;
            DataSet ds;
            DataRow dr; 
            Boolean ActionAdd;

            cn = new SqlConnection();
            cn.ConnectionString = ConnectionString;
            cn.Open();

            strSQL = "SELECT Nro_producto, Descripcion, Unidades_inventario, Precio, Modelo " +
                     " FROM Carros WHERE Nro_producto = '" + ObjCarro.Nro_producto + "'";
            da = new SqlDataAdapter(strSQL, cn);
            ds = new DataSet();
            da.Fill(ds, "mydata");

            ActionAdd = false;
            if (ds.Tables[0].Rows.Count == 0)
            {
                ActionAdd = true;
                dr = ds.Tables[0].NewRow();
                dr["Nro_producto"] = ObjCarro.Nro_producto;
            }
            else
            {
                dr = ds.Tables[0].Rows[0];
            }

            dr["Descripcion"] = ObjCarro.Descripcion;
            dr["Unidades_inventario"] = ObjCarro.Unidades_inventario;
            dr["Precio"] = ObjCarro.Precio;
            dr["Modelo"] = ObjCarro.Modelo;

            if(ActionAdd == true)
            {
                ds.Tables[0].Rows.Add(dr);
            }

            try
            {
                cb = new SqlCommandBuilder(da);
                da.InsertCommand = cb.GetInsertCommand();
                da.UpdateCommand = cb.GetUpdateCommand();

                da.Update(ds, "mydata");
                ds.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString());
            }
        
        }

        public static void ActualizarInventario(Factura_Item ObjItem)
        {
            SqlConnection cn;
            String strSQL;
            SqlCommandBuilder cb;
            SqlDataAdapter da;
            DataSet ds;
            DataRow dr;
            Boolean ActionAdd;

            cn = new SqlConnection();
            cn.ConnectionString = ConnectionString;
            cn.Open();

            strSQL = "SELECT Nro_producto, Descripcion, Unidades_inventario, Precio, Modelo " +
                     " FROM Carros WHERE Nro_producto = '" + ObjItem.Nro_producto + "'";
            da = new SqlDataAdapter(strSQL, cn);
            ds = new DataSet();
            da.Fill(ds, "mydata");

            ActionAdd = false;
            if (ds.Tables[0].Rows.Count == 0)
            {
                ActionAdd = true;
                dr = ds.Tables[0].NewRow();
                dr["Nro_producto"] = ObjItem.Nro_producto;
            }
            else
            {
                dr = ds.Tables[0].Rows[0];
            }

            //dr["Descripcion"] = ObjCarro.Descripcion;
            dr["Unidades_inventario"] = Int32.Parse(dr["Unidades_inventario"].ToString())-ObjItem.Unidades;
            //dr["Precio"] = ObjCarro.Precio;
            //dr["Modelo"] = ObjCarro.Modelo;

            if (ActionAdd == true)
            {
                ds.Tables[0].Rows.Add(dr);
            }

            try
            {
                cb = new SqlCommandBuilder(da);
                da.InsertCommand = cb.GetInsertCommand();
                da.UpdateCommand = cb.GetUpdateCommand();

                da.Update(ds, "mydata");
                ds.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString());
            }

        }

        public static void GuardarFacturaItem(Factura_Item ObjItem)
        {
            SqlConnection cn;
            String strSQL;
            SqlCommandBuilder cb;
            SqlDataAdapter da;
            DataSet ds;
            DataRow dr;
            Boolean ActionAdd;

            cn = new SqlConnection();
            cn.ConnectionString = ConnectionString;
            cn.Open();

            strSQL = "SELECT Nro_factura, Nro_producto, Unidades, Precio " +
                     " FROM Facturas_Items WHERE Nro_factura = '" + ObjItem.Nro_factura + "'";
            da = new SqlDataAdapter(strSQL, cn);
            ds = new DataSet();
            da.Fill(ds, "mydata");

            ActionAdd = true;
            dr = ds.Tables[0].NewRow();
            dr["Nro_factura"] = ObjItem.Nro_factura;
            dr["Nro_producto"] = ObjItem.Nro_producto;
            dr["Unidades"] = ObjItem.Unidades;
            dr["Precio"] = ObjItem.Precio;

            if (ActionAdd == true)
            {
                ds.Tables[0].Rows.Add(dr);
            }

            try
            {
                cb = new SqlCommandBuilder(da);
                da.InsertCommand = cb.GetInsertCommand();

                da.Update(ds, "mydata");
                ds.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString());
            }

        }


        public static void EliminarCarro(String Nro_Carro)
        {
            String strSQL;
            SqlConnection cn;
            SqlCommand cm;

            cn = new SqlConnection();
            cn.ConnectionString = ConnectionString;
            cn.Open();

            strSQL = "DELETE FROM Carros WHERE Nro_producto = '" + Nro_Carro + "'";

            cm = new SqlCommand(strSQL);
            cm.Connection = cn;
            cm.ExecuteNonQuery();
        }

        public static CarroSub ObtenerCarro(String Nro_Carro)
        {

            string sqlSelect = "SELECT Nro_producto, Descripcion, Unidades_inventario, Precio, Modelo " +
                               " FROM Carros WHERE Nro_producto = '" + Nro_Carro + "'";

            CarroSub ObjCarro = null;
            try
            {
                // Create a data adapter
                SqlDataAdapter da = new SqlDataAdapter(sqlSelect, ConnectionString);

                // Fill a DataTable using DataAdapter and output to console
                DataTable dt = new DataTable();
                da.Fill(dt);

                //Se crea el objeto de CarroSub
                ObjCarro = new CarroSub();

                if (dt.Rows.Count > 0)
                {
                    ObjCarro.Nro_producto = dt.Rows[0][0].ToString();
                    ObjCarro.Descripcion = dt.Rows[0][1].ToString();
                    ObjCarro.Unidades_inventario = (int)dt.Rows[0][2];
                    ObjCarro.Precio = Double.Parse(dt.Rows[0][3].ToString());
                    ObjCarro.Modelo = dt.Rows[0][4].ToString();
                }
                else {
                    MessageBox.Show("No existe este registro");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos");
            }
            
            return ObjCarro;
        }

        public static CarroSub ObtenerCarro_primero()
        {

            string sqlSelect = "SELECT TOP 1 Nro_producto, Descripcion, Unidades_inventario, Precio, Modelo " +
                               " FROM Carros ORDER BY Nro_producto";

            CarroSub ObjCarro = null;
            try
            {
                // Create a data adapter
                SqlDataAdapter da = new SqlDataAdapter(sqlSelect, ConnectionString);

                // Fill a DataTable using DataAdapter and output to console
                DataTable dt = new DataTable();
                da.Fill(dt);

                //Se crea el objeto de CarroSub
                ObjCarro = new CarroSub();

                if (dt.Rows.Count > 0)
                {
                    ObjCarro.Nro_producto = dt.Rows[0][0].ToString();
                    ObjCarro.Descripcion = dt.Rows[0][1].ToString();
                    ObjCarro.Unidades_inventario = (int)dt.Rows[0][2];
                    ObjCarro.Precio = Double.Parse(dt.Rows[0][3].ToString());
                    ObjCarro.Modelo = dt.Rows[0][4].ToString();
                }
                else
                {
                    MessageBox.Show("No existe este registro");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos");
            }

            return ObjCarro;
        }

        public static CarroSub ObtenerCarro_ultimo()
        {

            string sqlSelect = "SELECT TOP 1 Nro_producto, Descripcion, Unidades_inventario, Precio, Modelo " +
                               " FROM Carros ORDER BY Nro_producto DESC";

            CarroSub ObjCarro = null;
            try
            {
                // Create a data adapter
                SqlDataAdapter da = new SqlDataAdapter(sqlSelect, ConnectionString);

                // Fill a DataTable using DataAdapter and output to console
                DataTable dt = new DataTable();
                da.Fill(dt);

                //Se crea el objeto de CarroSub
                ObjCarro = new CarroSub();

                if (dt.Rows.Count > 0)
                {
                    ObjCarro.Nro_producto = dt.Rows[0][0].ToString();
                    ObjCarro.Descripcion = dt.Rows[0][1].ToString();
                    ObjCarro.Unidades_inventario = (int)dt.Rows[0][2];
                    ObjCarro.Precio = Double.Parse(dt.Rows[0][3].ToString());
                    ObjCarro.Modelo = dt.Rows[0][4].ToString();
                }
                else
                {
                    MessageBox.Show("No existe este registro");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos");
            }

            return ObjCarro;
        }

        public static CarroSub ObtenerCarro_proximo(String Nro_Carro)
        {

            string sqlSelect = "SELECT Nro_producto, Descripcion, Unidades_inventario, Precio, Modelo " +
                               " FROM Carros WHERE Nro_producto > '" + Nro_Carro + "' ORDER BY Nro_producto";

            CarroSub ObjCarro = null;
            try
            {
                // Create a data adapter
                SqlDataAdapter da = new SqlDataAdapter(sqlSelect, ConnectionString);

                // Fill a DataTable using DataAdapter and output to console
                DataTable dt = new DataTable();
                da.Fill(dt);

                //Se crea el objeto de CarroSub
                ObjCarro = new CarroSub();

                if (dt.Rows.Count > 0)
                {
                    ObjCarro.Nro_producto = dt.Rows[0][0].ToString();
                    ObjCarro.Descripcion = dt.Rows[0][1].ToString();
                    ObjCarro.Unidades_inventario = (int)dt.Rows[0][2];
                    ObjCarro.Precio = Double.Parse(dt.Rows[0][3].ToString());
                    ObjCarro.Modelo = dt.Rows[0][4].ToString();
                }
                else
                {
                    MessageBox.Show("No existe proximo registro.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos");
            }

            return ObjCarro;
        }

        public static CarroSub ObtenerCarro_anterior(String Nro_Carro)
        {

            string sqlSelect = "SELECT Nro_producto, Descripcion, Unidades_inventario, Precio, Modelo " +
                               " FROM Carros WHERE Nro_producto < '" + Nro_Carro + "' ORDER BY Nro_producto DESC";

            CarroSub ObjCarro = null;
            try
            {
                // Create a data adapter
                SqlDataAdapter da = new SqlDataAdapter(sqlSelect, ConnectionString);

                // Fill a DataTable using DataAdapter and output to console
                DataTable dt = new DataTable();
                da.Fill(dt);

                //Se crea el objeto de CarroSub
                ObjCarro = new CarroSub();

                if (dt.Rows.Count > 0)
                {
                    ObjCarro.Nro_producto = dt.Rows[0][0].ToString();
                    ObjCarro.Descripcion = dt.Rows[0][1].ToString();
                    ObjCarro.Unidades_inventario = (int)dt.Rows[0][2];
                    ObjCarro.Precio = Double.Parse(dt.Rows[0][3].ToString());
                    ObjCarro.Modelo = dt.Rows[0][4].ToString();
                }
                else
                {
                    MessageBox.Show("No existe anterior registro.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos");
            }

            return ObjCarro;
        }
        

        public static void LimpiarPantalla()
        {
            for (int i = 0; i < 5; i++) Console.WriteLine();
        }

        public static void DibujarLinea()
        {
            for (int i = 0; i < 30; i++) Console.Write("-");
            Console.WriteLine();
        }

        public static int Mostrar_Carro(CarroSub[] Arreglo_Carro, char registro, int cursor)
        {
            // muestra el primer carro del arreglo
            if (registro == 'p')
            {
                Arreglo_Carro[0].ListarCarro();
                cursor = 0;
                // muestra el ultimo carro
            }
            else if (registro == 'u')
            {
                Arreglo_Carro[Arreglo_Carro.Length - 1].ListarCarro();
                cursor = Arreglo_Carro.Length - 1;
                // muestra el proximo carro
            }
            else if (registro == 'o')
            {
                if (cursor < Arreglo_Carro.Length - 1)
                {
                    Arreglo_Carro[cursor + 1].ListarCarro();
                    cursor = cursor + 1;
                }
                else
                {
                    Console.WriteLine("No hay proximo carro");
                }
                // shows previous product
            }
            else if (registro == 'a')
            {
                if (cursor > 0)
                {
                    Arreglo_Carro[cursor - 1].ListarCarro();
                    cursor = cursor - 1;
                }
                else
                {
                    Console.WriteLine("No hay carro anterior");
                }
            }
            return cursor;
        }

        // Sobrecarga del metodo CargarDatos que permite trabajar con la coleccion ArrayList
        public static void CargarDatos(ArrayList Coleccion_Carro, String[,] sdata)
        {
            // Copia los datos desde el arreglo de data al arreglo de carros
            for (int i = 0; i < sdata.GetLength(0); i++)
            {
                // Se crea el objeto y se asignan los valores en un solo paso.
                Coleccion_Carro.Add(new CarroSub(sdata[i, 0], sdata[i, 1], Int32.Parse(sdata[i, 2]), Double.Parse(sdata[i, 3]), sdata[i, 5]));

            }

        }

        public static void CargarDatos(CarroSub[] Arreglo_Carro, String[,] sdata)
        {
            // Copia los datos desde el arreglo de data al arreglo de carros
            for (int i = 0; i < sdata.GetLength(0); i++)
            {
                // Se crea el objeto y se asignan los valores en un solo paso.
                Arreglo_Carro[i] = new CarroSub(sdata[i, 0], sdata[i, 1],
                    Int32.Parse(sdata[i, 2]), Double.Parse(sdata[i, 3]), sdata[i, 5]);

                //Metodo anterior de carga (sin constructor).
                /*
                Arreglo_Carro[i] = new CarroSub();
                Arreglo_Carro[i].Nro_producto = sdata[i, 0];
                Arreglo_Carro[i].Descripcion = sdata[i, 1];
                // En este campo convertimos el dato de String a entero
                Arreglo_Carro[i].Unidades_inventario = Int32.Parse(sdata[i, 2]);
                // En este campo convertimos el dato de String a double
                Arreglo_Carro[i].Precio = Double.Parse(sdata[i, 3]);
                // Campo agregado en la subclase CarroSub
                Arreglo_Carro[i].Modelo = sdata[i, 5];
                */
            }

        }

        public static void ListarDatos(Carro[] Arreglo_Carro)
        {
            for (int i = 0; i < Arreglo_Carro.Length; i++)
            {
                Arreglo_Carro[i].ListarCarro();
                Console.WriteLine();
            }
        }

        public static double TotalInventario(Carro[] Arreglo_Carro)
        {
            double Valor_inventario = 0;
            for (int i = 0; i < Arreglo_Carro.Length; i++)
            {
                Valor_inventario = Valor_inventario + Arreglo_Carro[i].Valor;
            }

            //Console.WriteLine();
            //Console.WriteLine("Valor total del inventario: " + Valor_inventario);
            return Valor_inventario;
        }

        public static void ProbarConexionSQL()
        {
            try
            {
                ConexionSQL = new SqlConnection(ConnectionString);
                ConexionSQL.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a SQL Server");
            }

        }

    }
}
