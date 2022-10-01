#include "Program.h"

namespace ConsoleApp2
{

	void Program::Main(std::vector<std::wstring> &args)
	///op 1 la  op  es "animalpeligroso" (esta op indica si el animal es un animal peligroso , para eso tiene en cuenta las cualidades , la especie , la cantidad de dientes .Un animal es peligroso cuando en sus cualidades es venenoso o apestoso , si su especie es reptil y si la cant de dientes es igual >= 2 dientes. )
	/// La op 2 "reptil + y - comilon "(esta op muestra todos los atributos reptil que tienen mayor numero de comidas ingeridas en la semana ).
	///op 3 "poner a dieta a los mamiferos" (esta op decrementa un 25% las comidas ingeridas por semana que tienen los mamiferos ).
	/// op 4 "animales impares " (cada animal es identificado con un chip numerico , se debe mostrar todos los atibutos de  los animales con chip numerico impar )
	/// El programa debe realizarse con todas las estructuras y vectores.El programa debe realizarse para "X" cantidad de animales ingresado 
	{
		int a = 0;
		std::wcout << L"Ingrese cantidad de animales " << std::endl;
		a = std::stoi(Console::ReadLine());

		int op = 0;
		std::vector<int> cantdientes(a);
		std::vector<std::wstring> especie(a);
		std::vector<std::wstring> cualidad(a);
		std::vector<int> comidas(a);
		std::vector<int> id(a);
		int mayor = comidas[0];
		int menor = comidas[0];
		std::vector<double> comidasdecre(a);
		int posmayor = 0;
		int posmenor = 0;

		for (int i = 0; a > i; i++)
		{
			std::wcout << L"Ingrese cantidad de dientes del animal Nº: " << (i + 1) << std::endl;
			cantdientes[i] = std::stoi(Console::ReadLine());

			std::wcout << L"Ingrese cualidad del animal Nº: " << (i + 1) << std::endl;
			cualidad[i] = static_cast<std::wstring>(Console::ReadLine());

			std::wcout << L"Ingrese especie del animal Nº: " << (i + 1) << std::endl;
			especie[i] = static_cast<std::wstring>(Console::ReadLine());

			std::wcout << L"Ingrese comidas ingeridas  del animal Nº: " << (i + 1) << std::endl;
			comidas[i] = std::stoi(Console::ReadLine());

			std::wcout << L"Ingrese el id del animal Nº: " << (i + 1) << std::endl;
			id[i] = std::stoi(Console::ReadLine());

		}

		std::wcout << L"1 - Animal peligroso" << std::endl;
		std::wcout << L"2 - Poner a dieta a los mamifero" << std::endl;
		std::wcout << L"3 - Reptil mas y menos comilon" << std::endl;
		std::wcout << L"4 - Animales impares" << std::endl;
		op = std::stoi(Console::ReadLine());
		do
		{



			switch (op)
			{

				case 1:
					for (int k = 0; a > k; k++)
					{
						std::wcout << L"" << std::endl;
						if (cualidad[k] == L"venenoso" && especie[k] == L"reptil" && cantdientes[k] <= 2 || cualidad[k] == L"apestoso" && especie[k] == L"reptil" && cantdientes[k] <= 2)
						{
							std::wcout << L"" << std::endl;
							std::wcout << L"El animal" << L"  " << id[k] << L"  " << L"es peligroso" << std::endl;
							std::wcout << L"" << std::endl;
						}
						else
						{
							std::wcout << L"" << std::endl;
							std::wcout << L"El animal" << L"  " << id[k] << L"" << std::endl;
							std::wcout << L"" << std::endl;
						}
					}

					break;


				case 2:
					//mayor
					for (int c = 0; c < a; c++)
					{
						if (mayor > comidas[c])
						{

							posmayor = c;

						}

					}
					std::wcout << L"" << std::endl;
					std::wcout << L"Mayor" << std::endl;
					std::wcout << L"Datos del animal que mas comida semanal comio" << std::endl;
					std::wcout << L"El id  : " << id[posmayor] << std::endl;
					std::wcout << L"La cantidad de dientes : " << cantdientes[posmayor] << std::endl;
					std::wcout << L"Cualidad : " << cualidad[posmayor] << std::endl;
					std::wcout << L"Especie :  " << especie[posmayor] << std::endl;
					std::wcout << L"Cantidad de comida semanal " << comidas[posmayor] << std::endl;
					std::wcout << L"" << std::endl;

					//menor
					for (int l = 0; l < a; l++)
					{
						if (mayor < comidas[l])
						{

							posmenor = l;

						}

					}
					std::wcout << L"" << std::endl;
					std::wcout << L"Datos del animal que menos comida semanal comio" << std::endl;
					std::wcout << L"El id  : " << id[posmenor] << std::endl;
					std::wcout << L"La cantidad de dientes : " << cantdientes[posmenor] << std::endl;
					std::wcout << L"Cualidad : " << cualidad[posmenor] << std::endl;
					std::wcout << L"Especie :  " << especie[posmenor] << std::endl;
					std::wcout << L"Cantidad de comida semanal " << comidas[posmenor] << std::endl;
					std::wcout << L"" << std::endl;
					break;

				case 3:
					for (int d = 0; d < a; d++)
					{
						comidas[d] = (comidas[d] * 25 / 100);
						std::wcout << L"El id  : " << id[d] << std::endl;
						std::wcout << L"La cantidad de dientes : " << cantdientes[d] << std::endl;
						std::wcout << L"Cualidad : " << cualidad[d] << std::endl;
						std::wcout << L"Especie :  " << especie[d] << std::endl;
						std::wcout << L"Cantidad de comida semanal " << comidas[d] << std::endl;
						std::wcout << L"" << std::endl;
					}
					break;

				case 4:
					for (int r = 0; r < a; r++)
					{
						if (id[r] % 2 == 0)
						{
							std::wcout << L"El id  : " << id[r] << std::endl;
							std::wcout << L"La cantidad de dientes : " << cantdientes[r] << std::endl;
							std::wcout << L"Cualidad : " << cualidad[r] << std::endl;
							std::wcout << L"Especie :  " << especie[r] << std::endl;
							std::wcout << L"Cantidad de comida semanal " << comidas[r] << std::endl;
							std::wcout << L"" << std::endl;

						}
					}
					break;
			}
		} while (op != 6);
	}
}
