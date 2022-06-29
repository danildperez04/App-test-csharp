using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using App_test_csharp.View;
namespace App_test_csharp.Controller
{
    public class CTemporizador : Window
    {
		public void iniciarTempo(FrmQuestions ventana)
        {
			
			DispatcherTimer temporizador = new DispatcherTimer();
			ventana.Show();

			temporizador.Interval = new TimeSpan(0, 0, 0, 0, 1000);
			int segundos = 9;
			int minutos = 0;
			
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
						MessageBox.Show("LO SENTIMOS HA REPROBADO EL EXAMEN!!", "TEST", MessageBoxButton.OK, MessageBoxImage.Information);
						temporizador.Stop();
						ventana.Close();
						FrmMenu frmMenu = new FrmMenu();
						frmMenu.Show();


					}
				}
			};
			temporizador.Start();
			
		}
	}
}
