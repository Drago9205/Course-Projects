package Server;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.Socket;

public class ServerThread extends Thread
{
  private Socket sock;
  DataOutputStream os;
  public ServerThread(Socket sock)
  {
    this.sock = sock;
    this.start();
  }
  public void run()
  {
    DataInputStream in;
    int message, message2;
    try{
      in = new DataInputStream(this.sock.getInputStream());
      server.SendList(os, sock);
      while(true){
      message = in.readInt();
      message2 = in.readInt();
      server.idpick(message, message2, os, sock);
      System.out.println("Client"+sock.toString()+" Requested item with ID "+message+". The requested amount of items is: " +message2);
  }
}
catch(IOException e)
{
  System.out.println("Проблем с предаване на данни до "+this.sock.toString());
    }
    finally
    {
      server.removeClient(this.sock);
    }
  }
}