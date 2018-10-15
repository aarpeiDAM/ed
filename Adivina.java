import java.util.Random;
import java.util.Scanner;

public class Adivina {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner tcl=new Scanner(System.in);
		Random random = new Random();
		int numeroAleatorio=random.nextInt(1000)+1;
		System.out.println("Adivina un número (entre 1 y 1000):");
		int numeroIntroducido=Integer.parseInt(tcl.nextLine());
		while(numeroIntroducido != numeroAleatorio) {
			if(numeroIntroducido < numeroAleatorio)
				System.out.println("Es mayor que ese.");
			else
				System.out.println("Es menor que ese.");
			
			System.out.println("Adivina un número (entre 1 y 1000):");
			numeroIntroducido = Integer.parseInt(tcl.nextLine());
			
		}
		System.out.println("Has ganado!!!");
	}

}
