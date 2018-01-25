using ElevenNote.Models;
using ElevenNote.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ElevenNote.WebApi.Controllers
{
    [Authorize]
    public class NoteController : ApiController
    {
        // GET /api/note
        public IHttpActionResult Get()
        {
            NoteService noteService = CreateNoteService();
            

            var notes = noteService.GetNotes();

            return Ok(notes);
        }


        //GET /api/note/4
        public IHttpActionResult Get(int id)
        {
            NoteService noteSvc = CreateNoteService();

            var note = noteSvc.GetNoteById(id);

            return Ok(note);
        }

        //Post /api/note

            public IHttpActionResult Post(NoteCreate note)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

           var svc =  CreateNoteService();
            if (!svc.CreateNote(note))
                return InternalServerError();

            return Ok();

        }

        //Put /api/note

            public IHttpActionResult Put(NoteEdit note)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var svc = CreateNoteService();
            if (!svc.UpdateNote(note))
            {
                return InternalServerError();
            }

            return Ok();
        }

        //DELETE /api/note/5

            public IHttpActionResult DeleteNote(int Id)
        {
            var svc = CreateNoteService();
            if (!svc.DeleteNote(Id))
            {
                return InternalServerError();
            }

            return Ok();
        }


        private NoteService CreateNoteService()
        {
            var userID = Guid.Parse(User.Identity.GetUserId());
            var noteService = new NoteService(userID);
            return noteService;
        }
    }
}
