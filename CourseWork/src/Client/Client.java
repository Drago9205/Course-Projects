package Client;

import java.util.Scanner;

public class Client{
  public static void main(String[] args)
  {
    String host = "localhost";
int port = 1234;
Scanner keyboardIn = new Scanner(System.in);
ClientThread c = new ClientThread(host, port);
int messageOut;
int messageOut2;
while(true)
{
  messageOut = keyboardIn.nextInt();
  messageOut2 = keyboardIn.nextInt();
	  c.sendMessage(messageOut);
	  c.sendMessage(messageOut2);
}
  }
}
