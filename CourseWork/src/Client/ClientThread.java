package Client;

import java.net.Socket;
import java.io.DataOutputStream;
import java.io.DataInputStream;
import java.io.IOException;

public class ClientThread extends Thread
{
  private Socket socket;
  private DataOutputStream out;
  private DataInputStream in;
  public ClientThread(String host, int port)
  {
    try {
  this.socket = new Socket(host, port);
  System.out.println("������� �� � "+socket);
  this.in = new DataInputStream(this.socket.getInputStream());
  this.out = new DataOutputStream(this.socket.getOutputStream());
  this.start();
}

catch(IOException e)
{
  System.out.println("�� ���� �� �� ������ ��� �������");
    }
  }
  public void run()
  {
    try{
      while(true){
        System.out.println(this.in.readUTF());
      }
    }
    catch(IOException e)
    {
      System.out.println("������������ �� ������� ������ ������������ �� ������");
      this.interrupt();
    }
  }
  void sendMessage(int message)
  {
    try{
      this.out.writeInt(message);
      this.out.flush();
    }
    catch(IOException e)
    {
      System.out.println("�� ���� �� ������� ������");
    }
  }
  void close() throws IOException
  {
    if(this.in!=null) in.close();
    if(this.out!=null) out.close();
    if(this.socket!=null) socket.close();
  }
}
