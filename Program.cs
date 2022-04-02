
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using guarderiacaninos;

namespace guarderiacaninos;

	class caninos
	{

		




	public static void
	char tiporaza[7];
	char tamaño[10];
	int raza, peso, s, r, totalh, totalm, total, tipo;


	struct h_enter
	{
		int hora;
		int minutos;
	}
	

	struct h_exit
	{
		int hora;
		int minutos;
	}
	

	void ingresar(int can);
	int liquidar(char* s);
	void reporte();
};


class estancia
{
	public 
	
	void tiempo();
}


class contador
{
	public:
	int i, ganan;
	int mostrar();
};

//declaracion del metodo

int contador::mostrar()
{
	string i = endl;
	
	return i;
}

//los metodos.
static void caninoingresar(int can, int totalh)
{
	can = 20;
    int endl = 0;
     ("\n\n\n\t\t\tingrese el numero de cliente:") << endl;
	string raza;
	string (" \n\t\t\t¡gracias¡ \n\t\t\t ahora digite la raza del canino:") <<endl;
	string (raza+"puppy");
	do
	{
		Console.WriteLine("\t\t\tdigite el tipo de raza");
		Console.WriteLine("\n\t\t\ttipo 1:\t para razas grandes, cachorros");
		Console.WriteLine("\n\t\t\ttipo 2:\t para razas grandes, adultos");
		Console.WriteLine("\n\t\t\ttipo 3:\t para razas pequeñas, cachorros");
		Console.WriteLine("\n\t\t\ttipo 4:\t para razas pequeñas, adultos");
		tipo=int.Parse(Console.ReadLine());
		for (r = 1; r < 5; r++) 
		{
			if (tipo == r) 
				break;
		}
		if (r > 4)
		{
			Console.WriteLine("\t\tel tipo no es correcto por favor reingrese la raza del cachorro");
			r = 7; 
		}
	}
	while (r == 7);
	Console.WriteLine("ingrese la hora de entrada (00-23):");
	do
	{
		if (hora > 23 || hora < 0) ;
			Console.WriteLine(" \n la hora de entrada no es correcta \nreingrese la hora de entrada");
	}
	while (hora > 23) (hora < 0);

	Console.WriteLine("\ndigite los minutos (00-59):");
	do
	{
		double hent.object minutos = null;
        minutos;
		if (hent.minutos > 59 || hent.minutos < 0)
			Console.WriteLine(" \n los minutos no son correctos \nreingrese los minutos")
	while (hent.minutos > 59 || hent.minutos < 0);
	system("CLS");



{
			Console.WriteLine ("\n\n\n\t\t numero de huesped \t");
			Console.WriteLine("\t\t raza \t ");
			Console.WriteLine("\t\t tipo  \t ");
			Console.WriteLine("\t\t hora de entrada:\n\t\t\t " + hent.minutos + hent.horas);
}
int canino::liquidar(char * s);
{
	int p;
            object huesped = null;
          
            p = string(huesped, s);
	if (p == 0)
	{
		do
		{
					Console.WriteLine ("digite hora de salida (00-47)");
			string (hexi.hora);
		}
		while (hexi.hora < hent.hora);
				Console.WriteLine("digite minutos");
		string  (hexi.minutos);
		system("CLS");
		totalh = hexi.hora - hent.hora;
		totalh = hexi.minutos - hent.minutos;
		if (totalm < 0)
		{
			totalh--;
			totalm = 60 + totalm;
		}
		total = (totalh * 60) + totalm;
		total = total / 60;
		if (tipo == 1)
		{
			if (total < 6)
				total = total * 1000;
			else
				if (total < 12)
				total = 3000;
			else
				total = total * 250;
		}
		if (tipo == 2)
		{
			if (total < 6)
				total = total * 1500;
			else
				if (total < 12)
				total = 4000;
			else
				total = total * 350;
		}
		if (tipo == 3)
		{
			if (total < 6)
				total = total * 7000;
			else
				if (total < 12)
				total = 2000;
			else
				total = total * 250;
		}
		if (tipo == 4)
		{
			if (total < 6)
				total = total * 2500;
			else
				if (total < 12)
				total = 7000;
			else
				total = total * 500;
		}
				Console.WriteLine("\t\t\tel canino estuvo: "+totalh+"-"+totalm+"\n debe pagar:"+total+"$");
		system("PAUSE");
	}
	return p;
}

void estancia tiempo();
{
	struct tm *punt1;
Timeout ti;

     }
{
	void menu();

string caninos;

	contador* c;
	c = new contador();

	estancia pk;

	canino * q;
	for (int y = 0; y < 20; y++)
		q = new guarderiacaninos[y];

	canino z[20];

	int x = 20, i, pp, vv, l, ganan, a;
	char plaka[7], decs;
	char opc;

	con.open("a:\\i.save", ios::in| ios::binary);
	con.read((char*)c, sizeof(contador));
	c->mostrar();
	con.close();
	con.open("a:\\i.save", ios::out| ios::binary);
	con.write((char*)c, sizeof(contador));
	c->mostrar();
	con.close();
	con.open("a:\\i.save", ios::out| ios::binary);
	con.write((char*)c, sizeof(contador));
	i = c->i;
	ganan = c->ganan;
	con.close();
	int aux = i;

	for (a = 0; a < (i + 1); a++);
	{

		if (a != 0)
			q++;
		StreamWriter fichero;
		string nombrefichero = "C:\\Users\\equipo jaime\\Desktop\\elefantes" + DateTime.Now.ToShortDateString().Replace("/", "-") + ".txt";
		fichero = File.AppendText(nombrefichero);


		{
			aux = i;
			system("CLS");
			Console.WriteLine("\n\n\n\t\t\t\tParking Demon");
			Console.WriteLine("\n\n\n\t\t\t¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
			Console.WriteLine("\t\t\t\1\t 1.ingresar\t    \1");
			Console.WriteLine("\t\t\t\2\t 2.ganancias\t    \2");
			Console.WriteLine("\t\t\t\1\t 3.liquidar\t    \1");
			Console.WriteLine("\t\t\t\2\t 4.reporte \t    \2");
			Console.WriteLine("\t\t\t\1\t 5.salir   \t    \1");
			Console.WriteLine("\t\t\t\2\t digite su opcion   \2");
			Console.WriteLine("\t\t\t");
		}
		{ 
		if (i < 0)
	
			i = -1;
		Console.WriteLine("no hay caninos en estancia");
		}
		else
		{
			if (i == 0)
			{
			Console.WriteLine("solo hay un canino en estancia");
			}
			else
			{
		Console.WriteLine("en el momento hay " << i + 1 << "caninos en estancia temporal");
			}
		}
Console.WriteLine("\t\t\t\t");
		system("CLS");
		switch();

		{
			aux = i;
		case '1':
			system("CLS");
if (i > x)
{
		Console.WriteLine("ha superado el numero de caninos en la estancia");
}
else
{
	if (i > -2)
	{
		i++;
		if (i != 0)
			q++;
		caninos.open("", ios::out| ios::binary);
		caninos.write((char*)q, sizeof(caninos));
		q->ingresar(i);
		q->reporte();
		caninos.close();
		z[i] = *q;

	}
}

break;

		case '2':
			system("CLS");
	Console.WriteLine("\n\n\n\t\t\t se ha registrado a su can:" << ganan << "$" << endl);
	Console.WriteLine("\n\n\n\n\t\t\t";
system("PAUSE");
system("CLS");

break;

		case '3':
			system("CLS");
	Console.WriteLine("digite el nombre del can");
for (vv = 0; vv < (i + 1); vv++)
{
		if (vv != 0)
		q--;
	aux--;
	caninos.write((char*)q, sizeof(caninos));
	q->reporte();
	caninos.close();
	pp = q->liquidar(plaka);

	if (pp == 0 && i > -1)
	{
		ganan = ganan + q->total;
			Console.WriteLine("el can ha salido de la estancia");

	}
	else
		z[vv] = *q;

}

if (pp != 0)
{
		Console.WriteLine("el can digitado no ha ingresado.");
	system("PAUSE");
}

for (a = 0; a < (i + 1); a++)
{
	q = &z[a];
	if (a != 0)
		q++;
}

break;
		case '4':
			system("CLS");
	Console.WriteLine("\n\n\n\t\t\tEste es el reporte de los canes ingresados");
if (i == -1)
{
		Console.WriteLine("\n\t\t\ten el momento no hay canes en la estancia");
	system("PAUSE");
}
for (l = 0; l < (i + 1); l++)
{
	if (l != 0)
		q--;
		string nombrefichero = "C:\\Users\\equipo jaime\\Desktop\\elefantes" + DateTime.Now.ToShortDateString().Replace("/", "-") + ".txt";
	fichero = File.AppendText(nombrefichero);

				q->reporte();
	caninos.close();
				Console.WriteLine("\t\t\t____________________________________");
	system("PAUSE");
	system("CLS");
	aux = i - 1;
}
for (a = 0; a < (i + 1); a++)
{
	q = &z[a];
	if (a != i)
		q++;
}

	while (opc != '5') ;
string nombrefichero = "C:\\Users\\equipo jaime\\Desktop\\elefantes" + DateTime.Now.ToShortDateString().Replace("/", "-") + ".txt";
	fichero = File.AppendText(nombrefichero);
c->i = i;
c->ganan = ganan;
			string nombrefichero = "C:\\Users\\equipo jaime\\Desktop\\elefantes" + DateTime.Now.ToShortDateString().Replace("/", "-") + ".txt";
			fichero = File.AppendText(nombrefichero);
			con.write((char*)c, sizeof(contador));
c->mostrar();
con.close();
			string nombrefichero = "C:\\Users\\equipo jaime\\Desktop\\elefantes" + DateTime.Now.ToShortDateString().Replace("/", "-") + ".txt";
			fichero = File.AppendText(nombrefichero);
			c->i = i;
c->ganan = ganan;
con.close();


	menu();
}

