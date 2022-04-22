using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Tarea_Carro_SS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public string Marca { get; }
        public int Modelo { get; }
        public String Color { get; set; }

        private int Encendido = 0;
        private int Apagado = 0;
        private int velocidad_actual = 0;
        private const int MAXVELOCIDAD = 150;



        public MainWindow(string _marca, int _modelo, string _color)
        {
            Marca = _marca;
            Modelo = _modelo;
            Color = _color;
            Encendido = 0;
            this.velocidad_actual = 0;
        }
        public string GetVelocidadActual()
        {
            return $"Vamos a {velocidad_actual} KPH";
        }
        public string EncenderMotor()
        {
            if (Encendido == 0)
            {
                Encendido = 1;
                this.velocidad_actual = 0;
                return "run run run run, listo para correr";
            }
            else
            {
                return "Orales!!! ya esta encendido tu carro";
               
            }
        }
        

        public string acelerar()
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = $"no puedo acelerar con el carro apagado";
                return mensaje;
            }

            velocidad_actual += 10;
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                mensaje = $"Vas a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = $"{velocidad_actual}KPH Aguas toretto, vas muy rapido y ya llegaste al tope";
            }

            Console.WriteLine(mensaje);
            return mensaje;

        }
        public string acelerar(int CuantosKPH)
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = $"no puedo acelerar con el carro apagado";
                return mensaje;
            }

            velocidad_actual += CuantosKPH;
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                mensaje = $"Vas a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = $"{velocidad_actual}KPH Aguas toretto, vas muy rapido y ya llegaste al tope";
            }

            Console.WriteLine(mensaje);
            return mensaje;

        }
        public string Desacelerar()
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = $"no puedo desacelerar con el carro apagado";
                return mensaje;
            }

            velocidad_actual -= 10;
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                mensaje = $"Vas a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = $"{velocidad_actual}KPH Aguas toretto, vas muy rapido y ya llegaste al tope";
            }

            Console.WriteLine(mensaje);
            return mensaje;

        }



        public string Desacelerar(int CuantosKPH)
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = $"no puedo desacelerar con el carro apagado";
                return mensaje;
            }

            velocidad_actual -= CuantosKPH;
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                mensaje = $"Vas a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = $"{velocidad_actual}KPH Aguas toretto, vas muy rapido y ya llegaste al tope";
            }

            Console.WriteLine(mensaje);
            return mensaje;
        }
        public string frenar()
        {
            string mensaje = "";

            velocidad_actual = 0;
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                mensaje = $"Vas a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = $"{velocidad_actual} Vas muy rapido chato, no agarran los frenos";
            }

            Console.WriteLine(mensaje);
            return mensaje;

        }
        public string ApagarMotor()
        {
            if (Apagado == 0)
            {
                
                Apagado = 1;
                this.velocidad_actual = 0;
                return "Se apago ";
            }
            else
            {
                return"Tranquilo chato ya se apago el motor";
            }
        }
        public string Bocinar()
        {
           return $"Beeep Beeep ";
        }
        //Boton Encender 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txbEncedido.Text = EncenderMotor();
        }
        //boton acelerar
        private void Acelerar_Click(object sender, RoutedEventArgs e)
        {
            
            txbAcelerar.Text = acelerar();
        }

        private void Desacelererar_Click(object sender, RoutedEventArgs e)
        {
            txbAcelerar.Text = Desacelerar();
        }

        private void Frenon_Click(object sender, RoutedEventArgs e)
        {
            txbAcelerar.Text = frenar();
        }

        private void Bocina_Click(object sender, RoutedEventArgs e)
        {
            txbbocina.Text = Bocinar();
        }

        private void Apagar_Click(object sender, RoutedEventArgs e)
        {
           txbEncedido.Text = ApagarMotor();
        }
      
            }
        }
    


       
