*
 *Desarrollado por: Javier Diaz;
 *Equipo: Recyclers Coders;
 */

import java.io.*;
import java.text.DecimalFormat;
public class Kolgomorov {
	public static void main(String [] args) throws IOException{
		int i_N;
		double[] f_uno,f_ri, f_three, f_four, f_five;

		Kolgomorov ins = new Kolgomorov();
		DecimalFormat df = new DecimalFormat("0.00");
		BufferedReader leer = new BufferedReader(new InputStreamReader(System.in));
		System.out.print("Introduce el total de numero a evaluar: ");
		i_N = Integer.parseInt(leer.readLine());

		f_uno = new double[i_N];
		f_ri = new double[i_N];
		f_three = new double[i_N];
		f_four = new double[i_N];
		f_five = new double[i_N];

		// Base 2 ri;
		for(int i=0;i<i_N;i++){
			System.out.print("Valor #"+(i+1)+": ");
			f_ri[i] = Float.parseFloat(leer.readLine());
		}

		// Base 1 i/n;
		for(int i=0;i<i_N;i++){
			f_uno[i] = (double) (i+1)/i_N;
		}

		// Base 3 (i-1)/N
		for(int i=0;i<i_N;i++){
			f_three[i] = (double) ((i+1)-1)/i_N;
		}

		// order by asc;
		ins.bubblesort(f_ri);

		//Base 4 (i/n)-ri
		for(int i=0;i<i_N;i++){
			f_four[i] = (double) f_uno[i]-f_ri[i];
		}

		//Base 5 ri - ((i/n)-ri);
		for(int i=0;i<i_N;i++){
			f_five[i] = (double) f_ri[i]-f_four[i];
		}

		System.out.print("i  \t\t\t");
		for(int i=1;i<=i_N;i++){System.out.print(i+"\t");}
		System.out.print("\n-------------------------------------------------------------------------------------------------------------------");
		System.out.print("\n");

		System.out.print("i/n\t\t\t");
		for(int i=0;i<i_N;i++){System.out.print(df.format(f_uno[i])+"\t");}
		System.out.print("\n");

		System.out.print("ri\t\t\t");
		for(int i=0;i<i_N;i++){System.out.print(df.format(f_ri[i])+"\t");}
		System.out.print("\n");

		System.out.print("(i-1)/n\t\t\t");
		for(int i=0;i<i_N;i++){System.out.print(df.format(f_three[i])+"\t");}
		System.out.print("\n");

		System.out.print("(i/n)-ri\t\t");
		for(int i=0;i<i_N;i++){System.out.print(df.format(f_four[i])+"\t");}
		System.out.print("\n");

		System.out.print("ri-((i/n)-ri)\t\t");
		for(int i=0;i<i_N;i++){System.out.print(df.format(f_five[i])+"\t");}
		System.out.print("\n\nN = "+i_N);
		System.out.print("\n-------------------------------------------------------------------------------------------------------------------\n");

		ins.bubblesort(f_four);
		ins.bubblesort(f_five);
		System.out.print("D+ = "+df.format(f_four[f_four.length-1])+"\t\t"+"D- = "+df.format(f_five[f_five.length-1])+"\t\t"+"D = ("+df.format(f_five[f_five.length-1])+","+df.format(f_four[f_four.length-1])+")");
	}

	// vector ri;
	public void bubblesort(double[] datos){
		double buffer;
		for(int i=0;i < datos.length; i++){
			for(int j=0; j < i; j++){
				if(datos[i] < datos[j]){
					buffer = datos[j];
					datos[j] = datos[i];
					datos[i] =buffer;
				}
			}
		}
	}
}
