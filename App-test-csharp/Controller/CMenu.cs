using App_test_csharp;
using App_test_csharp.View;
using ClassesLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_test_csharp.Controller;
namespace ClassesLibrary.Controller
{
    public class CMenu
    {
        public CMenu(FrmMenu view)
        {
            this.view = view;
            initButtons();
        }

        public void initButtons()
        {
            view.A1.MouseDown += (sender, e) => rosa_Click(sender, e);
            view.A2.MouseDown += (sender, e) => verde_Click(sender, e);
            view.B1.MouseDown += (sender, e) => amarillo_Click(sender, e);
            view.B2.MouseDown += (sender, e) => verdeAbajo_Click(sender, e);
        }

        public void rosa_Click(object sender, EventArgs e)
        {
            FrmQuestions frmQuestions = new FrmQuestions();
            Question model = new Question();
            Test englishTest = new Test();
            CResults.TypeTest = "A1";
            englishTest.AddQuestion(new Question("A1", new String[] { "Esta es la respuesta", "Si hay1", "no1", "Ya1" }, "/Imagenes/pregunta (1).png", 0, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta2", new String[] { "Esta es la respuesta", "Si hay2", "no2", "Ya2" }, "/Imagenes/confuso.png", 1, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta3", new String[] { "Esta es la respuesta", "Si hay3", "no3", "Ya3" }, "/Imagenes/unicornio.png", 2, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta4", new String[] { "Esta es la respuesta", "Si hay4", "no4", "Ya4" }, "/Imagenes/idea.png", 3, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta5", new String[] { "Esta es la respuesta", "Si hay5", "no5", "Ya5" }, "/Imagenes/pensando.png", 4, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta6", new String[] { "Esta es la respuesta", "Si hay6", "no6", "Ya6" }, "/Imagenes/idea (1).png", 5, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta7", new String[] { "Esta es la respuesta", "Si hay7", "no7", "Ya7" }, "/Imagenes/pensar.png", 6, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta8", new String[] { "Esta es la respuesta", "Si hay8", "no8", "Ya8" }, "/Imagenes/profesor.png", 7, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta9", new String[] { "Esta es la respuesta", "Si hay9", "no9", "Ya9" }, "/Imagenes/reina.png", 8, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta10", new String[] { "Esta es la respuesta", "Si hay10", "no10", "Ya10" }, "/Imagenes/reino-unido.png", 9, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            CQuestions cQuestions = new CQuestions(frmQuestions, model, englishTest);
            view.Close();
            CTemporizador temporizador = new CTemporizador();
            temporizador.iniciarTempo(frmQuestions);


        }
        public void verde_Click(object sender, EventArgs e)
        {
            FrmQuestions frmQuestions = new FrmQuestions();
            Question model = new Question();
            Test englishTest = new Test();
            CResults.TypeTest = "A2";
            englishTest.AddQuestion(new Question("A1", new String[] { "Esta es la respuesta", "Si hay1", "no1", "Ya1" }, "/Imagenes/pregunta (1).png", 0, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta2", new String[] { "Esta es la respuesta", "Si hay2", "no2", "Ya2" }, "/Imagenes/confuso.png", 1, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta3", new String[] { "Esta es la respuesta", "Si hay3", "no3", "Ya3" }, "/Imagenes/unicornio.png", 2, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta4", new String[] { "Esta es la respuesta", "Si hay4", "no4", "Ya4" }, "/Imagenes/idea.png", 3, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta5", new String[] { "Esta es la respuesta", "Si hay5", "no5", "Ya5" }, "/Imagenes/pensando.png", 4, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta6", new String[] { "Esta es la respuesta", "Si hay6", "no6", "Ya6" }, "/Imagenes/idea (1).png", 5, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta7", new String[] { "Esta es la respuesta", "Si hay7", "no7", "Ya7" }, "/Imagenes/pensar.png", 6, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta8", new String[] { "Esta es la respuesta", "Si hay8", "no8", "Ya8" }, "/Imagenes/profesor.png", 7, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta9", new String[] { "Esta es la respuesta", "Si hay9", "no9", "Ya9" }, "/Imagenes/reina.png", 8, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta10", new String[] { "Esta es la respuesta", "Si hay10", "no10", "Ya10" }, "/Imagenes/reino-unido.png", 9, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            CQuestions cQuestions = new CQuestions(frmQuestions, model, englishTest);
            view.Close();
            CTemporizador temporizador = new CTemporizador();
            temporizador.iniciarTempo(frmQuestions);

        }
        public void verdeAbajo_Click(object sender, EventArgs e)
        {
            FrmQuestions frmQuestions = new FrmQuestions();
            Question model = new Question();
            Test englishTest = new Test();
            CResults.TypeTest = "B1";
            englishTest.AddQuestion(new Question("A1", new String[] { "Esta es la respuesta", "Si hay1", "no1", "Ya1" }, "/Imagenes/pregunta (1).png", 0, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta2", new String[] { "Esta es la respuesta", "Si hay2", "no2", "Ya2" }, "/Imagenes/confuso.png", 1, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta3", new String[] { "Esta es la respuesta", "Si hay3", "no3", "Ya3" }, "/Imagenes/unicornio.png", 2, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta4", new String[] { "Esta es la respuesta", "Si hay4", "no4", "Ya4" }, "/Imagenes/idea.png", 3, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta5", new String[] { "Esta es la respuesta", "Si hay5", "no5", "Ya5" }, "/Imagenes/pensando.png", 4, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta6", new String[] { "Esta es la respuesta", "Si hay6", "no6", "Ya6" }, "/Imagenes/idea (1).png", 5, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta7", new String[] { "Esta es la respuesta", "Si hay7", "no7", "Ya7" }, "/Imagenes/pensar.png", 6, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta8", new String[] { "Esta es la respuesta", "Si hay8", "no8", "Ya8" }, "/Imagenes/profesor.png", 7, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta9", new String[] { "Esta es la respuesta", "Si hay9", "no9", "Ya9" }, "/Imagenes/reina.png", 8, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta10", new String[] { "Esta es la respuesta", "Si hay10", "no10", "Ya10" }, "/Imagenes/reino-unido.png", 9, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            CQuestions cQuestions = new CQuestions(frmQuestions, model, englishTest);
            view.Close();
            CTemporizador temporizador = new CTemporizador();
            temporizador.iniciarTempo(frmQuestions);
        }
        public void amarillo_Click(object sender, EventArgs e)
        {
            FrmQuestions frmQuestions = new FrmQuestions();
            Question model = new Question();
            Test englishTest = new Test();
            CResults.TypeTest = "B2";
            englishTest.AddQuestion(new Question("A1", new String[] { "Esta es la respuesta", "Si hay1", "no1", "Ya1" }, "/Imagenes/pregunta (1).png", 0, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta2", new String[] { "Esta es la respuesta", "Si hay2", "no2", "Ya2" }, "/Imagenes/confuso.png", 1, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta3", new String[] { "Esta es la respuesta", "Si hay3", "no3", "Ya3" }, "/Imagenes/unicornio.png", 2, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta4", new String[] { "Esta es la respuesta", "Si hay4", "no4", "Ya4" }, "/Imagenes/idea.png", 3, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta5", new String[] { "Esta es la respuesta", "Si hay5", "no5", "Ya5" }, "/Imagenes/pensando.png", 4, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta6", new String[] { "Esta es la respuesta", "Si hay6", "no6", "Ya6" }, "/Imagenes/idea (1).png", 5, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta7", new String[] { "Esta es la respuesta", "Si hay7", "no7", "Ya7" }, "/Imagenes/pensar.png", 6, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta8", new String[] { "Esta es la respuesta", "Si hay8", "no8", "Ya8" }, "/Imagenes/profesor.png", 7, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta9", new String[] { "Esta es la respuesta", "Si hay9", "no9", "Ya9" }, "/Imagenes/reina.png", 8, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            englishTest.AddQuestion(new Question("Cual es la pregunta10", new String[] { "Esta es la respuesta", "Si hay10", "no10", "Ya10" }, "/Imagenes/reino-unido.png", 9, "Esta es la respuesta", "https://www.britishcouncil.es/ingles/niveles/a1"));
            CQuestions cQuestions = new CQuestions(frmQuestions, model, englishTest);
            view.Close();
            CTemporizador temporizador = new CTemporizador();
            temporizador.iniciarTempo(frmQuestions);

        }



        private FrmMenu view;
    }
}
