using System.Collections.Generic;
using System.Linq;
using Keepnote.Models;
using Microsoft.EntityFrameworkCore;

namespace Keepnote.Repository
{
    public class NoteRepository : INoteRepository
    {

        // Save the note in the database(note) table.
        public int AddNote(Note note)
        {
            throw new System.NotImplementedException();
        }
        //Remove the note from the database(note) table.
        public int DeletNote(int noteId)
        {
            throw new System.NotImplementedException();
        }
        
        //can be used as helper method for controller
        public bool Exists(int noteId)
        {
            throw new System.NotImplementedException();
        }

       /* retrieve all existing notes sorted by created Date in descending
        order(showing latest note first)*/
        public List<Note> GetAllNotes()
        {
            throw new System.NotImplementedException();
        }

        //retrieve specific note from the database(note) table
        public Note GetNoteById(int noteId)
        {
            throw new System.NotImplementedException();
        }
        //Update existing note
        public int UpdateNote(Note note)
        {
            throw new System.NotImplementedException();
        }
    }
}
