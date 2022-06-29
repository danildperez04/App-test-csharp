using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using App_test_csharp.View;
using ClassesLibrary.Controller;

namespace App_test_csharp.Controller
{
    public class CTemporizador : Window
    {
		public void iniciarTempo(FrmQuestions ventana)
        {
			
			DispatcherTimer temporizador = new DispatcherTimer();
			ventana.Show();

			temporizador.Interval = new TimeSpan(0, 0, 0, 0, 1000);
			int segundos = 59;
			int minutos = 9;
			
			temporizador.Tick += (a, b) =>
			{
				
				ventana.LblTemporizador.Content = minutos + ":" + segundos;
				segundos--;

				if (segundos < 0)
				{
					segundos += 60;
					minutos--;
					if (minutos < 0)
					{	
						
						minutos++;
						MessageBox.Show("LO SENTIMOS HA REPROBADO EL EXAMEN!!, POR FAVOR VOLVER A EJECUTAR Y INGRESAR NUEVAMENTE", "TEST", MessageBoxButton.OK, MessageBoxImage.Information);
						temporizador.Stop();
						ventana.Close();
						Environment.Exit(0);


					}
				}
			};
			temporizador.Start();
			
		}
	}
}
