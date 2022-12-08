using System;
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
            Carro c1 = new Carro("Macanudo", "img/macanudo.jpg", "24/7", "centro", 5.0 , 1);
            Carro c2 = new Carro("El Italiano", "img/elitaliano.jpg", "24/7", "centro", 5.0, 3);
            Carro c3 = new Carro("MCCarro", "img/maccarro.jpg", "24/7", "centro", 5.0, 2);
            Carro c4 = new Carro("Carlos", "img/maccarro.jpg", "Lunes a viernes 12 a 18", "centro", 5.0, 5);
            Carro c5 = new Carro("McDonalds", "img/maccarro.jpg", "24/7", "centro",5.0, 6);
            Carro c6 = new Carro("McDonalds", "img/maccarro.jpg", "24/7", "centro", 5.0, 4);
            Carro c7 = new Carro("McDonalds", "img/maccarro.jpg", "24/7", "centro", 5.0, 10);
            Carro c8 = new Carro("McDonalds", "img/maccarro.jpg", "24/7", "centro", 5.0, 9);
            Carro c9 = new Carro("McDonalds", "img/maccarro.jpg", "24/7", "centro", 5.0, 8);
            Carro c10 = new Carro("JAJAJA", "img/maccarro.jpg", "24/7", "centro", 5.0, 7);

            altaCarro(c1);
            altaCarro(c2);
            altaCarro(c3);
            altaCarro(c4);
            altaCarro(c5);
            altaCarro(c6);
            altaCarro(c7);
            altaCarro(c8);
            altaCarro(c9);
            altaCarro(c10);
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
