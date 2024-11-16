using Client_WS.CalculadoraService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client_WS.Catalogos.Calculadora
{
    public partial class Calculadora : System.Web.UI.Page
    {
        //creamos un cliente que resulva las peticiones del servicio SOAP
        calculadora_ServiceSoapClient cliente_WS;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Inicializo mi cliente SOAP
            cliente_WS = new calculadora_ServiceSoapClient();


        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            //Recupero los datos de mi formulario 
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            //Invoco mi servicio pasandole los datos que requiere
            double resultado = cliente_WS.Sum(a, b);
            //muestro el resultado del servicio en mi pagina
            lblresultado.Text = resultado.ToString();

        }

        protected void btRestar_Click(object sender, EventArgs e)
        {
            //Recupero los datos de mi formulario 
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            //Invoco mi servicio pasandole los datos que requiere
            double resultado = cliente_WS.Resta(a, b);
            lblresultado.Text = resultado.ToString();


        }

        protected void btnMultiplicar_Click(object sender, EventArgs e)
        {
            //Recupero los datos de mi formulario 
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            //Invoco mi servicio pasandole los datos que requiere
            double resultado = cliente_WS.Multiplicacion(a, b);
            lblresultado.Text = resultado.ToString();
        }

        protected void btnDividir_Click(object sender, EventArgs e)
        {
            //Recupero los datos de mi formulario 
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            //Invoco mi servicio pasandole los datos que requiere
            double resultado = cliente_WS.Division(a, b);
            lblresultado.Text = resultado.ToString();
        }
    }
}