import java.io.*;
public class prb_huecos {
	public static void main(String [] args) throws IOException{
		int i_n, i=0, Oi, Hi=0, aux=0;
		float i_num, i_alfa, i_beta, f_value, f_eisum=0, f_chisum=0;
		int[] i_serie, Oihuecos;
		float[] f_ei = new float[6], f_chi = new float[6];
		String s_binaria = "";
		String[] s_bin_ceros; //ceros
		String[] s_bin_unos;


		BufferedReader leer = new BufferedReader(new InputStreamReader(System.in));
		System.out.print("Numeros a evaluar: ");
		i_n = Integer.parseInt(leer.readLine()); //total de numeros;
		i_serie = new int[i_n]; //serie binaria;

		//intervalos;
		System.out.print("Intervalo alfa: ");
		i_alfa = Float.parseFloat(leer.readLine());
		System.out.print("Intervalo beta: ");
		i_beta = Float.parseFloat(leer.readLine());

		//creacion de la serie binaria;
		while(i < i_n){
			System.out.print("Valor #"+(i+1)+": ");
			i_num = Float.parseFloat(leer.readLine());
			if(i_num >= i_alfa && i_num <= i_beta){
				i_serie[i] = 1;
			}else{
				i_serie[i] = 0;
			}
			i++;
		}

		//Imprimir valores binarios;
		System.out.print("\nSerie Binaria: { ");
		for(int in=0;in<i_n;in++){
			System.out.print(i_serie[in]+" ");
			s_binaria = s_binaria + i_serie[in];
		}System.out.print("}");

		s_bin_ceros = s_binaria.split("1"); //saco los ceros;
		s_bin_unos = s_binaria.split("0"); //saco los unos;

		Oihuecos = new int[6]; //Espacio de huecos
		//ceros
		for(int in=0;in<s_bin_ceros.length;in++){
			Oi = s_bin_ceros[in].length();
			switch(Oi){
				case 0:
					Oihuecos[0]++;
				break;
				case 1:
					Oihuecos[1]++;
				break;
				case 2:
					Oihuecos[2]++;
				break;
				case 3:
					Oihuecos[3]++;
				break;
				case 4:
					Oihuecos[4]++;
				break;
				default:
					if(Oi>=5){Oihuecos[5]++;}
				break;
			}
		}

		//unos
		for(int in=0;in<s_bin_unos.length;in++){
			Oi = s_bin_unos[in].length();
			switch(Oi){
				default:
					if(Oi>=2){aux = aux + 1;Oihuecos[0] = aux;}
				break;
			}
		}

		//suma de huecos;
		for(int in=0;in<6;in++){
			Hi = Hi + Oihuecos[in];
		}

		//operaciones Ei
		for(int in=0;in<6;in++){
			f_value = (float) Math.pow((1 - (i_beta - i_alfa)),in);
			f_ei[in] = (Hi)*(i_beta-i_alfa)*(f_value);
			if(in == 5){f_ei[in] = (Hi)*(f_value);}
		}

		//operaciones x2
		for(int in=0;in<6;in++){
			f_value = (float) Math.pow(f_ei[in]-Oihuecos[in], 2);
			f_chi[in] = f_value / f_ei[in];
		}

		//sumas ei;
		for(int in=0;in<6;in++){
			f_eisum = f_eisum + f_ei[in];
		}

		for(int in=0;in<6;in++){
			f_chisum = f_chisum + f_chi[in];
		}

		//Impresion de tabla;
		System.out.print("\n\n");
		System.out.println("Tmñ"+"\t\t"+"Oi"+"\t\t"+"Ei"+"\t\t\t"+"CHi");
		System.out.println("----------------------------------------------------------------------");
		for(int in=0;in<6;in++){
			System.out.println(in+"\t\t"+Oihuecos[in]+"\t\t"+f_ei[in]+"\t\t"+f_chi[in]);
		}System.out.println("---------------------------------------------------------------------");
		System.out.println("Total"+"\t\t"+"H="+Hi+"\t\t"+f_eisum+"\t\t\t"+f_chisum);

		/*for(int in=0;in<s_bin_ceros.length;in++){
			System.out.print(s_bin_ceros[in]+" ");
		}
		
		for(int in=0;in<s_bin_unos.length;in++){
			System.out.print(s_bin_unos[in]+" ");
		}*/

	}
}
