
package BirdArrayPackage;
 
import java.util.*;
import javax.swing.*;

/**
 * A program that can store, remove, add and display bird names from an ArrayList.
 * 
 */
public class BirdArrayList 
{
	/**
	 * Main class. All of the decision making code resides hear
	 * 
	 * @param args Main Method 
	 */
	public static void main(String[] args)
	{	
		char response;
		//String of the text for the main dialog.
		final String menu = "Please slect for the following options." 
				+  "\nEnter A to add a bird name to the list" + "\nEnter R to removed a bird name form the list" 
				+ "\nEnter S to search the bird names in list" + "\nEnter D to display names in list" 
				+ "\nEnter Q to quit";
		//String of the title for the main dialog.
		final String title = "BirdArrayList";
		
		//create the ArrayList.
		ArrayList<String> bName = new ArrayList<String>();
		//Initializing and fill the ArrayList with string values.
		bName.add("Emu");						//Reference https://en.wikipedia.org/wiki/List_of_birds_by_common_name
		bName.add("Southern brown kiwi");		//Reference https://en.wikipedia.org/wiki/List_of_birds_by_common_name
		bName.add("Southern screamer");			//Reference https://en.wikipedia.org/wiki/List_of_birds_by_common_name
		bName.add("Magpie goose");				//Reference https://en.wikipedia.org/wiki/List_of_birds_by_common_name
		bName.add("White-faced whistling duck");//Reference https://en.wikipedia.org/wiki/List_of_birds_by_common_name
	
		//Main loop. What ever choice is entered, its check but running it against nested if statement block
		do
			{
			String answer = JOptionPane.showInputDialog(null, menu, title, JOptionPane.INFORMATION_MESSAGE);
			answer = answer.toUpperCase();
			response = answer.charAt(0);
						
			if(response == 'A')
			{
				addToArray(bName);// Use Method addToArray 
			}
			else
			{
				if(response == 'R')
				{
					deleteEntry(bName);// Use Method deleteEntry
				}
				else
				{
					if(response == 'S')
					{
						searchArray(bName);// Use Method searchArray
					}
					else
					{
						if(response == 'D')
						{
							displayArray(bName);//Use Method displayArray
						}
						
						//If response dose not equal any of are required response variables, Display a MessageDialog box informing the user. 
						if(response != 'A' && response != 'R' && response != 'S' && response != 'D' && response != 'Q')
						{
							JOptionPane.showMessageDialog(null,"Please enter a valed option\n" + menu, title, JOptionPane.ERROR_MESSAGE);
						} 	
							
					}
				}
			}
			
			}while(response != 'Q');
			JOptionPane.showMessageDialog(null, "Thank You", title, JOptionPane.INFORMATION_MESSAGE);
	}
	
	/**
	 * This method handles removing a string from the ArrayList.
	 * @param bName ArrayList
	 */
	public static void addToArray(ArrayList<String> bName)
	{
		//Asks user to enter a name to the ArrayList, adds userInput to the ArrayList then prints the ArrayList to a dialog.
		String userInput = JOptionPane.showInputDialog(null, "Please enter a new bird name to the name list", "BirdArrayList", JOptionPane.INFORMATION_MESSAGE);
		bName.add(bName.size(), userInput);
		displayArray(bName);
	}
	/**
	 * This method handles removing a string from the ArrayList.
	 * @param bName ArrayList
	 */
	public static void deleteEntry(ArrayList<String> bName)
	{	
		//Needed variables. 
		int r;
		boolean nameFound  = false;
		
		// Asks user what string they want to removed for ArrayList bName.
		String userInput = JOptionPane.showInputDialog(null, "Please enter the bird name you wish to remove form the list.", "BirdArrayList", JOptionPane.INFORMATION_MESSAGE);
		
		//For Loop to start a beginning of the ArrayList to the end.
		for(r = 0; r < bName.size(); r++)
			{
				//When a match is found, tell user that String was found in ArrayList bName and ok to remove
				//Then displays prints the contents of the ArrayList into a MessageDialog box
				if(userInput.equals(bName.get(r)));
				{
					nameFound = true;
					JOptionPane.showMessageDialog(null, "The bird name " + userInput + " was found in the name list, Press ok to remove", "BirdArrayList", JOptionPane.INFORMATION_MESSAGE );
					bName.remove(userInput);
					JOptionPane.showMessageDialog(null,"After Removing " + userInput + " the new bird name list look like this\n" + bName, "BirdArrayList", JOptionPane.INFORMATION_MESSAGE);
					r = bName.size();
				
					//If no match was found, display a messageDialog box informing the user.
					if(nameFound == false)
					{
						JOptionPane.showMessageDialog(null, "Sorry name not fond in name list, please try agane", "BirdArrayList", JOptionPane.ERROR_MESSAGE );
					}
				}
			}
	}
	/**
	 *This method handles searching the ArrayList for a String.		
	 * @param bName ArrayList
	 */
	
	//Search the ArrayList bName for a matching string and return its location in the ArrayList.
	public static void searchArray(ArrayList<String> bName)
	{ 
		//needed variables.
		int i;
		int namePos;
		String birdN;
		boolean nameFound = false;
		
		//Asks user what String the want to search for in the ArrayList bName
		String userInput = JOptionPane.showInputDialog(null, "Please enter the bird name you wish to search for.", "BirdArrayList", JOptionPane.INFORMATION_MESSAGE);
		
		//For Loop to start a beginning of the ArrayList to the end.
		for(i = 0; i < bName.size(); ++i)
		{
			//When a match is found, tell user that String was found in ArrayList and its position in ArrayList. 
			if(userInput.equals(bName.get(i)))
			{
				birdN = bName.get(i);
				namePos = bName.indexOf(userInput);
				JOptionPane.showMessageDialog(null, "The bird name " + birdN + " was found in the list and is in position " + namePos, "BirdArrayList", JOptionPane.INFORMATION_MESSAGE );
				nameFound = true;
			}
		}
		     
			//If no match was found, display a messageDialog box informing the user.
			if(nameFound == false)
			{
				JOptionPane.showMessageDialog(null, "Sorry name not fond in name list, please try agane", "BirdArrayList", JOptionPane.ERROR_MESSAGE );
			}
		
	}
	/**
	 * This Method Prints the contents of the ArrayList into a MessageDialog box
	 * @param bName ArrayList
	 */
	public static  void displayArray(ArrayList<String> bName)
	{
		//Prints the contents of the ArrayList bName into a MessageDialog box
		
		JOptionPane.showMessageDialog(null, "Bird names currently in the list" 
		+ "\n" + bName,"BirdArrayList" , JOptionPane.INFORMATION_MESSAGE);
		
		
	}

}
