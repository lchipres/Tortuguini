using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortuguini
{
    class Mapa
    {
        int[,] mapa = new int[20, 20];
        int pluma = 0, direccion = 3,x=0,y=0;
        //Direcciones 3=arriba 4=derecha 5=abajo 6=izquierda

        public void setMapa(int[,] m)
        {
            mapa = m;
        }

        public int[,] getMapa()
        {
            return mapa;
        }

        public void bajarPluma()
        {
            pluma = 1;
        }

        public void subirPluma()
        {
            pluma = 0;
        }

        public void girarDerecha()
        {
            if(direccion==6)
            {
                direccion = 3;
            }
            else
            {
                direccion+=1;
            }
        }

        public void girarIzquierda()
        {
            if (direccion == 3)
            {
                direccion = 6;
            }
            else
            {
                direccion-=1;
            }
        }

        public void avanzar(int n)
        {
           
                if (direccion == 3)
                {
                    for (; n > 0 && x < 20;)
                    {
                        if (pluma == 1)
                        {
                        mapa[x, y] = 1;
                        }
                        x -= 1;
                        n -= 1;
                    }
                }

                if (direccion == 4)
                {
                    for (; n > 0 && y < 20;)
                    {
                        if (pluma == 1)
                        {
                        mapa[x, y] = 1;
                        }
                        y += 1;
                        n -= 1;
                    }
                }

                if (direccion == 5)
                {
                    for (; n >0&&x<20;)
                    {
                        if (pluma == 1)
                        {
                            mapa[x, y] = 1;
                        }
                        x+=1;
                        n-=1;
                    }
                }

                if (direccion == 6)
                {
                    for (; n > 0 && y < 20;)
                    {
                        if (pluma == 1)
                        {
                        mapa[x, y] = 1;
                        }
                        y -= 1;
                        n -= 1;
                    }
                }

        }
    }
}

