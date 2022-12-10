﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Sistema
    {
        public List<Carro> losCarros { get; set; }

        #region Singleton
        private static Sistema _instancia;

        private Sistema()
        {
            losCarros = new List<Carro>();
            precargarDatos();

        }

        public static Sistema Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Sistema();
                }
                return _instancia;
            }

        }
        #endregion

        private void precargarDatos()
        {
        }

        public void altaCarro(Carro c1)
        {       
                try
                {
                    if (losCarros.Contains(c1))
                    {
                        throw new Exception("El Carro ya se encuentra registrado");
                    }
                    losCarros.Add(c1);

                }

                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }          
        }


        public List<Carro> top10()
        {
            List<Carro> listRet = new List<Carro>();

            foreach(Carro c in losCarros)
            {
                if (c.getTop() <= 5)
                {
                    listRet.Add(c);
                }
            }

            listRet.Sort();
            return listRet;
        }


    }
}
