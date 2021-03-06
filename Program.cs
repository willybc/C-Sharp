﻿using institucion.Misc;
using institucion.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace institucion
{
    class Program
    {
        private static byte[] stringBytes;

        static void Main(string[] args)
        {
            var listaProfes = new List<Profesor>();

            string[] lineas = File.ReadAllLines("./Files/Profesores.txt");

            int localId = 0;

            foreach (var linea in lineas)
            {
                listaProfes.Add(new Profesor()
                {
                    Nombre = linea,
                    Id = localId++
                });
            }

            foreach (var profe in listaProfes)
            {
                Console.WriteLine(profe.Nombre);
            }

            var archivo = File.Open("profesBinarios.bin", 
                FileMode.OpenOrCreate);

            var binFile = new BinaryWriter(archivo);
            foreach (var profe in listaProfes)
            {
                var bytesNombre = Encoding.UTF8.GetBytes
                    (profe.Nombre);
                archivo.Write(bytesNombre, 0, bytesNombre.Length);

                binFile.Write(profe.Nombre);
                binFile.Write(profe.Id);
            }

            binFile.Close();
            archivo.Close();



            //List<Persona> listaPersonas = new List<Persona>();

            //listaPersonas.Add (new Alumno("Pedro", "Ferdandez") { NickName="Pedrito"});
            //listaPersonas.Add (new Profesor(){ Nombre = "Profesor", Apellido = "X" });
            //listaPersonas.Add (new Alumno("Pedro", "Pedroza"));
            //listaPersonas.Add (new Profesor(){ Nombre = "Maf", Apellido = "Neto" });


            //foreach (var obj in listaPersonas)
            //{

            //    if (obj is Alumno)
            //    {
            //        var al = (Alumno)obj;
            //        Console.WriteLine(al.NickName != null ? al.NickName : al.NombreCompleto);
            //    }
            //    else
            //    {
            //        var per = obj as Persona;

            //        if (per != null)
            //            Console.WriteLine(per.NombreCompleto);
            //    }
            //}

            Console.ReadLine();
        }

        private static void Rutina5()
        {
            var profesor = new Profesor() { Id = 12, Nombre = "Mateo", Apellido = "Pereira", CodigoInterno = "PROFE_SMART" };

            var transmitter = new TransmisorDeDatos();
            transmitter.InformacionEnviada += Transmitter_InformacionEnviada;
            transmitter.InformacionEnviada += (obj, evtarg) =>
            {
                Console.WriteLine("WOOOOOOOOOOA");
            };

            transmitter.FormatearYEnviar(profesor, Reverseformatter,
                "ALEXTROIO");

            transmitter.InformacionEnviada -= Transmitter_InformacionEnviada;

            transmitter.FormatearYEnviar(profesor,
                (s) => new string(s.Reverse().ToArray<char>())
                , "ALEXTROIO");
        }

        private static void Transmitter_InformacionEnviada(object sender, EventArgs e)
        {
            Console.WriteLine("TRANSMISION DE INFORMACION");
        }

        private static string Reverseformatter(string input) => new string(input.Reverse().ToArray<char>());
        

        private static string formatter(string input)
        {
            var bytes = Encoding.UTF8.GetBytes(input);

            var base64 = Convert.ToBase64String(bytes);

            return base64;
        }

        private void Rutina4()
        {
            Persona[] arregloPersonas = new Persona[5];

            var tam = arregloPersonas.Length;

            arregloPersonas[0] = new Alumno("Pedro", "Ferdandez") { NickName = "Pedrito" };
            arregloPersonas[1] = new Profesor()
            { Nombre = "Profesor", Apellido = "X" };

            arregloPersonas[2] = new Alumno("Pedro", "Pedroza");
            arregloPersonas[3] = new Profesor()
            { Nombre = "Maf", Apellido = "Neto" };

            arregloPersonas[4] = new Alumno("Mathias", "Es");
            //arregloPersonas[5] = new Profesor()
            //{ Nombre = "Alberto", Apellido = "Stone" };

            for (int i = 0; i < arregloPersonas.Length; i++)
            {
                if (arregloPersonas[i] is Alumno)
                {
                    var al = (Alumno)arregloPersonas[i];
                    Console.WriteLine(al.NickName != null ? al.NickName : al.NombreCompleto);
                }
                else
                {
                    Console.WriteLine(arregloPersonas[i].NombreCompleto);
                }
            }
        }
        
        private static void Rutina3()
        {
            var alumno = new Alumno("Victor", "Perez");
            var profesor = new Profesor();
            Persona persona = profesor;

            alumno = (Alumno)persona;

            if (persona is Alumno)
            {
                //.....
            }

            var tmpProfe = persona as Profesor;

            if (tmpProfe != null)
            {
                //.....
            }
        }

        private static void Rutina2()
        {
            // -32.000 +32.000
            short s = 32000;
            int i = 33000;
            float f = 2.35f;
            decimal d = 0;

            Console.WriteLine(i);
            s = (short)i;
            Console.WriteLine(s);
            Console.WriteLine(f);
            i = (int)f;
            Console.WriteLine(i);
        }

        public void Rutina1()
        {
            Console.WriteLine("GESTION DE INSTITUCION");

            Persona[] lista = new Persona[3];
            lista[0] = new Alumno("Juan", "Perez")
            {
                Id = 1,
                Edad = 20,
                Telefono = 1188491671,
                Email = "prueba@hotmail.com"
            };


            lista[1] = new Profesor()
            {
                Id = 2,
                Nombre = "Juan",
                Apellido = "Ruiz",
                Edad = 34,
                Teléfono = 55555555,
                Catedra = "Programacion"
            };

            lista[2] = new Profesor()
            {
                Id = 3,
                Nombre = "William",
                Apellido = "Torvalds",
                Edad = 25,
                Teléfono = 911,
                Catedra = "Algebra"
            };


            Console.WriteLine(Persona.ContadorPersonas);
            Console.WriteLine("Resumenes");

            foreach (Persona p in lista)
            {
                Console.WriteLine($"Tipo {p.GetType()}");
                Console.WriteLine(p.ConstruirResumen());

                IEnteInstituto ente = p;

                ente.ConstruirLlaveSecreta("Hola");
            }

            Console.WriteLine("S T R U C T S");
            /* PRIMERA MANERA */
            CursoStruct c_class1 = new Models.CursoStruct(70);
            c_class1.Curso = "101-B";

            /*SEGUNDA MANERA */
            CursoStruct newC = new CursoStruct();
            newC.Curso = "564-A";

            var cursoFreak = c_class1;
            cursoFreak.Curso = "666-G";

            Console.WriteLine($"Curso c = {c_class1.Curso}");
            Console.WriteLine($"Curso Freak = {cursoFreak.Curso}");






            Console.WriteLine("C L A S E S");
            /* PRIMERA MANERA */
            CursoClass c_class = new CursoClass(70);
            c_class.Curso = "101-B";

            /*SEGUNDA MANERA */
            var newCc_class = new CursoStruct();
            newCc_class.Curso = "564-A";

            var cursoFreakc_class = c_class;
            cursoFreak.Curso = "666-G";

            Console.WriteLine($"Curso c = {c_class.Curso}");
            Console.WriteLine($"Curso Freak = {cursoFreakc_class.Curso}");

            /*ENUMERACIONES*/
            Console.WriteLine("E N U M E R A C I O N E S");

            var alumnoEst = new Alumno("Pablo", "Number")
            {
                Id = 6,
                Edad = 86,
                Telefono = 57856546,
                Estado = EstadosAlumno.Activo
            };

            Persona personaX = alumnoEst;
            Console.Write("Estado de alumno" + alumnoEst.Estado);

            IEnteInstituto iei = alumnoEst;

            Console.WriteLine("Estado de alumno" + alumnoEst.Estado);

            Console.WriteLine($"Tipo: { typeof(EstadosAlumno)} ");
            Console.WriteLine($"Tipo: { typeof(Alumno)} ");
            Console.WriteLine($"Tipo: { alumnoEst.GetType() }");
            Console.WriteLine($"Tipo: { personaX.GetType() }");

            Console.WriteLine($"Nombre: { nameof(Alumno)} ");
            Console.WriteLine($"Tamaño: { sizeof(int)} ");


            Console.ReadLine();
        }


        
    }
}
