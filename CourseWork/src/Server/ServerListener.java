package Server;

import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;

public class ServerListener
{
  private ServerSocket servSock;
  public ServerListener(int port) throws IOException
  {
    servSock = new ServerSocket(port);
    System.out.println("�������� � ��������� � ����� �� ����: "+port);
  }
  public Socket acceptConnection() throws IOException
  {
    Socket s = this.servSock.accept();
    System.out.println("��� ������ "+s.toString());
    return s;
    
  }
}