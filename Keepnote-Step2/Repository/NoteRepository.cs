﻿using System;
using System.Collections.Generic;
using System.Linq;
using Keepnote.Models;
using Microsoft.EntityFrameworkCore;

namespace Keepnote.Repository
{
    public class NoteRepository : INoteRepository
    {

        // Save the note in the database(note) table.
        private KeepNoteContext _context;

        public NoteRepository(KeepNoteContext con)
        {
            _context = con;
        }
        
        public int AddNote(Note note)
        {
            try
            {
                note.CreatedAt = DateTime.Now;
                _context.Notes.Add(note);
                _context.SaveChanges();
                return 1;
            }
            catch(Exception e)
            {
                return 0;
            }
            

        }
        //Remove the note from the database(note) table.
        public int DeletNote(int noteId)
        {
            if(Exists(noteId))
            {
                Note note = _context.Notes.FirstOrDefault(i=>i.NoteId==noteId);
                _context.Notes.Remove(note);
                _context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }

        }

        //can be used as helper method for controller
        public bool Exists(int noteId)
        {
            List<Note> objList = new List<Note>();
            objList = _context.Notes.Where(x => x.NoteId == noteId).ToList();
            if (objList != null && objList.Count > 0)
                return true;
            return false;
        }

        /* retrieve all existing notes sorted by created Date in descending
         order(showing latest note first)*/
        public List<Note> GetAllNotes()
        {
            return _context.Notes.OrderByDescending(note => note.CreatedAt).ToList();
        }

        //retrieve specific note from the database(note) table
        public Note GetNoteById(int noteId)
        {
           
             return _context.Notes.Find(noteId);
            
        }
        //Update existing note
        public int UpdateNote(Note note)
        {
            try
            {
                Note n = _context.Notes.Find(note.NoteId);
                n.NoteStatus = note.NoteStatus;
                n.NoteTitle = note.NoteTitle;
                n.NoteContent = note.NoteContent;
                _context.Entry(n).State = EntityState.Modified;
                _context.SaveChanges();
                return 1;

            }catch(Exception e)
            {
                return 0;
            }
        }
    }
}
