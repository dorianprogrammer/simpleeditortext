using System;

namespace EditorDeTexto
{
    public class EditorDeTexto
    {
        private string texto { get; set; }


        public EditorDeTexto(string texto)
        {
            this.texto = texto;
        }


        public int CantidadDePalabras()
        {
            int cantidadDePalabras = 0;
            cantidadDePalabras = texto.Split(" ").Length;
            return cantidadDePalabras;
        }

        public int CantidadDePalabrasPorParrafo(int numeroDeParrafo)
        {
            int cantidadDePalabras = 0;
            string[] parrafos = texto.Split("\n");
            cantidadDePalabras = parrafos[numeroDeParrafo-1].Split(" ").Length;
           
            return cantidadDePalabras;
        }


        public int CantidadDeLetras()
        {
            int cantidadDeLetras = 0;
            string[] listaDepalabras = texto.Split(" ");

            for (int i = 0; i < listaDepalabras.Length; i++) cantidadDeLetras += listaDepalabras[i].Length;

            return cantidadDeLetras - (texto.Split("\n").Length - 1);
        }

        public int CantidadDeLetrasPorParrafo(int numeroDeParrafo)
        {
            int cantidadDeLetras = 0;
            string[] parrafos = texto.Split("\n");
            string[] palabrasDelParrafo = parrafos[numeroDeParrafo -1].Split(" ");

            for (int i = 0; i < palabrasDelParrafo.Length; i++) cantidadDeLetras += palabrasDelParrafo[i].Length;

            return cantidadDeLetras;
        }


        public string RemplazarUnaPalabraEnEspecifico(string palabraRemplazada, string palabraRemplazo)
        {
            string textoRemplazado = null;
            string[] listaDepalabras = texto.Split(" ");

            for (int i = 0; i < listaDepalabras.Length; i++)
            {
                if (listaDepalabras[i].Equals(palabraRemplazada)) listaDepalabras[i] = palabraRemplazo;
                if (i == listaDepalabras.Length-1) textoRemplazado += listaDepalabras[i];
                else textoRemplazado += listaDepalabras[i] + " ";
            }

            return textoRemplazado;
        }

        public int CantidadDeVecesQueApareceUnaPalabra(string palabraBuscada)
        {
            int numeroDeVeces = 0;
            string[] listaDepalabras = texto.Split(" ");

            for (int i = 0; i < listaDepalabras.Length; i++)
            {
                if (listaDepalabras[i].Equals(palabraBuscada) || listaDepalabras[i].Equals(palabraBuscada + ".") || listaDepalabras[i].Equals(palabraBuscada + ","))
                {
                    numeroDeVeces++;
                }
            }
            return numeroDeVeces;
        }

        public int CantidadDeVecesQueApareceUnaPalabraPorParrafo(int parrafoABuscar, string palabraABuscar)
        {
            int numeroDeVeces = 0;
            string[] parrafosTexto = texto.Split("\n");
            string[] listaDePalabrasPorParrafo = parrafosTexto[parrafoABuscar - 1].Split(" ");

            for (int i = 0; i < listaDePalabrasPorParrafo.Length; i++)
            {
                if (listaDePalabrasPorParrafo[i].Equals(palabraABuscar) || listaDePalabrasPorParrafo[i].Equals(palabraABuscar + ".") || listaDePalabrasPorParrafo[i].Equals(palabraABuscar + ","))
                {
                    numeroDeVeces++;
                }
            }

            return numeroDeVeces;
        }

        public string ConvertirTodasLasLetrasEnMayuscula()
        {
            return texto.ToUpper();
        }

        public string ConvetirTodasLasLetrasEnMayusculaEnUnParrafo(int numeroDelParrafo)
        {
            string textoEnMayuscula = null;
            string[] parrafosTexto = texto.Split("\n");
            string[] listaDePalabrasPorParrafo = parrafosTexto[numeroDelParrafo - 1].Split(" ");


            for (int i = 0; i < parrafosTexto.Length; i++)
            {
                if (i == numeroDelParrafo-1)
                {
                    for (int j = 0; j < listaDePalabrasPorParrafo.Length; j++)
                    {
                        if (j == listaDePalabrasPorParrafo.Length - 1)
                            textoEnMayuscula += listaDePalabrasPorParrafo[j].ToUpper();
                        else
                            textoEnMayuscula += listaDePalabrasPorParrafo[j].ToUpper() + " ";
                    }
                    if (i != parrafosTexto.Length -1) textoEnMayuscula += "\n";
                }
                else
                {
                    if (i == parrafosTexto.Length-1) textoEnMayuscula += parrafosTexto[i];
                    else textoEnMayuscula += parrafosTexto[i] + "\n";
                }
            }
            return textoEnMayuscula;
        }


        public string ConvertirTodasLasLetrasEnMinuscula()
        {
            return texto.ToLower();
        }

        public string ConvertirLetrasDeUnParrafoEnMinuscula(int numeroDelParrafo)
        {
            string textoEnMinuscula = null;
            string[] parrafosTexto = texto.Split("\n");
            string[] listaDePalabrasPorParrafo = parrafosTexto[numeroDelParrafo - 1].Split(" ");


            for (int i = 0; i < parrafosTexto.Length; i++)
            {
                if (i == numeroDelParrafo - 1)
                {
                    for (int j = 0; j < listaDePalabrasPorParrafo.Length; j++)
                    {
                        if (j == listaDePalabrasPorParrafo.Length - 1)
                            textoEnMinuscula += listaDePalabrasPorParrafo[j].ToLower();
                        else
                            textoEnMinuscula += listaDePalabrasPorParrafo[j].ToLower() + " ";
                    }
                    if (i != parrafosTexto.Length - 1) textoEnMinuscula += "\n";
                }
                else
                {
                    if (i == parrafosTexto.Length - 1) textoEnMinuscula += parrafosTexto[i];
                    else textoEnMinuscula += parrafosTexto[i] + "\n";
                }
            }
            return textoEnMinuscula;
        }

        public string ConvertirLaPrimeraLetraEnMayusculaYLasDemasEnMinuscula()
        {
            string textoGenerado = null;
            string[] parrafos = texto.Split("\n");

            for (int i = 0; i < parrafos.Length; i++)
            {
                if (i == parrafos.Length-1)
                {
                    textoGenerado += parrafos[i][0].ToString().ToUpper();
                    for (int k = 1; k < parrafos[i].Length; k++)
                    {
                        textoGenerado += parrafos[i][k].ToString().ToLower();
                    }
                }
                else
                {
                    textoGenerado += parrafos[i][0].ToString().ToUpper();
                    for (int k = 1; k < parrafos[i].Length; k++)
                    {
                        textoGenerado += parrafos[i][k];
                    }
                    textoGenerado += "\n";
                }
            }
            return textoGenerado;
        }

        public string ConvertirLaPrimeraLetraEnMayusculaYLasDemasEnMinusculaDeUnParrafo(int numeroDelParrafo)
        {
            string textoGenerado = null;
            string[] parrafosTexto = texto.Split("\n");

            for (int i = 0; i < parrafosTexto.Length; i++)
            {
                if (i == numeroDelParrafo - 1)
                {
                    textoGenerado += parrafosTexto[i][0].ToString().ToUpper();
                    for (int j = 1; j < parrafosTexto[i].Length; j++)
                    {
                        textoGenerado += parrafosTexto[i][j].ToString().ToLower();
                    }
                    if (i != parrafosTexto.Length - 1) textoGenerado += "\n";
                }
                else
                {
                    if (i == parrafosTexto.Length - 1) textoGenerado += parrafosTexto[i];
                    else textoGenerado += parrafosTexto[i] + "\n";
                }
            }
            return textoGenerado;
        }
    }
}
