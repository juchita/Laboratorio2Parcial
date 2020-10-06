﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Validaciones
    {
        /// <summary>
        /// verifica que la cadena de caracter recibida sea numerica
        /// </summary>
        /// <param name="strNum"></param>
        /// <returns></returns>
        public static bool EsNumerico(string strNum)
        {
            bool ret = false;
            int cont = 0;

            for (int i = 0; i < strNum.Length; i++)
            {
                if (char.IsDigit(strNum[i]))
                    cont++;
            }

            if (cont == strNum.Length)
                ret = true;

            return ret;
        }

        /// <summary>
        /// Verifica la cadena recibida contenga letras
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool ContieneLetras(string str)
        {
            bool ret = false;

            int cont = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                    cont++;
            }

            if (cont == str.Length)
                ret = true;

            return ret;
        }
        /// <summary>
        /// Verifica el nombre ingresado le corresponda descuento o no
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>

        public static bool CheckDescuento(string nombre)
        {
            bool descuento =false;

            if (nombre == EDescuento.Bart.ToString() || nombre == EDescuento.Homero.ToString() || nombre == EDescuento.Marge.ToString() || nombre == EDescuento.Maggie.ToString() ||
                nombre == EDescuento.Lisa.ToString())
                descuento = true;

            return descuento;
        }

        public static string ConSinDescuento(string nom)
        {
            string ret;

            if (CheckDescuento(nom))
                ret = "Con descuento";
            else
                ret = "Sin descuento";

            return ret;
        }
        
        /// <summary>
        /// Verifica que lo que se haya pasado por parametro sea un domicilio (string alfanumerico)
        /// </summary>
        /// <param name="strDom"></param>
        /// <returns></returns>
        public static bool VerificaDomicilio(string strDom)
        {
            bool ret = false;
            int cont=0;

            for (int i = 0; i < strDom.Length; i++)
            {
                if (char.IsLetter(strDom[i]) || char.IsDigit(strDom[i]) || strDom == " ")
                    cont++;
            }

            if (cont == strDom.Length)
                ret = true;

            return ret;
        }


        /*
        public bool validarDatos()
        {
            int nombre, apellido, dni;
            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtApellido.Text) || !(int.TryParse(txtDni.Text, out dni))
                 || int.TryParse(txtNombre.Text, out nombre) || int.TryParse(txtApellido.Text, out apellido) || String.IsNullOrEmpty(cmbSexo.Text))
            {
                return false;
            }
            else
                return true;
        }
        */
    }
}
