package employee;

import java.util.Scanner;

public class SubStrings {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		System.out.println("enter full name: ");
		String str = sc.nextLine();
		String result;
		String arr[] = str.split(" ");
		int i = 0;
		int len = arr.length;
		int last = arr.length-1;
		for(i = 0;i<len;i++) {
			if(i != last) {
				System.out.print(arr[i].substring(0,1).toUpperCase()+".");
			}
		}
		System.out.print(arr[last].substring(0,1).toUpperCase()+arr[last].substring(1));
	}

}
