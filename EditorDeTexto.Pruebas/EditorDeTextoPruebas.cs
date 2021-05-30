using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EditorDeTexto.Pruebas
{
    [TestClass]
    public class EditorDeTextoPruebas
    {
        [TestMethod]
        public void CantidadDePalabras()
        {
            string textoInsertado = "lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum. \n" +
                "there are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc. \n" +
                "it is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).";

            EditorDeTexto editorDeTexto = new EditorDeTexto(textoInsertado);

            int cantidadDePalabrasEsperadas = 316;
            int cantidadDePalabrasObtenidas = editorDeTexto.CantidadDePalabras();

            Assert.AreEqual(cantidadDePalabrasEsperadas, cantidadDePalabrasObtenidas);

        }

        [TestMethod]
        public void CantidadDePalabrasPorParrafo()
        {
            string textoInsertado = "lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\n" +
                "there are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.\n" +
                "it is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).";

            EditorDeTexto editorDeTexto = new EditorDeTexto(textoInsertado);

            // primero parrafo -> 91 palabras, segundo parrafo --> 121 palabras y tercer parrafo --> 104 palabras
            int cantidadDePalabrasEsperadasEnElParrafo = 104;

            // Pasa por parametro cual parrafo quiere contar palabras para esta caso [1,2,3]
            int cantidadDePalabrasObtenidas = editorDeTexto.CantidadDePalabrasPorParrafo(3);

            Assert.AreEqual(cantidadDePalabrasEsperadasEnElParrafo, cantidadDePalabrasObtenidas);
        }

        [TestMethod]
        public void CantidadDeLetras()
        {
            string textoInsertado = "lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\n" +
                "there are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.\n" +
                "it is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).";
            
            EditorDeTexto editorDeTexto = new EditorDeTexto(textoInsertado);

            int cantidadDeLetrasEsperadas = 1624;
            int cantidadDeLetrasObtenidas = editorDeTexto.CantidadDeLetras();

            Assert.AreEqual(cantidadDeLetrasEsperadas, cantidadDeLetrasObtenidas);

        }

        [TestMethod]
        public void CantidadDeLetrasPorParrafo()
        {
            string textoInsertado = "lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\n" +
                "there are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.\n" +
                "it is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).";

            EditorDeTexto editorDeTexto = new EditorDeTexto(textoInsertado);

            // primero parrafo -> 484 letras, segundo parrafo --> 630 palabras y tercer parrafo --> 510 palabras
            int cantidadDeLetrasEsperadas = 510;

            // Pasa por parametro cual parrafo quiere contar letras para esta caso [1,2,3]
            int cantidadDeLetrasObtenidas = editorDeTexto.CantidadDeLetrasPorParrafo(3);

            Assert.AreEqual(cantidadDeLetrasEsperadas, cantidadDeLetrasObtenidas);
        }

        [TestMethod]
        public void RemplazarUnaPalabraEnEspecificoPorOtra()
        {
            string textoInsertado = "lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\n" +
                "there are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.\n" +
                "it is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).";

            EditorDeTexto editorDeTexto = new EditorDeTexto(textoInsertado);

            string textoEsperadoConPalabraRemplazada = "lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\n" +
                "there are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.\n" +
                "it is a long established fact that a reader will be DORIAN by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).";

            string textoObtenidoConPalabraRemplazada = editorDeTexto.RemplazarUnaPalabraEnEspecifico("distracted", "DORIAN");


            Assert.AreEqual(textoEsperadoConPalabraRemplazada, textoObtenidoConPalabraRemplazada);
        }

        [TestMethod]
        public void CantidadDeVecesQueApareceUnaPalabra()
        {
            string textoInsertado = "lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\n" +
                "there are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.\n" +
                "it is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).";

            EditorDeTexto editorDeTexto = new EditorDeTexto(textoInsertado);

            int numeroDeVecesEsperadoQueApareceLaPalabra = 3;
            int nuumeroDeVecesObtenidoQueApareceLaPalabra = editorDeTexto.CantidadDeVecesQueApareceUnaPalabra("has");

            Assert.AreEqual(numeroDeVecesEsperadoQueApareceLaPalabra, nuumeroDeVecesObtenidoQueApareceLaPalabra);
        }

        [TestMethod]
        public void CantidadDeVecesQueApareceUnaPalabraPorParrafo()
        {
            string textoInsertado = "lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\n" +
                "there are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.\n" +
                "it is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).";

            EditorDeTexto editorDeTexto = new EditorDeTexto(textoInsertado);

            int numeroDeVecesEsperadoQueApareceLaPalabra = 1;

            // Se indica el numero del parrafo[1,2,3] que quiere buscar la palabra, junto con la palabra
            int numeroDeVecesObtenidoQueApareceLaPalabra = editorDeTexto.CantidadDeVecesQueApareceUnaPalabraPorParrafo(3,"has");

            Assert.AreEqual(numeroDeVecesEsperadoQueApareceLaPalabra, numeroDeVecesObtenidoQueApareceLaPalabra);
            
        }

        [TestMethod]
        public void ConvetirTodasLasLetrasEnMayuscula()
        {
            string textoInsertado = "lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\n" +
                "there are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.\n" +
                "it is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).";

            EditorDeTexto editorDeTexto = new EditorDeTexto(textoInsertado);

            string textoExperado = "LOREM IPSUM IS SIMPLY DUMMY TEXT OF THE PRINTING AND TYPESETTING INDUSTRY. LOREM IPSUM HAS BEEN THE INDUSTRY'S STANDARD DUMMY TEXT EVER SINCE THE 1500S, WHEN AN UNKNOWN PRINTER TOOK A GALLEY OF TYPE AND SCRAMBLED IT TO MAKE A TYPE SPECIMEN BOOK. IT HAS SURVIVED NOT ONLY FIVE CENTURIES, BUT ALSO THE LEAP INTO ELECTRONIC TYPESETTING, REMAINING ESSENTIALLY UNCHANGED. IT WAS POPULARISED IN THE 1960S WITH THE RELEASE OF LETRASET SHEETS CONTAINING LOREM IPSUM PASSAGES, AND MORE RECENTLY WITH DESKTOP PUBLISHING SOFTWARE LIKE ALDUS PAGEMAKER INCLUDING VERSIONS OF LOREM IPSUM.\n" +
                "THERE ARE MANY VARIATIONS OF PASSAGES OF LOREM IPSUM AVAILABLE, BUT THE MAJORITY HAVE SUFFERED ALTERATION IN SOME FORM, BY INJECTED HUMOUR, OR RANDOMISED WORDS WHICH DON'T LOOK EVEN SLIGHTLY BELIEVABLE. IF YOU ARE GOING TO USE A PASSAGE OF LOREM IPSUM, YOU NEED TO BE SURE THERE ISN'T ANYTHING EMBARRASSING HIDDEN IN THE MIDDLE OF TEXT. ALL THE LOREM IPSUM GENERATORS ON THE INTERNET TEND TO REPEAT PREDEFINED CHUNKS AS NECESSARY, MAKING THIS THE FIRST TRUE GENERATOR ON THE INTERNET. IT USES A DICTIONARY OF OVER 200 LATIN WORDS, COMBINED WITH A HANDFUL OF MODEL SENTENCE STRUCTURES, TO GENERATE LOREM IPSUM WHICH LOOKS REASONABLE. THE GENERATED LOREM IPSUM IS THEREFORE ALWAYS FREE FROM REPETITION, INJECTED HUMOUR, OR NON-CHARACTERISTIC WORDS ETC.\n" +
                "IT IS A LONG ESTABLISHED FACT THAT A READER WILL BE DISTRACTED BY THE READABLE CONTENT OF A PAGE WHEN LOOKING AT ITS LAYOUT. THE POINT OF USING LOREM IPSUM IS THAT IT HAS A MORE-OR-LESS NORMAL DISTRIBUTION OF LETTERS, AS OPPOSED TO USING 'CONTENT HERE, CONTENT HERE', MAKING IT LOOK LIKE READABLE ENGLISH. MANY DESKTOP PUBLISHING PACKAGES AND WEB PAGE EDITORS NOW USE LOREM IPSUM AS THEIR DEFAULT MODEL TEXT, AND A SEARCH FOR 'LOREM IPSUM' WILL UNCOVER MANY WEB SITES STILL IN THEIR INFANCY. VARIOUS VERSIONS HAVE EVOLVED OVER THE YEARS, SOMETIMES BY ACCIDENT, SOMETIMES ON PURPOSE (INJECTED HUMOUR AND THE LIKE).";
            
            string textoObtenido = editorDeTexto.ConvertirTodasLasLetrasEnMayuscula();

            Assert.AreEqual(textoExperado, textoObtenido);
        }

        [TestMethod]
        public void ConvetirTodasLasLetrasEnMayusculaEnUnParrafo()
        {
            string textoInsertado = "lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\n" +
                "there are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.\n" +
                "it is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).\n"+
                "lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

            EditorDeTexto editorDeTexto = new EditorDeTexto(textoInsertado);

            string textoExperadoDelParrafo = "lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\n" +
                "there are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.\n" +
                "it is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).\n"+
                "LOREM IPSUM DOLOR SIT AMET, CONSECTETUR ADIPISCING ELIT, SED DO EIUSMOD TEMPOR INCIDIDUNT UT LABORE ET DOLORE MAGNA ALIQUA. UT ENIM AD MINIM VENIAM, QUIS NOSTRUD EXERCITATION ULLAMCO LABORIS NISI UT ALIQUIP EX EA COMMODO CONSEQUAT. DUIS AUTE IRURE DOLOR IN REPREHENDERIT IN VOLUPTATE VELIT ESSE CILLUM DOLORE EU FUGIAT NULLA PARIATUR. EXCEPTEUR SINT OCCAECAT CUPIDATAT NON PROIDENT, SUNT IN CULPA QUI OFFICIA DESERUNT MOLLIT ANIM ID EST LABORUM.";

            // Se indica el numero del parrafo[1,2,3,4] que quiere convertir a mayuscula
            string textoObtenidoDelParrafo = editorDeTexto.ConvetirTodasLasLetrasEnMayusculaEnUnParrafo(4);

            Assert.AreEqual(textoExperadoDelParrafo, textoObtenidoDelParrafo);
        }

        [TestMethod]
        public void ConvertirTodasLasLetrasEnMinuscula()
        {
            string textoInsertado = "LOREM IPSUM IS SIMPLY DUMMY TEXT OF THE PRINTING AND TYPESETTING INDUSTRY. LOREM IPSUM HAS BEEN THE INDUSTRY'S STANDARD DUMMY TEXT EVER SINCE THE 1500S, WHEN AN UNKNOWN PRINTER TOOK A GALLEY OF TYPE AND SCRAMBLED IT TO MAKE A TYPE SPECIMEN BOOK. IT HAS SURVIVED NOT ONLY FIVE CENTURIES, BUT ALSO THE LEAP INTO ELECTRONIC TYPESETTING, REMAINING ESSENTIALLY UNCHANGED. IT WAS POPULARISED IN THE 1960S WITH THE RELEASE OF LETRASET SHEETS CONTAINING LOREM IPSUM PASSAGES, AND MORE RECENTLY WITH DESKTOP PUBLISHING SOFTWARE LIKE ALDUS PAGEMAKER INCLUDING VERSIONS OF LOREM IPSUM.\n" +
                "THERE ARE MANY VARIATIONS OF PASSAGES OF LOREM IPSUM AVAILABLE, BUT THE MAJORITY HAVE SUFFERED ALTERATION IN SOME FORM, BY INJECTED HUMOUR, OR RANDOMISED WORDS WHICH DON'T LOOK EVEN SLIGHTLY BELIEVABLE. IF YOU ARE GOING TO USE A PASSAGE OF LOREM IPSUM, YOU NEED TO BE SURE THERE ISN'T ANYTHING EMBARRASSING HIDDEN IN THE MIDDLE OF TEXT. ALL THE LOREM IPSUM GENERATORS ON THE INTERNET TEND TO REPEAT PREDEFINED CHUNKS AS NECESSARY, MAKING THIS THE FIRST TRUE GENERATOR ON THE INTERNET. IT USES A DICTIONARY OF OVER 200 LATIN WORDS, COMBINED WITH A HANDFUL OF MODEL SENTENCE STRUCTURES, TO GENERATE LOREM IPSUM WHICH LOOKS REASONABLE. THE GENERATED LOREM IPSUM IS THEREFORE ALWAYS FREE FROM REPETITION, INJECTED HUMOUR, OR NON-CHARACTERISTIC WORDS ETC.\n" +
                "IT IS A LONG ESTABLISHED FACT THAT A READER WILL BE DISTRACTED BY THE READABLE CONTENT OF A PAGE WHEN LOOKING AT ITS LAYOUT. THE POINT OF USING LOREM IPSUM IS THAT IT HAS A MORE-OR-LESS NORMAL DISTRIBUTION OF LETTERS, AS OPPOSED TO USING 'CONTENT HERE, CONTENT HERE', MAKING IT LOOK LIKE READABLE ENGLISH. MANY DESKTOP PUBLISHING PACKAGES AND WEB PAGE EDITORS NOW USE LOREM IPSUM AS THEIR DEFAULT MODEL TEXT, AND A SEARCH FOR 'LOREM IPSUM' WILL UNCOVER MANY WEB SITES STILL IN THEIR INFANCY. VARIOUS VERSIONS HAVE EVOLVED OVER THE YEARS, SOMETIMES BY ACCIDENT, SOMETIMES ON PURPOSE (INJECTED HUMOUR AND THE LIKE).";

            EditorDeTexto editorDeTexto = new EditorDeTexto(textoInsertado);

            string textoEsperado = "lorem ipsum is simply dummy text of the printing and typesetting industry. lorem ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. it has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. it was popularised in the 1960s with the release of letraset sheets containing lorem ipsum passages, and more recently with desktop publishing software like aldus pagemaker including versions of lorem ipsum.\n" +
                "there are many variations of passages of lorem ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. if you are going to use a passage of lorem ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. all the lorem ipsum generators on the internet tend to repeat predefined chunks as necessary, making this the first true generator on the internet. it uses a dictionary of over 200 latin words, combined with a handful of model sentence structures, to generate lorem ipsum which looks reasonable. the generated lorem ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.\n" +
                "it is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. the point of using lorem ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'content here, content here', making it look like readable english. many desktop publishing packages and web page editors now use lorem ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).";

            string textoObtenido = editorDeTexto.ConvertirTodasLasLetrasEnMinuscula();

            Assert.AreEqual(textoEsperado, textoObtenido);
        }

        [TestMethod]
        public void ConvertirLetrasDeUnParrafoEnMinuscula()
        {
            string textoInsertado = "LOREM IPSUM IS SIMPLY DUMMY TEXT OF THE PRINTING AND TYPESETTING INDUSTRY. LOREM IPSUM HAS BEEN THE INDUSTRY'S STANDARD DUMMY TEXT EVER SINCE THE 1500S, WHEN AN UNKNOWN PRINTER TOOK A GALLEY OF TYPE AND SCRAMBLED IT TO MAKE A TYPE SPECIMEN BOOK. IT HAS SURVIVED NOT ONLY FIVE CENTURIES, BUT ALSO THE LEAP INTO ELECTRONIC TYPESETTING, REMAINING ESSENTIALLY UNCHANGED. IT WAS POPULARISED IN THE 1960S WITH THE RELEASE OF LETRASET SHEETS CONTAINING LOREM IPSUM PASSAGES, AND MORE RECENTLY WITH DESKTOP PUBLISHING SOFTWARE LIKE ALDUS PAGEMAKER INCLUDING VERSIONS OF LOREM IPSUM.\n" +
                "THERE ARE MANY VARIATIONS OF PASSAGES OF LOREM IPSUM AVAILABLE, BUT THE MAJORITY HAVE SUFFERED ALTERATION IN SOME FORM, BY INJECTED HUMOUR, OR RANDOMISED WORDS WHICH DON'T LOOK EVEN SLIGHTLY BELIEVABLE. IF YOU ARE GOING TO USE A PASSAGE OF LOREM IPSUM, YOU NEED TO BE SURE THERE ISN'T ANYTHING EMBARRASSING HIDDEN IN THE MIDDLE OF TEXT. ALL THE LOREM IPSUM GENERATORS ON THE INTERNET TEND TO REPEAT PREDEFINED CHUNKS AS NECESSARY, MAKING THIS THE FIRST TRUE GENERATOR ON THE INTERNET. IT USES A DICTIONARY OF OVER 200 LATIN WORDS, COMBINED WITH A HANDFUL OF MODEL SENTENCE STRUCTURES, TO GENERATE LOREM IPSUM WHICH LOOKS REASONABLE. THE GENERATED LOREM IPSUM IS THEREFORE ALWAYS FREE FROM REPETITION, INJECTED HUMOUR, OR NON-CHARACTERISTIC WORDS ETC.\n" +
                "IT IS A LONG ESTABLISHED FACT THAT A READER WILL BE DISTRACTED BY THE READABLE CONTENT OF A PAGE WHEN LOOKING AT ITS LAYOUT. THE POINT OF USING LOREM IPSUM IS THAT IT HAS A MORE-OR-LESS NORMAL DISTRIBUTION OF LETTERS, AS OPPOSED TO USING 'CONTENT HERE, CONTENT HERE', MAKING IT LOOK LIKE READABLE ENGLISH. MANY DESKTOP PUBLISHING PACKAGES AND WEB PAGE EDITORS NOW USE LOREM IPSUM AS THEIR DEFAULT MODEL TEXT, AND A SEARCH FOR 'LOREM IPSUM' WILL UNCOVER MANY WEB SITES STILL IN THEIR INFANCY. VARIOUS VERSIONS HAVE EVOLVED OVER THE YEARS, SOMETIMES BY ACCIDENT, SOMETIMES ON PURPOSE (INJECTED HUMOUR AND THE LIKE).";

            EditorDeTexto editorDeTexto = new EditorDeTexto(textoInsertado);

            string textEsperado = "lorem ipsum is simply dummy text of the printing and typesetting industry. lorem ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. it has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. it was popularised in the 1960s with the release of letraset sheets containing lorem ipsum passages, and more recently with desktop publishing software like aldus pagemaker including versions of lorem ipsum.\n" +
                "THERE ARE MANY VARIATIONS OF PASSAGES OF LOREM IPSUM AVAILABLE, BUT THE MAJORITY HAVE SUFFERED ALTERATION IN SOME FORM, BY INJECTED HUMOUR, OR RANDOMISED WORDS WHICH DON'T LOOK EVEN SLIGHTLY BELIEVABLE. IF YOU ARE GOING TO USE A PASSAGE OF LOREM IPSUM, YOU NEED TO BE SURE THERE ISN'T ANYTHING EMBARRASSING HIDDEN IN THE MIDDLE OF TEXT. ALL THE LOREM IPSUM GENERATORS ON THE INTERNET TEND TO REPEAT PREDEFINED CHUNKS AS NECESSARY, MAKING THIS THE FIRST TRUE GENERATOR ON THE INTERNET. IT USES A DICTIONARY OF OVER 200 LATIN WORDS, COMBINED WITH A HANDFUL OF MODEL SENTENCE STRUCTURES, TO GENERATE LOREM IPSUM WHICH LOOKS REASONABLE. THE GENERATED LOREM IPSUM IS THEREFORE ALWAYS FREE FROM REPETITION, INJECTED HUMOUR, OR NON-CHARACTERISTIC WORDS ETC.\n" +
                "IT IS A LONG ESTABLISHED FACT THAT A READER WILL BE DISTRACTED BY THE READABLE CONTENT OF A PAGE WHEN LOOKING AT ITS LAYOUT. THE POINT OF USING LOREM IPSUM IS THAT IT HAS A MORE-OR-LESS NORMAL DISTRIBUTION OF LETTERS, AS OPPOSED TO USING 'CONTENT HERE, CONTENT HERE', MAKING IT LOOK LIKE READABLE ENGLISH. MANY DESKTOP PUBLISHING PACKAGES AND WEB PAGE EDITORS NOW USE LOREM IPSUM AS THEIR DEFAULT MODEL TEXT, AND A SEARCH FOR 'LOREM IPSUM' WILL UNCOVER MANY WEB SITES STILL IN THEIR INFANCY. VARIOUS VERSIONS HAVE EVOLVED OVER THE YEARS, SOMETIMES BY ACCIDENT, SOMETIMES ON PURPOSE (INJECTED HUMOUR AND THE LIKE).";

            // Se indica el numero del parrafo[1,2,3] que quiere convertir a mayuscula
            string textoObtenido = editorDeTexto.ConvertirLetrasDeUnParrafoEnMinuscula(1);

            Assert.AreEqual(textEsperado, textoObtenido);
        }


        [TestMethod]
        public void ConvertirLaPrimeraLetraEnMayusculaYLasDemasEnMinuscula()
        {
            string textoInsertado = "lorem ipsum is simply dummy text of the printing and typesetting industry. lorem ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. it has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. it was popularised in the 1960s with the release of letraset sheets containing lorem ipsum passages, and more recently with desktop publishing software like aldus pagemaker including versions of lorem ipsum.\n" +
                "there are many variations of passages of lorem ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. if you are going to use a passage of lorem ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. all the lorem ipsum generators on the internet tend to repeat predefined chunks as necessary, making this the first true generator on the internet. it uses a dictionary of over 200 latin words, combined with a handful of model sentence structures, to generate lorem ipsum which looks reasonable. the generated lorem ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.\n" +
                "it is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. the point of using lorem ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'content here, content here', making it look like readable english. many desktop publishing packages and web page editors now use lorem ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).\n" +
                "lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

            EditorDeTexto editorDeTexto = new EditorDeTexto(textoInsertado);

            string textoEsperado = "Lorem ipsum is simply dummy text of the printing and typesetting industry. lorem ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. it has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. it was popularised in the 1960s with the release of letraset sheets containing lorem ipsum passages, and more recently with desktop publishing software like aldus pagemaker including versions of lorem ipsum.\n" +
                "There are many variations of passages of lorem ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. if you are going to use a passage of lorem ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. all the lorem ipsum generators on the internet tend to repeat predefined chunks as necessary, making this the first true generator on the internet. it uses a dictionary of over 200 latin words, combined with a handful of model sentence structures, to generate lorem ipsum which looks reasonable. the generated lorem ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.\n" +
                "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. the point of using lorem ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'content here, content here', making it look like readable english. many desktop publishing packages and web page editors now use lorem ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).\n" +
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

            string textoObtenido = editorDeTexto.ConvertirLaPrimeraLetraEnMayusculaYLasDemasEnMinuscula();

            Assert.AreEqual(textoEsperado, textoObtenido);
        }

        [TestMethod]
        public void ConvertirLaPrimeraLetraEnMayusculaYLasDemasEnMinusculaDeUnParrafo()
        {
            string textoInsertado = "lorem ipsum is simply dummy text of the printing and typesetting industry. lorem ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. it has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. it was popularised in the 1960s with the release of letraset sheets containing lorem ipsum passages, and more recently with desktop publishing software like aldus pagemaker including versions of lorem ipsum.\n" +
                "there are many variations of passages of lorem ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. if you are going to use a passage of lorem ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. all the lorem ipsum generators on the internet tend to repeat predefined chunks as necessary, making this the first true generator on the internet. it uses a dictionary of over 200 latin words, combined with a handful of model sentence structures, to generate lorem ipsum which looks reasonable. the generated lorem ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.\n" +
                "it is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. the point of using lorem ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'content here, content here', making it look like readable english. many desktop publishing packages and web page editors now use lorem ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).\n" +
                "lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

            EditorDeTexto editorDeTexto = new EditorDeTexto(textoInsertado);

            string textoEsperado = "lorem ipsum is simply dummy text of the printing and typesetting industry. lorem ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. it has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. it was popularised in the 1960s with the release of letraset sheets containing lorem ipsum passages, and more recently with desktop publishing software like aldus pagemaker including versions of lorem ipsum.\n" +
                "there are many variations of passages of lorem ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. if you are going to use a passage of lorem ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. all the lorem ipsum generators on the internet tend to repeat predefined chunks as necessary, making this the first true generator on the internet. it uses a dictionary of over 200 latin words, combined with a handful of model sentence structures, to generate lorem ipsum which looks reasonable. the generated lorem ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.\n" +
                "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. the point of using lorem ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'content here, content here', making it look like readable english. many desktop publishing packages and web page editors now use lorem ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).\n" +
                "lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

            // Se indica por parametro el numero del parrafo[1,2,3,4] que quiere convertir a mayuscula
            string textoObtenido = editorDeTexto.ConvertirLaPrimeraLetraEnMayusculaYLasDemasEnMinusculaDeUnParrafo(3);

            Assert.AreEqual(textoEsperado, textoObtenido);
        }

    }
}
