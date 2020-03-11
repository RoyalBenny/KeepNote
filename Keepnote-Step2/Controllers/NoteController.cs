using Microsoft.AspNetCore.Mvc;

namespace Keepnote.Controllers
{
    public class NoteController : Controller
    {
        /*
	     From the problem statement, we can understand that the application
	     requires us to implement the following functionalities.
	     1. display the list of existing notes from the collection. Each note 
	        should contain Note Id, title, content, status and created date.
	     2. Add a new note which should contain the title, content and status.
	     3. Delete an existing note.
         4. Update an existing Note.
	    */
        
        //Inject the noteRepository instance through constructor injection.
        
        /*
      * Define a handler method to read the existing notes from the database and add
      * it to the ModelMap which is an implementation of Map, used when building
      * model data for use with views. it should map to the default URL i.e. "/index"
      */

        /*
         * Define a handler method which will read the NoteTitle, NoteContent,
         * NoteStatus from request parameters and save the note in note table in
         * database. Please note that the CreatedAt should always be auto populated with
         * system time and should not be accepted from the user. Also, after saving the
         * note, it should show the same along with existing messages. Hence, reading
         * note has to be done here again and the retrieved notes object should be sent
         * back to the view. This handler method should map to the URL "/create".
         */

        /*
         * Define a handler method which will read the NoteId from request parameters
         * and remove an existing note by calling the deleteNote() method of the
         * NoteRepository class.".
         */

        /*
         * Define a handler method which will update the existing note.
         */
    }
}