package Server;

import java.io.IOException;
import java.io.DataOutputStream;
import java.io.OutputStream;
import java.net.Socket;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.sql.PreparedStatement;
import Server.ServerThread;
import Server.ServerListener;

public class server
{
//Код свързан с базата данни{	
public static Connection connect(String url, String user, String password)
 {
	    Connection result = null;
	    try{
	      result = DriverManager.getConnection(url, user, password);
	    }
	    catch(SQLException e){
	      e.printStackTrace();
	    }
	    return result;
 }
 //}
  private static int port = 1234;
  private static ArrayList<Socket> clients = new ArrayList<Socket>(10);
  
  public static void main(String[] args)
  {
    ServerListener s = null;
    try
    {
      s = new ServerListener(port);
    }
    catch(IOException e)
    {
  System.out.println("Не може да се отвори ServerSocket на порт: "+port);
  return;
    }
while(true)
{
  try{
    Socket clientSocket = s.acceptConnection();
    clients.add(clientSocket);
    new ServerThread(clientSocket);
  }
  catch(IOException e)
  {
    System.out.println("Неуспешно свързване на клиент...");
  }
}
  }
   
  public static void SendList(DataOutputStream out, Socket threadSocket)
  {
	String url = "jdbc:mysql://localhost:3306/storehouse";
String user = "root";
String pass = "9205193966";
Connection link = server.connect(url, user, pass);
if(link == null)
{
    System.out.println("Опа, MySQL не е пуснат!");
    return;
}
  else
  {
    System.out.println("Свързах се с MySQL сървъра!");
  }
Statement stmt = null;
ResultSet resultSet = null;
String sendList ="";
try{
  stmt = link.createStatement();
  resultSet = stmt.executeQuery("SELECT products.id, groups.group, brands.brand, products.model, products.amount, products.price FROM products, groups, brands WHERE products.group_id=groups.id AND products.brand_id=brands.id ORDER BY products.id");
  while (resultSet.next()) 
  {
	sendList = sendList+ "Item with id: "+resultSet.getShort("id")+"\n"+"Is from the group of: "+resultSet.getString("group")+", It's brand is: "+resultSet.getString("brand")+", It's model is: "+resultSet.getString("model")+", It's amount is: "+resultSet.getLong("amount")+", It's price is: "+resultSet.getDouble("price")+"\n";
      	}
  sendList = sendList + "Type in the ID and the amount of the items you would like to request: ";
  try
  {
	  out = new DataOutputStream(threadSocket.getOutputStream());
	  out.writeUTF(sendList);
	  out.flush();
  }
  catch(IOException e)
  {
    System.out.println("Не мога да изпратя списъка");
      }
      
	    }
	    catch(SQLException e){
		      e.printStackTrace();
		    }
		    finally{
		      try{
		        if(stmt != null) stmt.close();
		        if(resultSet != null) resultSet.close();
		        if(link != null) link.close();
		      }
		      catch(SQLException e2){
			        e2.printStackTrace();
			      }
		    }
  }
	  
  static void removeClient(Socket c)
  {
    synchronized(clients)
    {
      System.out.println("Премахвам клиент "+c);
  clients.remove(clients.indexOf(c));
  try{
    c.close();
  }
  catch(IOException e)
  {
    System.out.println("Не мога да затворя връзка с клиент");
      }
    }
  }
  
  static void idpick(int message, int message2, DataOutputStream out, Socket threadSocket)
  {
	  String url = "jdbc:mysql://localhost:3306/storehouse";
    String user = "root";
    String pass = "9205193966";
    Connection link = server.connect(url, user, pass);
    if(link == null)
    {
        System.out.println("Опа, MySQL не е пуснат!");
        return;
    }
      else
      {
        System.out.println("Свързах се с MySQL сървъра!");
      }
    Statement stmt = null;
    ResultSet resultSet = null;
    String requestSend = "";
    try{
    	stmt = link.createStatement();
        PreparedStatement idRequest;
        idRequest = link.prepareStatement("SELECT groups.group, brands.brand, products.model, products.amount, products.price FROM products, groups, brands WHERE products.group_id=groups.id AND products.brand_id=brands.id AND products.id = ? ");
        idRequest.setInt(1, message);
        resultSet = idRequest.executeQuery();
        while (resultSet.next())
        {
        int amount = resultSet.getInt("amount");
        double price = resultSet.getDouble("price");
        requestSend = requestSend+"You have requested: "+resultSet.getString("group") +" " +resultSet.getString("brand") +" " +resultSet.getString("model")+"\n"+"The quantity is: "+amount+" The price for a single item is: "+price+" leva\n";
        if (message2<=0 || message2>amount)
    	{
    	requestSend ="The requested quantity does not match the available amount of items!!! Please choose different product or a proper quantity request for the current one!";
    	}
    if(message2>10)
    {
    	requestSend = requestSend+"You requested: " +message2 +"items. The owed sum total is: "+(message2*price) +"leva." +" You have a discount of 10% for ordering more than 10 items! The final cost of the requested stock is:" +(message2*price)*0.9 +" leva.";
    }
    	else requestSend= requestSend +"You requested: " +message2 +"items. The owed sum total is: "+(message2*price) +"leva."; 
        }
        try 
        {
        	requestSend = requestSend +"\nType in the ID and the amount of the items you would like to request: ";
        	out = new DataOutputStream(threadSocket.getOutputStream());
	    	out.writeUTF(requestSend);
	    	out.flush();
		} 
        catch(IOException e)
	      {
	        System.out.println("Не мога да изпратя списъка");
		      }
	    } 
	    catch(SQLException e)
	    {
		 e.printStackTrace();
		}
		    finally
		    {
		      try
		      {
		        if(stmt != null) stmt.close();
		        if(resultSet != null) resultSet.close();
		        if(link != null) link.close();   
		      }
		      catch(SQLException e2){
		        e2.printStackTrace();
		      }
		    }
  }
}