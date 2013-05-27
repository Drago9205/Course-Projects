
import java.io.Closeable;
import java.io.IOException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.Statement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Scanner;
import java.sql.PreparedStatement;

import javax.swing.plaf.basic.BasicSplitPaneUI.KeyboardDownRightHandler;

public class Storehouse
{
	 private static Connection connect(String url, String user, String password)
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
	 
public static void main(String[] args)
{
	
	String url = "jdbc:mysql://localhost:3306/storehouse";
    String user = "root";
    String pass = "9205193966";
    Connection link = Storehouse.connect(url, user, pass);
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
    Scanner keyboard = new Scanner(System.in);
    try{
      stmt = link.createStatement();
      resultSet = stmt.executeQuery("SELECT products.id, groups.group, brands.brand, products.model, products.amount, products.price FROM products, groups, brands WHERE products.group_id=groups.id AND products.brand_id=brands.id ORDER BY products.id");

      while (resultSet.next()) 
      {

    	System.out.println("Item with id: "+resultSet.getShort("id"));
        System.out.print("Is from the group of: "+resultSet.getString("group"));
        System.out.print(", It's brand is: "+resultSet.getString("brand"));
        System.out.print(", It's model is: "+resultSet.getString("model"));
        System.out.print(", It's amount is: "+resultSet.getLong("amount"));
        System.out.println(", It's price is: "+resultSet.getDouble("price"));
        System.out.println();
      	}
      
        do
        {
        // IDPick е ид-то на предмета, който заявявам, а амаунт е количеството което желая
        int userIDPick, userAmountPick;
        System.out.println("Please type in the id of the item you would like to request: ");
        userIDPick = keyboard.nextInt();
        
        
        //PreparedStatement използвам, за да мога да направя заявка използвайки данните получени от скенера
        PreparedStatement idRequest;
        idRequest = link.prepareStatement("SELECT groups.group, brands.brand, products.model, products.amount, products.price FROM products, groups, brands WHERE products.group_id=groups.id AND products.brand_id=brands.id AND products.id = ? ");
        idRequest.setInt(1, userIDPick);
        resultSet = idRequest.executeQuery();
        while (resultSet.next())
        {
	    System.out.println("You have requested: "+resultSet.getString("group") +" " +resultSet.getString("brand") +" " +resultSet.getString("model"));
        int amount = resultSet.getInt("amount");
        double price = resultSet.getDouble("price");
        System.out.println("The quantity is: " +amount +" The price for a single item is: " +price +"leva");
        System.out.println("Please type in the quantity you would like to request: ");
        userAmountPick = keyboard.nextInt();
        if (userAmountPick<=0 || userAmountPick>amount)
        	{
        	System.out.println("The requested quantity does not match the available amount of items!!! Please choose different product or a proper quantity request for the current one!");
        	System.out.println();
        	continue;
        	}
        if(userAmountPick>10)
        {
        	System.out.println("You requested: " +userAmountPick +"items. The owed sum total is: "+(userAmountPick*price) +"leva." +" You have a discount of 10% for ordering more than 10 items! The final cost of the requested stock is:" +(userAmountPick*price)*0.9 +" leva.");
        }
        	else System.out.println("You requested: " +userAmountPick +"items. The owed sum total is: "+(userAmountPick*price) +"leva.");
		        
		        }
		        
		        }
		        while (1==1);
   
		     
		    }  
		    catch(SQLException e){
		      e.printStackTrace();
		    }
		    finally{
		      try{
		        if(stmt != null) stmt.close();
		        if(resultSet != null) resultSet.close();
		        if(link != null) link.close();
		        keyboard.close();
		      }
		      catch(SQLException e2){
		        e2.printStackTrace();
		      }
		    }
		  }
}

