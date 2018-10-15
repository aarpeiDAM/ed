package org.institutoserpis.ed;
import java.util.Scanner;
import java.math.BigDecimal;
public class JSuma {

	public static void main(String[] args) {
		Scanner tcl = new Scanner(System.in);
		System.out.println("Introduce un número:");
		BigDecimal num1 = new BigDecimal(tcl.nextLine());
		System.out.println("Introduce el segundo número:");
		BigDecimal num2 = new BigDecimal(tcl.nextLine());
		
		BigDecimal suma=num1.add(num2);
		BigDecimal resta = num1.substract(num2);
		BigDecimal producto = num1.multiply(num2);
		BigDecimal division = num1.divide(num2);
		System.out.println("El primer número era: "+num1);
		System.out.println("El segundo número era: "+num1);
		System.out.println("La suma de los números es: "+suma);
		System.out.println("La resta de los números es: "+resta);
		System.out.println("La multiplicación de los números es: "+producto);
		System.out.println("La división de los números es: "+division);
	}

}
